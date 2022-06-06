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
    public partial class SearchOrder : Form
    {
        public List<Order> SearchItem { get; set; } 
       
        public SearchOrder()
        {
            InitializeComponent();
        }

        private void SearchOrder_Load(object sender, EventArgs e)
        {
            List<Order> orders = new OrderContext().Orders.ToList();
            cmbSearchID.DataSource = orders;
            cmbSearchID.DisplayMember = "orderId";
            cmbSearchID.DataBindings.Add("SelectedItem", this, "SearchItem");      
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchItem = new OrderService().SearchById(((Order)cmbSearchID.SelectedItem).OrderId);
            dgvOrder.DataSource = null;
            dgvDetails.DataSource = null;
            dgvOrder.DataSource = SearchItem;
            dgvDetails.DataSource = SearchItem[0].Goods;
        }
    }
}
