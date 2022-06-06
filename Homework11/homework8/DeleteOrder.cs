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
    public partial class DeleteOrder : Form
    {
        public Order DeleteItem { get; set; }
        public DeleteOrder()
        {
            InitializeComponent();
        }

        private void DeleteOrder_Load(object sender, EventArgs e)
        {
            
            if (new OrderContext().Orders.ToList().Count <= 0)
                return;
            cmbDeleteID.DataSource = new OrderContext().Orders.ToList();
            cmbDeleteID.DisplayMember = "orderId";
            cmbDeleteID.DataBindings.Add("SelectedItem", this, "DeleteItem");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
