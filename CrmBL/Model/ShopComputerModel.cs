﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class ShopComputerModel
    {
        Random rnd = new Random();
        Generator generator = new Generator();
        bool isWorking = false;
        CancellationTokenSource cancellationTokenSource;
        CancellationToken token ;
        List<Task> tasks = new List<Task>();
        public List<CashDesk> CashDesks { get; set; } = new List<CashDesk>();
        public List<Cart> Carts { get; set; } = new List<Cart>();
        public List<Check> Checks { get; set; } = new List<Check>();
        public List<Sell> Sells { get; set; } = new List<Sell>();
        public List<Product> Products { get; set; } = new List<Product>();
        public Queue<Seller> Sellers { get; set; } = new Queue<Seller>();
        public int CustomerSpeed { get; set; } = 100;
        public int CashDeskSpeed { get; set; } = 100;
        public ShopComputerModel()
        {
            var sellers = generator.CreateSeller(20);
            generator.CreateProduct(1000);
            generator.CreateCustomer(100);
            foreach (var seller in sellers)
            {

                Sellers.Enqueue(seller);
            }
            cancellationTokenSource = new CancellationTokenSource();
            token = cancellationTokenSource.Token;
            for (int i = 0; i < 3; i++)
            {
                CashDesks.Add(new CashDesk(CashDesks.Count, Sellers.Dequeue(), null));
            }
        }
        
        public void Start()
        {
            isWorking = true;
            
            tasks.Add(new Task(() => CreateCarts(10, token)));
            tasks.AddRange(CashDesks.Select(x => new Task(() => CashDeskWork(x, token))));
            foreach (var tasks in tasks)
            {
                tasks.Start();
            }
            
        }
        public void Stop()
        {
            
            cancellationTokenSource.Cancel();
        }
        private void CashDeskWork(CashDesk cashDesk, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {


                if (cashDesk.Count > 0)
                {
                    cashDesk.Dequeue();
                    Thread.Sleep(CashDeskSpeed);
                }
            }
        }
        private void CreateCarts(int customerCounts, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {


                List<Customer> customers = generator.CreateCustomer(customerCounts);
               
                foreach (var customer in customers)
                {
                    var cart = new Cart(customer);
                    foreach (var product in generator.CreateRandomProducts(10,30))
                    {
                        cart.Add(product);
                    }
                    var cash = CashDesks[rnd.Next(CashDesks.Count)];
                    cash.Enqueue(cart);

                }
                Thread.Sleep(CustomerSpeed);
            }
        }
    }
}
