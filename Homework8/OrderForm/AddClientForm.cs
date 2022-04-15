using System;
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
    public partial class AddClientForm : Form
    {
        public string NameStr { get; set; }

        public AddClientForm()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            NameStr = NameBox.Text;
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
