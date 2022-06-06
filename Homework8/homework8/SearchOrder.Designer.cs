
namespace homework8
{
    partial class SearchOrder
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
            this.cmbSearchID = new System.Windows.Forms.ComboBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senderAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiverAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costPerGoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfGoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costSumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbSearchID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 98);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "要查询的订单ID：";
            // 
            // cmbSearchID
            // 
            this.cmbSearchID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbSearchID.DataSource = this.orderBindingSource;
            this.cmbSearchID.DisplayMember = "ID";
            this.cmbSearchID.FormattingEnabled = true;
            this.cmbSearchID.Location = new System.Drawing.Point(403, 12);
            this.cmbSearchID.Name = "cmbSearchID";
            this.cmbSearchID.Size = new System.Drawing.Size(121, 23);
            this.cmbSearchID.TabIndex = 1;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(homework8.Order);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Location = new System.Drawing.Point(722, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 44);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "确认";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AutoGenerateColumns = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.senderDataGridViewTextBoxColumn,
            this.receiverDataGridViewTextBoxColumn,
            this.payTimeDataGridViewTextBoxColumn,
            this.senderAddressDataGridViewTextBoxColumn,
            this.receiverAddressDataGridViewTextBoxColumn,
            this.costSumDataGridViewTextBoxColumn});
            this.dgvOrder.DataSource = this.orderBindingSource;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.Location = new System.Drawing.Point(3, 3);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 27;
            this.dgvOrder.Size = new System.Drawing.Size(394, 346);
            this.dgvOrder.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "订单ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senderDataGridViewTextBoxColumn
            // 
            this.senderDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.senderDataGridViewTextBoxColumn.DataPropertyName = "Sender";
            this.senderDataGridViewTextBoxColumn.HeaderText = "发件人";
            this.senderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.senderDataGridViewTextBoxColumn.Name = "senderDataGridViewTextBoxColumn";
            this.senderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiverDataGridViewTextBoxColumn
            // 
            this.receiverDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.receiverDataGridViewTextBoxColumn.DataPropertyName = "Receiver";
            this.receiverDataGridViewTextBoxColumn.HeaderText = "收件人";
            this.receiverDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receiverDataGridViewTextBoxColumn.Name = "receiverDataGridViewTextBoxColumn";
            this.receiverDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payTimeDataGridViewTextBoxColumn
            // 
            this.payTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.payTimeDataGridViewTextBoxColumn.DataPropertyName = "PayTime";
            this.payTimeDataGridViewTextBoxColumn.HeaderText = "下单时间";
            this.payTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payTimeDataGridViewTextBoxColumn.Name = "payTimeDataGridViewTextBoxColumn";
            this.payTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // senderAddressDataGridViewTextBoxColumn
            // 
            this.senderAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.senderAddressDataGridViewTextBoxColumn.DataPropertyName = "SenderAddress";
            this.senderAddressDataGridViewTextBoxColumn.HeaderText = "发货地址";
            this.senderAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.senderAddressDataGridViewTextBoxColumn.Name = "senderAddressDataGridViewTextBoxColumn";
            this.senderAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiverAddressDataGridViewTextBoxColumn
            // 
            this.receiverAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.receiverAddressDataGridViewTextBoxColumn.DataPropertyName = "ReceiverAddress";
            this.receiverAddressDataGridViewTextBoxColumn.HeaderText = "收货地址";
            this.receiverAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receiverAddressDataGridViewTextBoxColumn.Name = "receiverAddressDataGridViewTextBoxColumn";
            this.receiverAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costSumDataGridViewTextBoxColumn
            // 
            this.costSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costSumDataGridViewTextBoxColumn.DataPropertyName = "CostSum";
            this.costSumDataGridViewTextBoxColumn.HeaderText = "总计";
            this.costSumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costSumDataGridViewTextBoxColumn.Name = "costSumDataGridViewTextBoxColumn";
            this.costSumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgvOrder, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvDetails, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 98);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 352);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AutoGenerateColumns = false;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodNameDataGridViewTextBoxColumn,
            this.costPerGoodDataGridViewTextBoxColumn,
            this.numOfGoodDataGridViewTextBoxColumn,
            this.costSumDataGridViewTextBoxColumn1});
            this.dgvDetails.DataSource = this.orderDetailsBindingSource;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(403, 3);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.RowTemplate.Height = 27;
            this.dgvDetails.Size = new System.Drawing.Size(394, 346);
            this.dgvDetails.TabIndex = 3;
            // 
            // goodNameDataGridViewTextBoxColumn
            // 
            this.goodNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.goodNameDataGridViewTextBoxColumn.DataPropertyName = "GoodName";
            this.goodNameDataGridViewTextBoxColumn.HeaderText = "商品名称";
            this.goodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
            this.goodNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costPerGoodDataGridViewTextBoxColumn
            // 
            this.costPerGoodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costPerGoodDataGridViewTextBoxColumn.DataPropertyName = "CostPerGood";
            this.costPerGoodDataGridViewTextBoxColumn.HeaderText = "商品单价";
            this.costPerGoodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costPerGoodDataGridViewTextBoxColumn.Name = "costPerGoodDataGridViewTextBoxColumn";
            this.costPerGoodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numOfGoodDataGridViewTextBoxColumn
            // 
            this.numOfGoodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numOfGoodDataGridViewTextBoxColumn.DataPropertyName = "NumOfGood";
            this.numOfGoodDataGridViewTextBoxColumn.HeaderText = "商品数量";
            this.numOfGoodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numOfGoodDataGridViewTextBoxColumn.Name = "numOfGoodDataGridViewTextBoxColumn";
            this.numOfGoodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costSumDataGridViewTextBoxColumn1
            // 
            this.costSumDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.costSumDataGridViewTextBoxColumn1.DataPropertyName = "CostSum";
            this.costSumDataGridViewTextBoxColumn1.HeaderText = "小计";
            this.costSumDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.costSumDataGridViewTextBoxColumn1.Name = "costSumDataGridViewTextBoxColumn1";
            this.costSumDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataSource = typeof(homework8.OrderDetails);
            // 
            // SearchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SearchOrder";
            this.Text = "SearchOrder";
            this.Load += new System.EventHandler(this.SearchOrder_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearchID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiverAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costPerGoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfGoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costSumDataGridViewTextBoxColumn1;
    }
}