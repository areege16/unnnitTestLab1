using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUnitTesting
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; } 


        public Product()
        {
            Name = string.Empty;
            Price = 0;
            Quantity = 0;
        }

        public virtual string GetDescription()
        {
            return $"{Name}"; 
        }
        public double CalculateTotalCost()
        {
            return Price * Quantity;
        }

        public void ValidateQuantity()
        {
            if (Quantity < 0)
            {
                throw new InvalidOperationException("Quantity cannot be negative.");
            }
        }
        public Product ShallowCopy()
        {
            return this;
        }
        public Product DeepCopy()
        {
            return new Product
            {
                Name = this.Name,
                Price = this.Price,
                Quantity = this.Quantity
            };
        }
        public static List<Product> GetExpensiveProducts(List<Product> products, double minPrice)
        {
            return products.Where(p => p.Price > minPrice).ToList();
        }

    }
}
