﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework8
{
    public class Order
    {
        private static int count = 0;
        private double costSum = 0;
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public DateTime PayTime { get; }
        public string SenderAddress { get; set; }
        public string ReceiverAddress { get; set; }
        public int ID { get; set; }
        public List<OrderDetails> Goods = new List<OrderDetails>();
        public double CostSum
        {
            get
            {
                costSum = 0;
                foreach (OrderDetails orderDetails in Goods)
                {
                    costSum += orderDetails.CostSum;
                }
                return costSum;
            }
        }
        public Order()
        {
            count++;
            ID = count;
            PayTime = DateTime.Now;
        }
        public Order(string sender, string receiver, string senderAddress, string receiveAddress)
        {
            count++;
            Sender = sender;
            Receiver = receiver;
            SenderAddress = senderAddress;
            ReceiverAddress = receiveAddress;
            PayTime = DateTime.Now;            
            ID = count;
        }

        public void AddOneDetail(string name,double price,int num)
        {
            OrderDetails orderDetailsTemp;
            orderDetailsTemp = new OrderDetails(name, price, num);
            Goods.Add(orderDetailsTemp);
        }
        public void AddOneDetail(OrderDetails orderDetails)
        {            
            Goods.Add(orderDetails);
        }



        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("订单ID：" + ID);
            str.Append('\n');
            str.Append("下单时间：" + PayTime + '\n');
            str.Append("用户：" + Sender + "-------->" + Receiver + '\n');
            str.Append("地址：" + SenderAddress + "-------->" + ReceiverAddress + '\n');
            str.Append("订单明细：" + '\n');
            foreach (OrderDetails orderDetails in Goods)
            {
                str.Append(orderDetails.ToString());
            }
            str.Append("总价为：" + CostSum + '\n');
            str.Append('\n');
            return str.ToString();
        }

    }
}
