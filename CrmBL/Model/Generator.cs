﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class Generator
    {
        Random rnd = new Random();

        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Seller> Sellers { get; set; } = new List<Seller>();
        public List<Customer> CreateCustomer(int count)
        {
            List<Customer> result = new List<Customer>();
            for (int i = 0; i < count; i++)
            {
                var customer = new Customer()
                {
                    CustomerId = Customers.Count,
                    Name = GetRandomText(),

                };
                Customers.Add(customer);
                result.Add(customer);
            }
            return result;
            
        }
        public List<Seller> CreateSeller(int count)
        {
            List<Seller> result = new List<Seller>();
            for (int i = 0; i < count; i++)
            {
                var seller = new Seller()
                {
                    SellerId = Sellers.Count,
                    Name = GetRandomText(),

                };
                Sellers.Add(seller);
                result.Add(seller);
            }
            return result;

        }
        public List<Product> CreateProduct(int count)
        {
            List<Product> result = new List<Product>();
            for (int i = 0; i < count; i++)
            {
                var product = new Product()
                {
                    ProductId = Products.Count,
                    Name = GetRandomText(),
                    Count = rnd.Next(10,100),
                    Price = (decimal)(rnd.Next(5,10000)+ rnd.NextDouble())
                };
                Products.Add(product);
                result.Add(product);
            }
            return result;

        }
        public List<Product> CreateRandomProducts(int min, int max)
        {
            var result = new List<Product>();

            var count = rnd.Next(min, max);
            for (int i = 0; i < count; i++)
            {
                result.Add(Products[rnd.Next(Products.Count - 1)]);
            }
            return result;
        }
        public static string GetRandomText()
        {
            return Guid.NewGuid().ToString().Substring(0, 5);
        }
    }
}