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
            if (!Intent.dict.ContainsKey("orders"))
                return;
            cmbDeleteID.DataSource =(List<Order>) Intent.dict["orders"];
            cmbDeleteID.DisplayMember = "ID";
            cmbDeleteID.DataBindings.Add("SelectedItem", this, "DeleteItem");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Intent.dict["deleteItem"] = DeleteItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
