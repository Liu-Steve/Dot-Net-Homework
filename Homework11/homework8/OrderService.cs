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
        
        public List<Order> Orders
        {
            get 
            {
                using (var context = new OrderContext())
                {
                    return context.Orders.Include("Goods")
                                 .OrderBy(o => o.OrderId).ToList();
                }
            } 
        }
        //添加订单
        public void AddOneOrder(Order order)
        {         
            using(var db = new OrderContext())
            {
                db.Orders.Add(order);
                db.SaveChanges();
            }
            //orders.Add(order);//原来的，此orderService对象添加一个order
        }
        //删除订单
        public void DeleteOneOrder(int IDDelete)
        {
            //数据库
            using(var context = new OrderContext())
            {
                var order = context.Orders.FirstOrDefault(p => p.OrderId == IDDelete);
                if(order!=null)
                {
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
            }
        }

        public void UpdateOrder(int IDUpdate, Order newOrder)
        {
            DeleteOneOrder(IDUpdate);
            newOrder.OrderId = IDUpdate;
            AddOneOrder(newOrder);
            Order.count--;
        }
        public List<Order> SearchById(int id)
        {
            using (var context = new OrderContext())
            {
                return context.Orders.Include("Goods")
                             .Where(b => b.OrderId == id)
                             .OrderBy(o => o.OrderId).ToList();
            }
        }
        public List<Order> SearchByGoodName(string goodname)
        {
            //数据库
            using(var context = new OrderContext())
            {
                var order = context.Orders.Include("Goods").Where(o => o.Goods.Any(d => d.GoodName == goodname));
                return order.ToList();
            }
        }
        public List<Order> SearchByTotalPrice(double price)
        {
            //数据库
            using(var context = new OrderContext())
            {
                var order = context.Orders.Include("Goods").Where(o => o.CostSum == price);
                return order.ToList();
            }
        }
        public List<Order> SearchBySenderName(string sender)
        {
            using(var context = new OrderContext())
            {
                var order = context.Orders.Include("Goods").Where(o => o.Sender == sender);
                return order.ToList();
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
            using(var context = new OrderContext())
            {
                orders = context.Orders.Include("Goods").ToList();
            }
        }
    }
}
