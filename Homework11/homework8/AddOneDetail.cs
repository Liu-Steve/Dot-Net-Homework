using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework8
{
    public partial class AddOneDetail : Form
    {
        public OrderDetails orderDetails = new OrderDetails();
        public AddOneDetail()
        {
            InitializeComponent();
        }

        private void AddOneDetail_Load(object sender, EventArgs e)
        {
            txtName.DataBindings.Add("Text", this.orderDetails, "GoodName");
            txtNum.DataBindings.Add("Text", this.orderDetails, "NumOfGood");
            txtPrice.DataBindings.Add("Text", this.orderDetails, "CostPerGood");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
