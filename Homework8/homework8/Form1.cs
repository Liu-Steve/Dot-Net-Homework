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
                this.orderService.Orders.Add((Order)Intent.dict["order"]);
                Intent.dict["orders"] = orderService.Orders;
                RefreshDgv();
            }            
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            DeleteOrder deleteOrder = new DeleteOrder();
            if(deleteOrder.ShowDialog()==DialogResult.OK)
            {
                Order temp = (Order)Intent.dict["deleteItem"];
                orderService.DeleteOneOrder(temp.ID);
                RefreshDgv();
            }
        }

        private void btnModifyOrder_Click(object sender, EventArgs e)
        {
            UpdateOrder updateOrder = new UpdateOrder();
            if(updateOrder.ShowDialog()==DialogResult.OK)
            {
                Order temp = (Order)Intent.dict["updateItem"];
                orderService.DeleteOneOrder(temp.ID);
                CreateOrder createOrder = new CreateOrder();
                if (createOrder.ShowDialog() == DialogResult.OK)
                {
                    Order tempCreate = (Order)Intent.dict["order"];
                    tempCreate.ID = temp.ID;
                    this.orderService.Orders.Add(tempCreate);
                    //Intent.dict["orders"] = orderService.Orders;
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
            Intent.dict["orders"] = orderService.Orders;
            if(message.DialogResult==DialogResult.OK)
            {
                RefreshDgv();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvOrder.DataSource = orderService.Orders;
        }

        private void RefreshDgv()
        {
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = orderService.Orders;
        }
    }
}
