using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmBL.Model;
namespace CrmUi
{
    public partial class Main : Form
    {
        CrmContex db;
        Cart cart;
        Customer customer;
        decimal priceResult = 0;
        public Main()
        {
            InitializeComponent();
            db = new CrmContex();

            cart = new Cart(customer);
        }





        private void Main_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                listBox1.Invoke((Action)delegate
                {
                    UpdateLists();
                });
            });
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(db.Products, db);
            catalogProduct.Show();
        }

        private void sellerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var catalogSellers = new Catalog<Seller>(db.Sellers, db);
            catalogSellers.Show();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var catalogCustomers = new Catalog<Customer>(db.Customers, db);
            catalogCustomers.Show();
        }

        private void checkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var catalogCheck = new Catalog<Check>(db.Checks, db);
            catalogCheck.Show();
        }

        private void customerAddToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Customers.Add(form.Customer);
                db.SaveChanges();
            }
        }

        private void sellerAddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new SellerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Sellers.Add(form.Seller);
                db.SaveChanges();
            }
        }

        private void productAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Products.Add(form.Product);
                db.SaveChanges();
            }
        }

        private void modelingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ModelForm();
            form.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem is Product product)
            {
                cart.Add(product);
                listBox2.Items.Add(product);
                priceResult += product.Price;
                label2.Text = $"Общая стоимость: {priceResult}";
            }

        
    
            
            
        }
        private void UpdateLists()
        {
            var items = db.Products.ToArray();
            listBox1.Items.AddRange(items);
            listBox2.Items.AddRange(cart.GetAll().ToArray());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new Autorization();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                var temp = db.Customers.FirstOrDefault(c => c.Name.Equals(form.Customer.Name));
                if (temp !=null)
                {
                    customer = temp;
                }
                else
                {
                    db.Customers.Add(form.Customer);
                    db.SaveChanges();
                    customer = form.Customer;
                }
                linkLabel1.Text = $"Здравствуйте, {customer.Name}!";
            }
        }
    }
}
