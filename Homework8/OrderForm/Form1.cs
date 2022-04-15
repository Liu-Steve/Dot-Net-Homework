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
    public partial class Form1 : Form
    {
        private readonly OrderService service;

        public Form1()
        {
            InitializeComponent();
            service = new OrderService();
        }

        private void 添加客户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddClientForm form = new AddClientForm())
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    string clientName = form.NameStr;
                    service.AddClient(clientName);
                    clientsBindingSource.DataSource = new BindingList<Client>(service.Clients);
                }
            }
        }

        private void 添加货物ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddProductForm form = new AddProductForm())
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    string productName = form.NameStr;
                    int productPrice = form.Price;
                    service.AddProduct(productName, productPrice);
                    productsBindingSource.DataSource = new BindingList<Product>(service.Products);
                }
            }
        }

        private void 添加订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddOrderForm form = new AddOrderForm (service.Clients))
            {
                if(form.ShowDialog() == DialogResult.OK)
                {
                    int clientID = form.ClientID;
                    int discount = form.Discount;
                    service.AddOrder(clientID, discount);
                    ordersBindingSource.DataSource = new BindingList<Order>(service.Orders);
                }
            }
        }
    }
}
