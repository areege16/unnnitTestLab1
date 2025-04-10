using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUnitTesting.test
{
    public class ProductTests
    {
        //String Assertions
        [Fact]
        public void GetDescription_Description_True()
        {
            // Arrange
            Product product = new Product() { Name= "Laptop" };

            // Act
            string description = product.GetDescription();

            // Assert
            Assert.Equal("Laptop", description);
            Assert.Equal("laptop", description,ignoreCase:true);
            Assert.StartsWith("La", description);
            Assert.StartsWith("lap", description, StringComparison.OrdinalIgnoreCase);
            Assert.Contains("to", description);
            Assert.EndsWith("op", description);
        }

        //Numeric Assertions  / Equality Assertions
        [Fact]
        public void CalculateTotalCost_CheckValue_true()
        {
            // Arrange
            Product product = new Product()
            {
                Price = 100,
                Quantity = 5
            };
            //Act
            double totalCost = product.CalculateTotalCost();// 100*5 = 500
            //Numeric Assert

            Assert.Equal(500, totalCost);

            Assert.InRange(totalCost, 1, 1000);

            Assert.True(totalCost >= 500);
        }

        //Exception Assertions
        [Fact]
        public void ValidateQuantity_CheckValidate_ExeptionWhenNegative()
        {
            //arrange

            Product product = new Product
            {
                Quantity = -5
            };
            //assert & Act
            // Assert.Throws<T>(Action testCode) where T : System.Exception
            Assert.Throws<InvalidOperationException>(() => product.ValidateQuantity());
        }

        //Reference Assertions shallow copy
        [Fact]
        public void ShallowCopy_AskForCopy()
        {
            //arrange
            Product originalProduct =
                new Product { Name = "Phone", Price = 1000, Quantity = 1 };
            //Act
            Product shallowCopy = originalProduct.ShallowCopy();
            //assert
            Assert.NotNull(shallowCopy);
            Assert.Same(originalProduct, shallowCopy);
        }

        //Reference Assertions Reference copy
        [Fact]
        public void DeepCopy_AskForCopy()
        {
            //arrange
            Product originalProduct =
                new Product { Name = "Phone", Price = 1000, Quantity = 1 };
            //Act
            Product DeepCopy = originalProduct.DeepCopy();
            //assert
            Assert.NotNull(DeepCopy);
            Assert.NotSame(originalProduct, DeepCopy);
        }
        //collection
        [Fact]
        public void GetExpensiveProducts_ContainsLabtop_true()
        {
            List<Product> products = new List<Product>
            {
              new Product { Name = "Laptop", Price = 2000 },
              new Product { Name = "Mouse", Price = 150 },
              new Product { Name = "Monitor", Price = 800 },
              new Product { Name = "Pen", Price = 110 }
            };
            var result = Product.GetExpensiveProducts(products, 100);

            Assert.Contains(result, p => p.Name == "Laptop");
            Assert.DoesNotContain(result, p => p.Name == "mobile");
            Assert.All(result, p => Assert.True(p.Price > 100));
        }



    }
}
