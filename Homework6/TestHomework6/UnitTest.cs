using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework6;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace TestHomework6
{
    [TestClass]
    public class UnitTestOrderService
    {
        private static void Init(out OrderService service, out int[] c,
            out int[] p, out int[] o)
        {
            service = new();
            c = new int[5];
            p = new int[5];
            o = new int[10];
            c[0] = service.AddClient("Alice");
            c[1] = service.AddClient("Bob");
            c[2] = service.AddClient("Cindy");
            c[3] = service.AddClient("Dave");
            c[4] = service.AddClient("Einstein");
            p[0] = service.AddProduct("Apple", 101);
            p[1] = service.AddProduct("Banana", 202);
            p[2] = service.AddProduct("Candy", 303);
            p[3] = service.AddProduct("Doll", 404);
            p[4] = service.AddProduct("Egg", 505);
            o[0] = service.AddOrder(c[0]);
            o[1] = service.AddOrder(c[1]);
            o[2] = service.AddOrder(c[2]);
            o[3] = service.AddOrder(c[3]);
            o[4] = service.AddOrder(c[4]);
            //one client can have multiple order
            o[5] = service.AddOrder(c[0]);
            //order could initialized with discount
            o[6] = service.AddOrder(c[0], 123);
            o[7] = service.AddOrder(c[1]);
            o[8] = service.AddOrder(c[1]);
            o[9] = service.AddOrder(c[1]);
            //to add detials into order, using ChangeOrderDetial()
            for (int i = 0; i < 10; ++i)
            {
                for (int j = i % 5; j < 5; ++j)
                {
                    service.ChangeOrderDetial(o[i], p[j], i * j + 1);
                }
            }
        }

        [TestMethod]
        public void TestAddClient()
        {
            OrderService service = new();
            int actual = service.AddClient("Alice");
            int expect = service.Clients[0].ID;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestAddProduct()
        {
            OrderService service = new();
            int actual = service.AddProduct("Apple", 101);
            int expect = service.Products[0].ID;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestAddOrder()
        {
            OrderService service = new();
            int c = service.AddClient("Alice");
            int actual1 = service.AddOrder(c);
            int expect1 = service.Orders[0].ID;
            int actual2 = service.AddOrder(c, 123);
            int expect2 = service.Orders[1].ID;
            Assert.AreEqual(expect1, actual1);
            Assert.AreEqual(expect2, actual2);
        }

        [TestMethod]
        public void TestChangeOrderDetial1()
        {
            Init(out OrderService service, 
                out int[] cl, out int[] pro, out int[] or);
            service.ChangeOrderDetial(or[0], pro[0], 1);
            int actual = service.Orders[0].Detials[0].Number;
            int expect = 2;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestChangeOrderDetial2()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            service.ChangeOrderDetial(or[0], pro[0], -1);
            bool actual = service.Orders[0].Exists(pro[0]);
            bool expect = false;
            Assert.AreEqual(expect, actual);
        }

        /// <summary>
        /// order isn't exist
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestChangeOrderDetial3()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            service.ChangeOrderDetial(-1, pro[0], 1);
        }

        /// <summary>
        /// product isn't exist
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestChangeOrderDetial4()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            service.ChangeOrderDetial(or[0], -1, 1);
        }

        /// <summary>
        /// product's number turn to negative
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestChangeOrderDetial5()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            service.ChangeOrderDetial(or[0], pro[0], -100);
        }

        [TestMethod]
        public void TestChangeClient1()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            service.ChangeClient(or[1], cl[2]);
            int actual = service.Orders[1].Client.ID;
            int expect = cl[2];
            Assert.AreEqual(expect, actual);
        }

        /// <summary>
        /// order isn't exist
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestChangeClient2()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            service.ChangeClient(-1, cl[2]);
        }

        /// <summary>
        /// client isn't exist
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestChangeClient3()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            service.ChangeClient(or[1], -1);
        }

        [TestMethod]
        public void TestChangeDiscount1()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            service.ChangeDiscount(or[1], 123);
            int actual = service.Orders[1].Discount;
            int expect = 123;
            Assert.AreEqual(expect, actual);
        }

        /// <summary>
        /// order isn't exist
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestChangeDiscount2()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            service.ChangeDiscount(-1, 123);
        }

        /// <summary>
        /// select from Order ID
        /// </summary>
        [TestMethod]
        public void TestSelect1()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            var orders1 = service.Select(o =>
            {
                return o.ID == or[3];
            });
            List<int> actual = orders1.Select(o => o.ID).ToList();
            List<int> expect = new() { 3 };
            CollectionAssert.AreEqual(expect, actual);
        }

        /// <summary>
        /// select from Product Name
        /// </summary>
        [TestMethod]
        public void TestSelect2()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            var orders2 = service.Select(o =>
            {
                return o.Exists("Apple");
            });
            List<int> actual = orders2.Select(o => o.ID).ToList();
            List<int> expect = new() { 0, 5 };
            actual.Sort();
            expect.Sort();
            CollectionAssert.AreEqual(expect, actual);
        }

        /// <summary>
        /// select from Client Name
        /// </summary>
        [TestMethod]
        public void TestSelect3()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            var orders3 = service.Select(o =>
            {
                return o.Client.Name == "Bob";
            });
            List<int> actual = orders3.Select(o => o.ID).ToList();
            List<int> expect = new() { 1, 7, 8, 9 };
            actual.Sort();
            expect.Sort();
            CollectionAssert.AreEqual(expect, actual);
        }

        /// <summary>
        /// select from Sum Price
        /// </summary>
        [TestMethod]
        public void TestSelect4()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            var orders4 = service.Select(o =>
            {
                return o.SumPrice > 25000;
            });
            List<int> actual = orders4.Select(o => o.ID).ToList();
            List<int> expect = new() { 6, 7, 8 };
            actual.Sort();
            expect.Sort();
            CollectionAssert.AreEqual(expect, actual);
        }

        /// <summary>
        /// sort according to order ID
        /// </summary>
        [TestMethod]
        public void TestSort1()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            service.Sort();
            List<int> actual = service.Orders.Select(o => o.ID).ToList();
            List<int> expect = new() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            CollectionAssert.AreEqual(expect, actual);
        }

        /// <summary>
        /// sort according to customer ID
        /// </summary>
        [TestMethod]
        public void TestSort2()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            service.Sort((o1, o2) => { return o1.Client.ID - o2.Client.ID; });
            List<int> actual = service.Orders.Select(o => o.ID).ToList();
            List<int> expect = new() { 0, 5, 6, 1, 7, 8, 9, 2, 3, 4 };
            CollectionAssert.AreEqual(expect, actual);
        }

        /// <summary>
        /// sort according to sum price
        /// </summary>
        [TestMethod]
        public void TestSort3()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            service.Sort((o1, o2) => { return o1.SumPrice - o2.SumPrice; });
            List<int> actual = service.Orders.Select(o => o.ID).ToList();
            List<int> expect = new() { 0, 1, 4, 2, 3, 9, 5, 6, 8, 7 };
            CollectionAssert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestDelete1()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            int actual = service.Delete(o => { return o.SumPrice > 10000; });
            int expect = 6;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestDelete2()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            service.Delete(or[2]);
            bool actual = service.Orders.Exists(o => o.ID == or[2]);
            bool expect = false;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestExport()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            service.Export("orders");
            bool actual = File.Exists("../../../xml/orders.xml");
            bool expect = true;
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void TestImport()
        {
            Init(out OrderService service,
                out int[] cl, out int[] pro, out int[] or);
            service.Export("orders");
            service.Delete(o => true);  //delete all orders
            service.Import("orders");
            List<int> actual = service.Orders.Select(o => o.ID).ToList();
            List<int> expect = new() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            actual.Sort();
            expect.Sort();
            CollectionAssert.AreEqual(expect, actual);
        }
    }
}
