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
    public partial class UpdateOrder : Form
    {
        public Order UpdateItem { get; set; }
        public UpdateOrder()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            if (new OrderContext().Orders.ToList().Count<=0)
                return;
            cmbUpdateID.DataSource = new OrderContext().Orders.ToList();
            cmbUpdateID.DisplayMember = "orderId";
            cmbUpdateID.DataBindings.Add("SelectedItem", this, "UpdateItem");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
