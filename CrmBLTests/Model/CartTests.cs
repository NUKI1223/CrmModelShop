using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void CartTest()
        {
            // AAA
            //Arrange
            Customer customer = new Customer() { Name = "test", CustomerId=1 };
            Product product1 = new Product() { Name = "pri1", Price = 100, Count = 10 , ProductId=1};
            Product product2 = new Product() { Name = "pri2", Price = 120, Count = 12, ProductId = 2 };
            var cart = new Cart(customer);
            var expectedResult = new List<Product>
            {
                product1,product1,product2
            };
            //Act
            cart.Add(product1);
            cart.Add(product1);
            cart.Add(product2);
            var cartResult = cart.GetAll();
            //Assert
            Assert.AreEqual(expectedResult.Count, cartResult.Count);
            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], cartResult[i]);
            }

        }

        
    }
}