using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ArgE = System.ArgumentException;

namespace Services
{
    public class OrderService
    {
        private int 
            nextOrderID = 0, 
            nextProductID = 0, 
            nextClientID = 0, 
            nextDetialID = 0;
        //public List<Order> Orders { get; set; }
        //public List<Product> Products { get; set; }
        //public List<Client> Clients { get; set; }
        public OrderService()
        {
            //Orders = new List<Order>();
            //Products = new List<Product>();
            //Clients = new List<Client>();
        }

        /// <summary>
        /// add client into service
        /// </summary>
        /// <param name="name">client name</param>
        public int AddClient(string name)
        {
            using (var context = new OrderContext())
            {
                Client client = new Client(nextClientID, name);
                nextClientID++;
                context.Clients.Add(client);
                context.SaveChanges();
                return client.ClientID;
            }
        }

        /// <summary>
        /// add new product into service
        /// </summary>
        /// <param name="name">product name</param>
        /// <param name="price">
        /// product price
        /// <br/>
        /// price: 1 = ￥0.01
        /// </param>
        public int AddProduct(string name, int price)
        {
            using (var context = new OrderContext())
            {
                Product product = new Product(nextProductID, name, price);
                nextProductID++;
                context.Products.Add(product);
                context.SaveChanges();
                return product.ProductID;
            }
        }

        /// <summary>
        /// add new order
        /// </summary>
        /// <param name="clientID">ID of client</param>
        /// <param name="discount">
        /// default 0
        /// <br/>
        /// discount: 1 = ￥0.01
        /// </param>
        public int AddOrder(int clientID, int discount = 0)
        {
            using (var context = new OrderContext())
            {
                //find match client
                var matchClient = context.Clients.Where(c => c.ClientID == clientID);
                Client client = matchClient.FirstOrDefault();
                if (client == null)
                    throw new ArgE($"client {clientID} isn't exist");
                //create order
                Order order = new Order(nextOrderID, client, discount);
                nextOrderID++;
                context.Orders.Add(order);
                context.SaveChanges();
                return order.OrderID;
            }
        }

