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
    public partial class CreateOrder : Form
    {
        public Order order = new Order();
        
        public CreateOrder()
        {
            InitializeComponent();
            orderDetailDataSource.DataSource = order.Goods;
        }
        private void CreateOrder_Load(object sender, EventArgs e)
        {
            txtSender.DataBindings.Add("Text", this.order, "Sender");
            txtReceiver.DataBindings.Add("Text", this.order, "Receiver");
            txtSenderAddress.DataBindings.Add("Text", this.order, "SenderAddress");
            txtReceiverAddress.DataBindings.Add("Text", this.order, "ReceiverAddress");
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSender == null || txtReceiver == null || txtSenderAddress == null || txtReceiverAddress == null)
                return;  
            this.DialogResult = DialogResult.OK;

        }
        private void btnAddOneDetail_Click(object sender, EventArgs e)
        {
            AddOneDetail addOneDetail = new AddOneDetail();
            if(addOneDetail.ShowDialog()==DialogResult.OK)
            {
                order.AddOneDetail(addOneDetail.orderDetails);
                orderDetailDataSource.DataSource = null;
                orderDetailDataSource.DataSource = order.Goods;
            }            
        }

    }
}
