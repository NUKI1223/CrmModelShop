using System;
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
        public List<CashDesk> CashDesks { get; set; } = new List<CashDesk>();
        public List<Cart> Carts { get; set; } = new List<Cart>();
        public List<Check> Checks { get; set; } = new List<Check>();
        public List<Sell> Sells { get; set; } = new List<Sell>();
        public List<Product> Products { get; set; } = new List<Product>();
        public Queue<Seller> Sellers { get; set; } = new Queue<Seller>();

        public ShopComputerModel()
        {
            var sellers = generator.CreateSeller(20);
            generator.CreateProduct(1000);
            generator.CreateCustomer(100);
            foreach (var seller in sellers)
            {

                Sellers.Enqueue(seller);
            }
            for (int i = 0; i < 3; i++)
            {
                CashDesks.Add(new CashDesk(CashDesks.Count, Sellers.Dequeue()));
            }
        }
        
        public void Start()
        {
            isWorking = true;
            Task.Run(()=>CreateCarts(10, 1000));
            var cashDeskTasks = CashDesks.Select(x => new Task(() => CashDeskWork(x, 1000)));
            foreach (var tasks in cashDeskTasks)
            {
                tasks.Start();
            }

        }
        public void Stop()
        {
            isWorking = false;
        }
        private void CashDeskWork(CashDesk cashDesk, int sleep)
        {
            while (isWorking)
            {


                if (cashDesk.Count > 0)
                {
                    cashDesk.Dequeue();
                    Thread.Sleep(sleep);
                }
            }
        }
        private void CreateCarts(int customerCounts, int sleep)
        {
            while (isWorking)
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
                Thread.Sleep(sleep);
            }
        }
    }
}
