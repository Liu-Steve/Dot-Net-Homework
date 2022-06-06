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
        public Order SearchItem { get; set; }        
        public SearchOrder()
        {
            InitializeComponent();
        }

        private void SearchOrder_Load(object sender, EventArgs e)
        {
            if (!Intent.dict.ContainsKey("orders"))
                return;
            List<Order> orders = (List<Order>)Intent.dict["orders"];
            cmbSearchID.DataSource = orders;
            cmbSearchID.DisplayMember = "ID";
            cmbSearchID.DataBindings.Add("SelectedItem", this, "SearchItem");
            //dgvOrder.DataSource = 
            //dgvDetails.DataSource = orders
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Intent.dict["searchItem"] = SearchItem;
            List<Order> orders = new List<Order>();
            orders.Add(SearchItem);
            dgvOrder.DataSource = null;
            dgvDetails.DataSource = null;
            dgvOrder.DataSource = orders;
            dgvDetails.DataSource = SearchItem.Goods;
        }
    }
}
