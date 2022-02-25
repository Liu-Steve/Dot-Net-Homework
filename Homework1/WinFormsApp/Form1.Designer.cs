
namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCal = new System.Windows.Forms.Button();
            this.comboBoxOp = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelEq = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCal
            // 
            this.buttonCal.Location = new System.Drawing.Point(407, 253);
            this.buttonCal.Name = "buttonCal";
            this.buttonCal.Size = new System.Drawing.Size(94, 29);
            this.buttonCal.TabIndex = 0;
            this.buttonCal.Text = "Calculate";
            this.buttonCal.UseVisualStyleBackColor = true;
            this.buttonCal.Click += new System.EventHandler(this.buttonCal_Click);
            // 
            // comboBoxOp
            // 
            this.comboBoxOp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOp.FormattingEnabled = true;
            this.comboBoxOp.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxOp.Location = new System.Drawing.Point(238, 153);
            this.comboBoxOp.Name = "comboBoxOp";
            this.comboBoxOp.Size = new System.Drawing.Size(50, 28);
            this.comboBoxOp.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(294, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 3;
            // 
            // labelEq
            // 
            this.labelEq.AutoSize = true;
            this.labelEq.Location = new System.Drawing.Point(425, 156);
            this.labelEq.Name = "labelEq";
            this.labelEq.Size = new System.Drawing.Size(20, 20);
            this.labelEq.TabIndex = 4;
            this.labelEq.Text = "=";
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(451, 156);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(50, 20);
            this.labelRes.TabIndex = 5;
            this.labelRes.Text = "result";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(107, 257);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 20);
            this.labelInfo.TabIndex = 6;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(107, 71);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(372, 20);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Please input two integers and select the operator.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 347);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.labelEq);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxOp);
            this.Controls.Add(this.buttonCal);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCal;
        private System.Windows.Forms.ComboBox comboBoxOp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelEq;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelTitle;
    }
}

