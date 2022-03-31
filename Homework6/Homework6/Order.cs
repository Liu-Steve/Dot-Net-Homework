using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArgE = System.ArgumentException;

namespace Homework6
{
    [Serializable]
    public class Order : IComparable
    {
        public int ID { get; set; }

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
            ID = id;
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
            bool findMatch = false;
            //why list to list?
            //because Detials could be modified in foreach
            //and it will throw an exception called
            //"Collection was modified; enumeration operation may not execute"
            //to get rid of it, we need a new list
            foreach (OrderDetials d in Detials.ToList())
            {
                if(d.Product.ID == detials.Product.ID)
                {
                    findMatch = true;
                    if (d.Number + detials.Number < 0)
                    {
                        throw new ArgE("product isn't enough");
                    }
                    else if (d.Number + detials.Number == 0)
                    {
                        Detials.Remove(d);
                    }
                    else
                    {
                        d.Number += detials.Number;
                        break;
                    }
                }
            }
            if(!findMatch)
            {
                if(detials.Number <= 0)
                {
                    throw new ArgE("product's number isn't postive");
                }
                Detials.Add(detials);
            }
        }

        public bool Exists(int productID)
        {
            return Detials.Exists(d => d.Product.ID == productID);
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
            if (obj is not Order o)
                return 1;
            return ID - o.ID;
        }

        public override bool Equals(object obj)
        {
            if (obj is not Order o)
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
            return detialsMatch && ID == o.ID && Client.Equals(o.Client);
        }

        public override int GetHashCode()
        {
            return ID;
        }

        public override string ToString()
        {
            StringBuilder str = new();
            str.Append($"Order:\nOrder ID:\t{ID}\n{Client}\nDetials:\n");
            str.Append($"\tName\tID\tPrice\tNumber\n");
            Detials.Sort();
            int idx = 1;
            foreach(OrderDetials detial in Detials)
            {
                Product p = detial.Product;
                str.Append($"{idx}.\t{p.Name}\t{p.ID}\t" + 
                    $"￥{p.Price/100.0}\t{detial.Number}\n");
                idx++;
            }
            str.Append($"Discount:\t￥{Discount/100.0}\n");
            str.Append($"Sum Price:\t￥{SumPrice/100.0}");
            return str.ToString();
        }

        public Order DeepCopy()
        {
            List<OrderDetials> newList = new();
            foreach(OrderDetials detials in Detials)
            {
                newList.Add(detials.DeepCopy());
            }
            Order newOrder = new(ID, Client.DeepCopy(), Discount, newList);
            return newOrder;
        }
    }
}
