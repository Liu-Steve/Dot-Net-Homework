﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm
{
    public partial class AddProductForm : Form
    {
        public String NameStr { get; set; }
        public int Price { get; set; }

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            NameStr = NameBox.Text;
            try
            {
                Price = (int)(double.Parse(PriceBox.Text) * 100);
            }
            catch (Exception)
            {
                NameLabel.Text = "价格 请输入浮点数";
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
