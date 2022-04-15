using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework8;

namespace OrderForm
{
    public partial class AddOrderForm : Form
    {
        public int ClientID { get; set; }
        public int Discount { get; set; }
        private bool fig = false;

        public AddOrderForm(List<Client> clients)
        {
            InitializeComponent();
            ClientBox.DataSource = new BindingList<Client>(clients);
            ClientBox.ValueMember = "ID";
            ClientBox.DisplayMember = "Name";
            fig = true;
        }

        private void ClientBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!fig)
                return;
            ClientID = (int)ClientBox.SelectedValue;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Discount = (int)(double.Parse(DiscountBox.Text) * 100);
            }
            catch (Exception)
            {
                DiscountLabel.Text = "折扣 请输入浮点数";
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
