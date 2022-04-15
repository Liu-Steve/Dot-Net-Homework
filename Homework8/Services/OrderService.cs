using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ArgE = System.ArgumentException;

namespace Homework8
{
    public class OrderService
    {
        private int nextOrderID = 0, nextProductID = 0, nextClientID = 0;
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
        public List<Client> Clients { get; set; }
        public OrderService()
        {
            Orders = new List<Order>();
            Products = new List<Product>();
            Clients = new List<Client>();
        }

        /// <summary>
        /// add client into service
        /// </summary>
        /// <param name="name">client name</param>
        public int AddClient(string name)
        {
            Client client = new Client(nextClientID, name);
            nextClientID++;
            Clients.Add(client);
            return client.ID;
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
            Product product = new Product(nextProductID, name, price);
            nextProductID++;
            Products.Add(product);
            return product.ID;
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
            //find match client
            var matchClient = Clients.Where(c => c.ID == clientID);
            Client client = matchClient.FirstOrDefault();
            if (client == null)
                throw new ArgE($"client {clientID} isn't exist");
            //create order
            Order order = new Order(nextOrderID, client, discount);
            nextOrderID++;
            Orders.Add(order);
            return order.ID;
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
            //find match order
            var matchOrder = Orders.Where(o => o.ID == orderID);
            Order order = matchOrder.FirstOrDefault();
            if (order == null)
                throw new ArgE($"order {orderID} isn't exist");
            //find match product
            var matchProduct = Products.Where(p => p.ID == productID);
            Product product = matchProduct.FirstOrDefault();
            if (product == null)
                throw new ArgE($"product {productID} isn't exist");
            //change detial
            OrderDetials detial = new OrderDetials(product, number);
            order.Change(detial);
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
            //find match order
            var matchOrder = Orders.Where(o => o.ID == orderID);
            Order order = matchOrder.FirstOrDefault();
            if (order == null)
                throw new ArgE($"order {orderID} isn't exist");
            //find match client
            var matchClient = Clients.Where(c => c.ID == clientID);
            Client client = matchClient.FirstOrDefault();
            order.Client = client ?? 
                throw new ArgE($"client {clientID} isn't exist");
        }

        /// <summary>
        /// change discount of order
        /// </summary>
        /// <param name="orderID">ID of order</param>
        /// <param name="discount">discount: 1 = ￥0.01</param>
        /// <exception cref="ArgE">order isn't exist</exception>
        public void ChangeDiscount(int orderID, int discount)
        {
            //find match order
            var matchOrder = Orders.Where(o => o.ID == orderID);
            Order order = matchOrder.FirstOrDefault();
            if (order == null)
                throw new ArgE($"order {orderID} isn't exist");
            order.Discount = discount;
        }

        public delegate bool OrderFilter(Order order);

        /// <summary>
        /// selelt order as filter select
        /// </summary>
        /// <param name="filter">return bool</param>
        /// <returns>List contains deep copyed orders</returns>
        public List<Order> Select(OrderFilter filter)
        {
            List<Order> res = new List<Order>();
            List<Order> select = 
                Orders.Where(o => filter(o.DeepCopy()))
                .OrderBy(o => o.SumPrice)
                .ToList();
            select.ForEach(o => res.Add(o.DeepCopy()));
            return res;
        }

        /// <summary>
        /// delete order as filter select
        /// </summary>
        /// <param name="filter">return bool</param>
        /// <returns>the number of row affected by delete</returns>
        public int Delete(OrderFilter filter)
        {
            List<Order> select = 
                Orders.Where(o => filter(o.DeepCopy()))
                .OrderBy(o => o.SumPrice)
                .ToList();
            int num = select.Count;
            select.ForEach(o => Orders.Remove(o));
            return num;
        }

        /// <summary>
        /// delete order by ID
        /// </summary>
        /// <param name="orderID">ID of order</param>
        /// <exception cref="ArgE">order isn't exist</exception>
        public void Delete(int orderID)
        {
            //find match order
            var matchOrder = Orders.Where(o => o.ID == orderID);
            Order order = matchOrder.FirstOrDefault();
            if (order == null)
                throw new ArgE($"order {orderID} isn't exist");
            Orders.Remove(order);
        }

        /// <summary>
        /// sort orders, default by ID in increase order
        /// </summary>
        /// <param name="cmp">default by ID in increase order</param>
        public void Sort(Comparison<Order> cmp = null)
        {
            if (cmp == null)
                cmp = (o1, o2) => o1.ID - o2.ID;
            Orders.Sort(cmp);
        }

        /// <summary>
        /// export orders to xml
        /// </summary>
        /// <param name="name">xml name</param>
        public void Export(string name)
        {
            //xml serializer
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = 
                new FileStream($"../../../xml/{name}.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, Orders);
            }
        }

        /// <summary>
        /// import orders from xml
        /// </summary>
        /// <param name="name">xml name</param>
        public void Import(string name)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs =
                new FileStream($"../../../xml/{name}.xml", FileMode.Open))
            {
                List<Order> ordersImport = 
                    (List<Order>)xmlSerializer.Deserialize(fs);
                ordersImport.ForEach(o => Orders.Add(o));
            }
        }
    }
}
