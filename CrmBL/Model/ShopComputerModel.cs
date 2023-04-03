using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Model
{
    public class ShopComputerModel
    {
        Random rnd = new Random();
        Generator generator = new Generator();
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
            var customers = generator.CreateCustomer(10);
            var carts = new Queue<Cart>();
            foreach (var customer in customers)
            {
                var cart = new Cart(customer);
                foreach (var product in generator.CreateRandomProducts(10,30))
                {
                    cart.Add(product);
                }
                carts.Enqueue(cart);
            }
            while (carts.Count>0)
            {
                
               var cash = CashDesks[rnd.Next(CashDesks.Count - 1)];
               cash.Enqueue(carts.Dequeue());
               
                
            }
            
            while (true)
            {
                var cash = CashDesks[rnd.Next(CashDesks.Count - 1)];
                var money = cash.Dequeue();
                
            }
            
        }
        
    }
}
