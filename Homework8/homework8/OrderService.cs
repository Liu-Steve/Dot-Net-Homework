using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace homework8
{
    public class OrderService
    {
        private List<Order> orders = new List<Order>();
        
        public List<Order> Orders { get { return orders; } }
        public void AddOneOrder(Order order)
        {            
            orders.Add(order);
        }

        public void DeleteOneOrder(int IDDelete)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].ID == IDDelete)
                {
                    orders.Remove(orders[i]);
                    return;
                }
            }
            throw new ArgumentException("不存在该ID的订单");
        }

        public void UpdateOrder(int IDUpdate, Order newOrder)
        {
            DeleteOneOrder(IDUpdate);
            newOrder.ID = IDUpdate;
            orders.Add(newOrder);
        }
        public List<Order> SearchById(int id)
        {
            var query = orders.Where(
                o => o.ID == id);
            return query.ToList();
        }
        public List<Order> SearchByGoodName(string goodname)
        {
            var query = orders.Where(
                o => o.Goods.Any(d => d.GoodName == goodname));
            return query.ToList();
        }
        public List<Order> SearchByTotalPrice(double price)
        {
            var query = orders.Where(
                o => o.CostSum == price);
            return query.ToList();
        }
        public List<Order> SearchBySenderName(string sender)
        {
            var query = orders.Where(
                o => o.Sender == sender);
            return query.ToList();
        }
        public void Sort()
        {
            for (int i = 0; i < orders.Count - 1; i++)
            {
                for (int j = 0; j < orders.Count - i - 1; j++)
                {
                    if (orders[j].ID > orders[j + 1].ID)
                    {
                        Order orderTemp = orders[j];
                        orders[j] = orders[j + 1];
                        orders[j + 1] = orderTemp;
                    }
                }
            }
        }

        public void Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("s.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }
        }

        public void Import()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("s.xml", FileMode.Open))
            {
                orders = (List<Order>)xmlSerializer.Deserialize(fs);

            }
        }
    }
}
