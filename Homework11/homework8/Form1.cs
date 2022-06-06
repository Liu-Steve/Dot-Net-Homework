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
    public partial class Form1 : Form
    {
        private OrderService orderService = new OrderService();
     
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCreatOrder_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder(); 
            if(createOrder.ShowDialog()==DialogResult.OK)
            {
                this.orderService.AddOneOrder(createOrder.order);
                RefreshDgv();
            }            
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            DeleteOrder deleteOrder = new DeleteOrder();
            if(deleteOrder.ShowDialog()==DialogResult.OK)
            {
                Order temp = deleteOrder.DeleteItem;
                orderService.DeleteOneOrder(temp.OrderId);
                RefreshDgv();
            }
        }

        private void btnModifyOrder_Click(object sender, EventArgs e)
        {
            UpdateOrder updateOrder = new UpdateOrder();
            if(updateOrder.ShowDialog()==DialogResult.OK)
            {
                Order tempDelete = updateOrder.UpdateItem;
                CreateOrder createOrder = new CreateOrder();
                if (createOrder.ShowDialog() == DialogResult.OK)
                {
                    orderService.UpdateOrder(tempDelete.OrderId, createOrder.order);
                    RefreshDgv();
                }
            }
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            SearchOrder searchOrder = new SearchOrder();
            searchOrder.ShowDialog();
        }

        private void btnExportOrder_Click(object sender, EventArgs e)
        {
            orderService.Export();
            Message message = new Message("导出成功");
            message.ShowDialog();
            if(message.DialogResult==DialogResult.OK)
            {
                RefreshDgv();
            }
        }

        private void btnImportOrder_Click(object sender, EventArgs e)
        {
            orderService.Import();
            Message message = new Message("导入成功");
            message.ShowDialog();
            if(message.DialogResult==DialogResult.OK)
            {
                RefreshDgv();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvOrder.DataSource = new OrderService().Orders;
        }

        private void RefreshDgv()
        {
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = new OrderService().Orders;
        }
    }
}
