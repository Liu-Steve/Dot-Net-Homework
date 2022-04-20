using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework9
{
    public partial class Form1 : Form
    {
        public Action<string> log;
        public Form1()
        {
            InitializeComponent();
            log = new Action<string>(Log);
            urlBox.Text = "http://www.cnblogs.com/dstang2000/";
            numSel.Value = 50;
        }

        public void Log(string logText)
        {
            logBox.Text += DateTime.Now.ToLocalTime().ToString() +
                Environment.NewLine + logText + Environment.NewLine;
            //保持在最后一行
            logBox.Focus();
            logBox.Select(logBox.Text.Length, 0);
            logBox.ScrollToCaret();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            SimpleCrawler.Begin(this, urlBox.Text, (int)numSel.Value);
        }
    }
}
