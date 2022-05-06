using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArgE = System.ArgumentException;

namespace Services
{
    [Serializable]
    public class Order : IComparable
    {
        public int OrderID { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public List<OrderDetials> Detials { get; set; }
        public int Discount { get; set; }
        public int SumPrice
        {
            get
            {
                int sum = 0;
                foreach (OrderDetials i in Detials)
                {
                    sum += i.SumPrice;
                }
                return sum - Discount;
            }
        }

        public Order() { }

        public Order(int id, Client client, int discount = 0, 
            List<OrderDetials> detials = null)
        {
            OrderID = id;
            ClientID = client.ClientID;
            Client = client;
            if (detials != null)
                Detials = detials;
            else
                Detials = new List<OrderDetials>();
            Discount = discount;
        }

        /// <remarks>
        /// product should be unique
        /// </remarks>
        public void Change(OrderDetials detials)
        {
            using (var context = new OrderContext())
            {
                bool findMatch = false;
                OrderDetials matchDetial = null;
                //why list to list?
                //because Detials could be modified in foreach
                //and it will throw an exception called
                //"Collection was modified; enumeration operation may not execute"
                //to get rid of it, we need a new list
                foreach (OrderDetials d in context.Detials)
                {
                    if (d.ProductID == detials.ProductID && d.OrderID == detials.OrderID)
                    {
                        findMatch = true;
                        if (d.Number + detials.Number < 0)
                        {
                            throw new ArgE("product isn't enough");
                        }
                        else if (d.Number + detials.Number == 0)
                        {
                            //Detials.Remove(d);
                            //matchDetial = d;
                            d.OrderID = -1;
                        }
                        else
                        {
                            d.Number += detials.Number;
                            break;
                        }
                    }
                }
                if (matchDetial != null)
                {
                    context.Detials.Remove(matchDetial);
                }
                if (!findMatch)
                {
                    if (detials.Number <= 0)
                    {
                        throw new ArgE("product's number isn't postive");
                    }
                    context.Detials.Add(detials);
                }
                context.SaveChanges();
            }
        }

        public bool Exists(int productID)
        {
            return Detials.Exists(d => d.Product.ProductID == productID);
        }

        public bool Exists(string productName)
        {
            return Detials.Exists(d => d.Product.Name == productName);
        }

        public IEnumerator<OrderDetials> GetEnumerator()
        {
            foreach(OrderDetials detial in Detials)
            {
                yield return detial;
            }
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Order o))
                return 1;
            return OrderID - o.OrderID;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Order o))
                return false;
            int length = Detials.Count;
            if (length != o.Detials.Count)
                return false;
            bool detialsMatch = true;
            Detials.Sort();
            o.Detials.Sort();
            for (int i = 0; i < length; ++i)
            {
                if(Detials[i] != o.Detials[i])
                {
                    detialsMatch = false;
                    break;
                }
            }
            return detialsMatch && OrderID == o.OrderID && Client.Equals(o.Client);
        }

        public override int GetHashCode()
        {
            return OrderID;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"Order:\nOrder ID:\t{OrderID}\n{Client}\nDetials:\n");
            str.Append($"\tName\tID\tPrice\tNumber\n");
            Detials.Sort();
            int idx = 1;
            foreach(OrderDetials detial in Detials)
            {
                Product p = detial.Product;
                str.Append($"{idx}.\t{p.Name}\t{p.ProductID}\t" + 
                    $"￥{p.Price/100.0}\t{detial.Number}\n");
                idx++;
            }
            str.Append($"Discount:\t￥{Discount/100.0}\n");
            str.Append($"Sum Price:\t￥{SumPrice/100.0}");
            return str.ToString();
        }
    }
}
