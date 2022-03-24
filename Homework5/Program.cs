using System;

namespace Homework5
{
    class Program
    {
        static void Main()
        {
            OrderService service = new();
            Init(service, out int[] cl, out int[] pro, out int[] or);

            //test change order detial
            Console.WriteLine("\n*****test change order detial*****\n");
            //show order 0
            Console.WriteLine(service.Orders[0]);
            //add 1 apple into order 0
            Console.WriteLine("-----add 1 apple into order 0-----");
            try
            { 
                service.ChangeOrderDetial(or[0], pro[0], 1); 
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(service.Orders[0]);
            //remove 1 apple from order 0
            Console.WriteLine("-----remove 1 apple from order 0-----");
            try
            {
                service.ChangeOrderDetial(or[0], pro[0], -1);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(service.Orders[0]);
            //remove 1 banana from order 0
            Console.WriteLine("-----remove 1 banana from order 0-----");
            try
            {
                service.ChangeOrderDetial(or[0], pro[1], -1);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(service.Orders[0]);
            //remove 10 candy from order 0
            Console.WriteLine("-----remove 10 candy from order 0-----");
            try
            {
                service.ChangeOrderDetial(or[0], pro[2], -10);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(service.Orders[0]);

            //test change client and discount
            Console.WriteLine("\n*****test change client and discount*****\n");
            //show order 1
            Console.WriteLine(service.Orders[1]);
            //change client
            Console.WriteLine("-----change order 1 client 1 to 2-----");
            try
            {
                service.ChangeClient(or[1], cl[2]);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(service.Orders[1]);
            //change discount
            Console.WriteLine("-----change order 1 discount to ￥1.23-----"); 
            try
            {
                service.ChangeDiscount(or[1], 123);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(service.Orders[1]);

            //test select
            Console.WriteLine("\n*****test select orders*****\n");
            Console.WriteLine("-----select from Order ID : 3-----");
            var orders1 = service.Select(o => {
                return o.ID == or[3];
            });
            orders1.ForEach(o => Console.WriteLine(o));
            Console.WriteLine("-----select from Product Name : Apple-----");
            var orders2 = service.Select(o => {
                return o.Exists("Apple");
            });
            orders2.ForEach(o => Console.WriteLine(o));
            Console.WriteLine("-----select from Client Name : Bob-----");
            var orders3 = service.Select(o => { 
                return o.Client.Name == "Bob"; 
            });
            orders3.ForEach(o => Console.WriteLine(o));
            Console.WriteLine("-----select from Sum Price : > ￥250-----");
            var orders4 = service.Select(o => {
                return o.SumPrice > 25000;
            });
            orders4.ForEach(o => Console.WriteLine(o));

            //test sort
            Console.WriteLine("\n*****test sort orders*****\n");
            //default sort
            Console.WriteLine("-----sort according to order ID-----");
            service.Sort();
            service.Orders.ForEach(o => Console.WriteLine(o));
            //sort according to customer ID
            Console.WriteLine("-----sort according to customer ID-----");
            service.Sort((o1, o2) => { return o1.Client.ID - o2.Client.ID; });
            service.Orders.ForEach(o => Console.WriteLine(o));
            //sort according to sum price
            Console.WriteLine("-----sort according to sum price-----");
            service.Sort((o1, o2) => { return o1.SumPrice - o2.SumPrice; });
            service.Orders.ForEach(o => Console.WriteLine(o));

            //test delete
            Console.WriteLine("\n*****test delete orders*****\n");
            //delete according to sum price
            Console.WriteLine("-----delete according to sum price-----");
            int row = service.Delete(o => { return o.SumPrice > 10000; });
            Console.WriteLine($"\n{row} rows have been deleted\n");
            service.Orders.ForEach(o => Console.WriteLine(o));
            //delete according to order ID
            Console.WriteLine("-----delete according to order ID : 2-----");
            try
            {
                service.Delete(or[2]);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            service.Orders.ForEach(o => Console.WriteLine(o));
        }

        private static void Init(OrderService service, out int[] c, 
            out int[] p, out int[] o)
        {
            c = new int[5];
            p = new int[5];
            o = new int[10];
            c[0] = service.AddClient("Alice");
            c[1] = service.AddClient("Bob");
            c[2] = service.AddClient("Cindy");
            c[3] = service.AddClient("Dave");
            c[4] = service.AddClient("Einstein");
            p[0] = service.AddProduct("Apple", 101);
            p[1] = service.AddProduct("banana", 202);
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
    }
}
