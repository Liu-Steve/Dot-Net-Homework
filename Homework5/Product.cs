using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Product
    {
        public int ID { get; private set; }

        public string Name { get; set; }

        /// <remarks>
        /// Price: 1 = ￥0.01
        /// </remarks>
        public int Price { get; set; }

        public Product(int id, string name, int price)
        {
            ID = id;
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            return obj is Product p && p.Name == Name &&
                p.ID == ID && p.Price == Price;
        }

        public override int GetHashCode()
        {
            return ID;
        }

        public override string ToString()
        {
            return $"Product: {Name}\t" + $"Product ID: {ID}\t" + 
                $"Price: ￥{Price / 100.0}";
        }

        public Product DeepCopy()
        {
            Product newProduct = new(ID, Name, Price);
            return newProduct;
        }
    }
}
