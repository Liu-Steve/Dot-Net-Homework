using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    [Serializable]
    public class OrderDetials : IComparable
    {
        [Key]
        public int DetialID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int Number { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int SumPrice
        {
            get => Product.Price * Number;
        }

        public OrderDetials() { }

        public OrderDetials(int id, Product product, int number, Order order)
        {
            DetialID = id;
            ProductID = product.ProductID;
            Product = product;
            Number = number;
            OrderID = order.OrderID;
            Order = order;
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
            return Product.ProductID - o.Product.ProductID;
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetials o && Product.Equals(o.Product) && 
                Number == o.Number;
        }

        public override int GetHashCode()
        {
            return Product.ProductID;
        }

        public override string ToString()
        {
            return $"{Product}\tNumber: {Number}";
        }
    }
}
