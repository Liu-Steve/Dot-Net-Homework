
namespace homework8
{
    partial class CreateOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.txtSenderAddress = new System.Windows.Forms.TextBox();
            this.txtReceiverAddress = new System.Windows.Forms.TextBox();
            this.btnAddOneDetail = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPerGoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfGoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDataSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSender, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtReceiver, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSenderAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtReceiverAddress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAddOneDetail, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 151);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "发件人：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "收件人：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "发件地址：";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "收件地址：";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "订单明细：";
            // 
            // txtSender
            // 
            this.txtSender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSender.Location = new System.Drawing.Point(123, 3);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(100, 25);
            this.txtSender.TabIndex = 5;
            // 
            // txtReceiver
            // 
            this.txtReceiver.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtReceiver.Location = new System.Drawing.Point(123, 33);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(100, 25);
            this.txtReceiver.TabIndex = 6;
            // 
            // txtSenderAddress
            // 
            this.txtSenderAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSenderAddress.Location = new System.Drawing.Point(123, 63);
            this.txtSenderAddress.Name = "txtSenderAddress";
            this.txtSenderAddress.Size = new System.Drawing.Size(100, 25);
            this.txtSenderAddress.TabIndex = 7;
            // 
            // txtReceiverAddress
            // 
            this.txtReceiverAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtReceiverAddress.Location = new System.Drawing.Point(123, 93);
            this.txtReceiverAddress.Name = "txtReceiverAddress";
            this.txtReceiverAddress.Size = new System.Drawing.Size(100, 25);
            this.txtReceiverAddress.TabIndex = 8;
            // 
            // btnAddOneDetail
            // 
            this.btnAddOneDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddOneDetail.Location = new System.Drawing.Point(123, 123);
            this.btnAddOneDetail.Name = "btnAddOneDetail";
            this.btnAddOneDetail.Size = new System.Drawing.Size(121, 25);
            this.btnAddOneDetail.TabIndex = 9;
            this.btnAddOneDetail.Text = "添加一条明细";
            this.btnAddOneDetail.UseVisualStyleBackColor = true;
            this.btnAddOneDetail.Click += new System.EventHandler(this.btnAddOneDetail_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(719, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AllowDrop = true;
            this.orderDataGridView.AllowUserToAddRows = false;
            this.orderDataGridView.AllowUserToDeleteRows = false;
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodNameDataGridViewTextBoxColumn,
            this.costPerGoodDataGridViewTextBoxColumn,
            this.numOfGoodDataGridViewTextBoxColumn,
            this.costSumDataGridViewTextBoxColumn});
            this.orderDataGridView.DataSource = this.orderDetailDataSource;
            this.orderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderDataGridView.Location = new System.Drawing.Point(0, 151);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowHeadersWidth = 51;
            this.orderDataGridView.RowTemplate.Height = 27;
            this.orderDataGridView.Size = new System.Drawing.Size(800, 299);
            this.orderDataGridView.TabIndex = 3;
            // 
            // goodNameDataGridViewTextBoxColumn
            // 
            this.goodNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.goodNameDataGridViewTextBoxColumn.DataPropertyName = "GoodName";
            this.goodNameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.goodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
            // 
            // costPerGoodDataGridViewTextBoxColumn
            // 
            this.costPerGoodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costPerGoodDataGridViewTextBoxColumn.DataPropertyName = "CostPerGood";
            this.costPerGoodDataGridViewTextBoxColumn.HeaderText = "商品单价";
            this.costPerGoodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costPerGoodDataGridViewTextBoxColumn.Name = "costPerGoodDataGridViewTextBoxColumn";
            // 
            // numOfGoodDataGridViewTextBoxColumn
            // 
            this.numOfGoodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numOfGoodDataGridViewTextBoxColumn.DataPropertyName = "NumOfGood";
            this.numOfGoodDataGridViewTextBoxColumn.HeaderText = "商品数量";
            this.numOfGoodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numOfGoodDataGridViewTextBoxColumn.Name = "numOfGoodDataGridViewTextBoxColumn";
            // 
            // costSumDataGridViewTextBoxColumn
            // 
            this.costSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costSumDataGridViewTextBoxColumn.DataPropertyName = "CostSum";
            this.costSumDataGridViewTextBoxColumn.HeaderText = "总价";
            this.costSumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costSumDataGridViewTextBoxColumn.Name = "costSumDataGridViewTextBoxColumn";
            this.costSumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDetailDataSource
            // 
            this.orderDetailDataSource.DataSource = typeof(homework8.OrderDetails);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 380);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 70);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CreateOrder";
            this.Text = "CreateOrder";
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDataSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.TextBox txtSenderAddress;
        private System.Windows.Forms.TextBox txtReceiverAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.BindingSource orderDetailDataSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAddOneDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPerGoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfGoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costSumDataGridViewTextBoxColumn;
    }
}