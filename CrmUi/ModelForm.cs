using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class ModelForm : Form
    {
        ShopComputerModel model = new ShopComputerModel();
        public ModelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cashDesks = new List<CashDeskView>();
            for (int i = 0; i < model.CashDesks.Count; i++)
            {
                var desk = new CashDeskView(model.CashDesks[i], i, 10, 26 * i);
                cashDesks.Add(desk);
                Controls.Add(desk.Label);
                Controls.Add(desk.NumericUpDown);
            }
            model.Start();
        }
    }
}
