﻿using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUi
{
    class CashDeskView
    {
        CashDesk cashDesk;
        public Label Label { get; set; }
        public NumericUpDown NumericUpDown { get; set; }
        public CashDeskView(CashDesk cashDesk, int number, int x, int y)
        {
            this.cashDesk = cashDesk;
            Label = new Label();
            NumericUpDown = new NumericUpDown();

            Label.AutoSize = true;
            Label.Location = new System.Drawing.Point(x, y);
            Label.Name = "label" + number;
            Label.Size = new System.Drawing.Size(35, 13);
            Label.TabIndex = number;
            Label.Text = cashDesk.ToString();

            NumericUpDown.Location = new System.Drawing.Point(x+65, y);
            NumericUpDown.Name = "numericUpDown1"+number;
            NumericUpDown.Size = new System.Drawing.Size(120, 20);
            NumericUpDown.TabIndex = number;
            NumericUpDown.Maximum = 10000000000000000;
            cashDesk.CheckClosed += CashDesk_CheckClosed;
        }

        private void CashDesk_CheckClosed(object sender, Check e)
        {
            NumericUpDown.Invoke((Action)delegate { NumericUpDown.Value += e.Price; });
        }
    }
}