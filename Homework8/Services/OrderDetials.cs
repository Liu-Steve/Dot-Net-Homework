using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    [Serializable]
    public class OrderDetials : IComparable
    {
        public Product Product { get; set; }
        public int Number { get; set; }
        public int SumPrice
        {
            get => Product.Price * Number;
        }

        public OrderDetials() { }

        public OrderDetials(Product product, int number)
        {
            Product = product;
            Number = number;
        }

        /// <remarks>
        /// Product ID smaller one first
        /// <br/>
        /// if ID equal, then the Number smaller one first
        /// </remarks>
        public int CompareTo(object obj)
        {
            if (!(obj is OrderDetials o))
                return 1;
            if (Product.Equals(o.Product))
                return Number - o.Number;
            return Product.ID - o.Product.ID;
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetials o && Product.Equals(o.Product) && 
                Number == o.Number;
        }

        public override int GetHashCode()
        {
            return Product.ID;
        }

        public override string ToString()
        {
            return $"{Product}\tNumber: {Number}";
        }

        public OrderDetials DeepCopy()
        {
            OrderDetials newDetial = new OrderDetials(Product.DeepCopy(), Number);
            return newDetial;
        }
    }
}
