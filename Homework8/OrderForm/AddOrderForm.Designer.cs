
namespace OrderForm
{
    partial class AddOrderForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.DiscountBox = new System.Windows.Forms.TextBox();
            this.ClientBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 303);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ClientLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DiscountLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.DiscountBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ClientBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 104);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(476, 94);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ClientLabel
            // 
            this.ClientLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(191, 16);
            this.ClientLabel.Margin = new System.Windows.Forms.Padding(10);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(37, 15);
            this.ClientLabel.TabIndex = 0;
            this.ClientLabel.Text = "客户";
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Location = new System.Drawing.Point(191, 63);
            this.DiscountLabel.Margin = new System.Windows.Forms.Padding(10);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(37, 15);
            this.DiscountLabel.TabIndex = 1;
            this.DiscountLabel.Text = "折扣";
            // 
            // DiscountBox
            // 
            this.DiscountBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DiscountBox.Location = new System.Drawing.Point(248, 58);
            this.DiscountBox.Margin = new System.Windows.Forms.Padding(10);
            this.DiscountBox.Name = "DiscountBox";
            this.DiscountBox.Size = new System.Drawing.Size(100, 25);
            this.DiscountBox.TabIndex = 3;
            // 
            // ClientBox
            // 
            this.ClientBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ClientBox.FormattingEnabled = true;
            this.ClientBox.Location = new System.Drawing.Point(248, 12);
            this.ClientBox.Margin = new System.Windows.Forms.Padding(10);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(121, 23);
            this.ClientBox.TabIndex = 4;
            this.ClientBox.SelectedIndexChanged += new System.EventHandler(this.ClientBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(147, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入订单信息";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.CancelBtn, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ConfirmBtn, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 204);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(476, 96);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(248, 10);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(10);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmBtn.Location = new System.Drawing.Point(153, 10);
            this.ConfirmBtn.Margin = new System.Windows.Forms.Padding(10);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 1;
            this.ConfirmBtn.Text = "确定";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddOrderForm";
            this.Text = "AddOrderForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.TextBox DiscountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.ComboBox ClientBox;
    }
}