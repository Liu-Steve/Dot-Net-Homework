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
            if (!Intent.dict.ContainsKey("orders"))
                return;
            cmbUpdateID.DataSource = (List<Order>)Intent.dict["orders"];
            cmbUpdateID.DisplayMember = "ID";
            cmbUpdateID.DataBindings.Add("SelectedItem", this, "UpdateItem");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Intent.dict["updateItem"] = UpdateItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
