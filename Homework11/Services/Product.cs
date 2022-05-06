using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    [Serializable]
    public class Product
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        /// <remarks>
        /// Price: 1 = ￥0.01
        /// </remarks>
        public int Price { get; set; }

        public Product() { }

        public Product(int id, string name, int price)
        {
            ProductID = id;
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            return obj is Product p && p.Name == Name &&
                p.ProductID == ProductID && p.Price == Price;
        }

        public override int GetHashCode()
        {
            return ProductID;
        }

        public override string ToString()
        {
            return $"Product: {Name}\t" + $"Product ID: {ProductID}\t" + 
                $"Price: ￥{Price / 100.0}";
        }
    }
}