        /// <summary>
        /// change product number
        /// <br/>
        /// if the detial contains product doesn't exist, 
        /// this detial will be created
        /// <br/>
        /// if the number return to 0, this detial will be removed
        /// </summary>
        /// <param name="orderID">ID of order</param>
        /// <param name="productID">ID of product</param>
        /// <param name="number">number increase or decrease</param>
        /// <exception cref="ArgE">order isn't exist</exception>
        /// <exception cref="ArgE">product isn't exist</exception>
        /// <exception cref="ArgE">product isn't enough</exception>
        /// <exception cref="ArgE">product's number isn't postive</exception>
        public void ChangeOrderDetial(int orderID, int productID, int number)
        {
            using (var context = new OrderContext())
            {
                //find match order
                var matchOrder = context.Orders.Where(o => o.OrderID == orderID);
                Order order = matchOrder.FirstOrDefault();
                if (order == null)
                    throw new ArgE($"order {orderID} isn't exist");
                //find match product
                var matchProduct = context.Products.Where(p => p.ProductID == productID);
                Product product = matchProduct.FirstOrDefault();
                if (product == null)
                    throw new ArgE($"product {productID} isn't exist");
                //change detial
                nextDetialID++;
                OrderDetials detial = new OrderDetials(
                    nextDetialID, product, number, order);
                order.Change(detial);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// change client of order
        /// </summary>
        /// <param name="orderID">ID of order</param>
        /// <param name="clientID">ID of client</param>
        /// <exception cref="ArgE">order isn't exist</exception>
        /// <exception cref="ArgE">client isn't exist</exception>
        public void ChangeClient(int orderID, int clientID)
        {
            using (var context = new OrderContext())
            {
                //find match order
                var matchOrder = context.Orders.Where(o => o.OrderID == orderID);
                Order order = matchOrder.FirstOrDefault();
                if (order == null)
                    throw new ArgE($"order {orderID} isn't exist");
                //find match client
                var matchClient = context.Clients.Where(c => c.ClientID == clientID);
                Client client = matchClient.FirstOrDefault();
                order.Client = client ??
                    throw new ArgE($"client {clientID} isn't exist");
                context.SaveChanges();
            }
        }

        /// <summary>
        /// change discount of order
        /// </summary>
        /// <param name="orderID">ID of order</param>
        /// <param name="discount">discount: 1 = ￥0.01</param>
        /// <exception cref="ArgE">order isn't exist</exception>
        public void ChangeDiscount(int orderID, int discount)
        {
            using (var context = new OrderContext())
            {
                //find match order
                var matchOrder = context.Orders.Where(o => o.OrderID == orderID);
                Order order = matchOrder.FirstOrDefault();
                if (order == null)
                    throw new ArgE($"order {orderID} isn't exist");
                order.Discount = discount;
                context.SaveChanges();
            }
        }

        public delegate bool OrderFilter(Order order);

        /// <summary>
        /// selelt order as filter select
        /// </summary>
        /// <param name="filter">return bool</param>
        /// <returns>List contains deep copyed orders</returns>
        public List<Order> Select(OrderFilter filter)
        {
            using (var context = new OrderContext())
            {
                List<Order> res = new List<Order>();
                List<Order> select =
                    context.Orders.Where(o => filter(o))
                    .OrderBy(o => o.SumPrice)
                    .ToList();
                select.ForEach(o => res.Add(o));
                context.SaveChanges();
                return res;
            }
        }

        /// <summary>
        /// delete order as filter select
        /// </summary>
        /// <param name="filter">return bool</param>
        /// <returns>the number of row affected by delete</returns>
        public int Delete(OrderFilter filter)
        {
            using (var context = new OrderContext())
            {
                List<Order> select =
                    context.Orders.Where(o => filter(o))
                    .OrderBy(o => o.SumPrice)
                    .ToList();
                int num = select.Count;
                select.ForEach(o => context.Orders.Remove(o));
                context.SaveChanges();
                return num;
            }
        }

        /// <summary>
        /// delete order by ID
        /// </summary>
        /// <param name="orderID">ID of order</param>
        /// <exception cref="ArgE">order isn't exist</exception>
        public void Delete(int orderID)
        {
            using (var context = new OrderContext())
            {
                //find match order
                var matchOrder = context.Orders.Where(o => o.OrderID == orderID);
                Order order = matchOrder.FirstOrDefault();
                if (order == null)
                    throw new ArgE($"order {orderID} isn't exist");
                context.Orders.Remove(order);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// sort orders, default by ID in increase order
        /// </summary>
        /// <param name="cmp">default by ID in increase order</param>
        public void Sort(Comparison<Order> cmp = null)
        {
            using (var context = new OrderContext())
            {
                if (cmp == null)
                    cmp = (o1, o2) => o1.OrderID - o2.OrderID;
                context.Orders.OrderBy(x => x.OrderID);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// export orders to xml
        /// </summary>
        /// <param name="name">xml name</param>
        public void Export(string name)
        {
            using (var context = new OrderContext())
            {
                //xml serializer
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                if (!Directory.Exists("../../../xml"))
                {
                    //路径不存在创建路径
                    Directory.CreateDirectory("../../../xml");
                }
                using (FileStream fs =
                    new FileStream($"../../../xml/{name}.xml", FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, context.Orders);
                }
                context.SaveChanges();
            }
        }

        /// <summary>
        /// import orders from xml
        /// </summary>
        /// <param name="name">xml name</param>
        public void Import(string name)
        {
            using (var context = new OrderContext())
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs =
                    new FileStream($"../../../xml/{name}.xml", FileMode.Open))
                {
                    List<Order> ordersImport =
                        (List<Order>)xmlSerializer.Deserialize(fs);
                    ordersImport.ForEach(o => context.Orders.Add(o));
                }
                context.SaveChanges();
            }
        }
    }
}
