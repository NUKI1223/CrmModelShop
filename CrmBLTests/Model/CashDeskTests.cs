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
    public class CashDeskTests
    {
        [TestMethod()]
        public void CashDeskTest()
        {
            var customer1 = new Customer()
            {
                Name = "test1",
                CustomerId = 1
            };
            var customer2 = new Customer()
            {
                Name = "test2",
                CustomerId = 1
            };
            var seller = new Seller()
            {
                Name = "Seller",
                SellerId = 1
            };
            Product product1 = new Product() { Name = "pri1", Price = 100, Count = 10, ProductId = 1 };
            Product product2 = new Product() { Name = "pri2", Price = 120, Count = 20, ProductId = 2 };
            
            var cart1 = new Cart(customer1);
            cart1.Add(product1);
            cart1.Add(product1);
            cart1.Add(product2);
            var cart2 = new Cart(customer1);
            cart2.Add(product1);
            cart2.Add(product2);
            cart2.Add(product2);
            var cashdesk = new CashDesk(1, seller, null);
            cashdesk.MaxQueueLenght = 10;
            cashdesk.Enqueue(cart1);
            cashdesk.Enqueue(cart2);
            var cart1Result = 320;
            var cart2Result = 340;
            Assert.AreEqual(cart1Result, cashdesk.Dequeue());
            Assert.AreEqual(cart2Result, cashdesk.Dequeue());

        }

    }
}