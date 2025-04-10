using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectUnitTesting.test
{
    public class SpecialProductTests
    {
        //Bool Assertions
        [Fact]
        public void IsOnSale_Price50_False()
        {
            //Arrange
            SpecialProduct specialProduct = new SpecialProduct { Price = 20 };
            //Act 
            bool IfSale = specialProduct.IsValidPrice();
            //boolean Assert 
            Assert.False(IfSale);
        }
        //Reference Assertion
        [Fact]
        public void GetDescription_CheckNull_NotNull()
        {
            //Arrange
            SpecialProduct specialProduct = new SpecialProduct()
            {
                Category = "Mobile",
                Name = "Oppo",
                Price = 3000
            };
            //Act 
            string description = specialProduct.GetDescription();

            //Assert 
            Assert.NotNull(description);
        }
        //Reference Assertion 
        [Fact]
        public void GetDescription_CheckSameReference()
        {
            //Arrange
            SpecialProduct specialProduct = new SpecialProduct()
            {
                Category = "Laptop",
                Name = "Dell",
                Price = 200000
            };
            //Act
            SpecialProduct reference = specialProduct;
            //Assert
            Assert.Same(specialProduct, reference);
        }
       

    }
}
