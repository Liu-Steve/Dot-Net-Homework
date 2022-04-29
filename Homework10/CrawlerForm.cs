using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework10
{
    public partial class CrawlerForm : Form
    {
        private int crawlerNumber = 0;
        public CrawlerForm()
        {
            InitializeComponent();
            urlBox.Text = "http://www.cnblogs.com/dstang2000/";
            numSel.Value = 50;
        }

        private void Log(string logText)
        {
            logBox.Text += DateTime.Now.ToLocalTime().ToString() +
                Environment.NewLine + logText + Environment.NewLine;
            //保持在最后一行
            logBox.Focus();
            logBox.Select(logBox.Text.Length, 0);
            logBox.ScrollToCaret();
        }

        private void InvokeLog(string logText)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Log(logText)));
            }
            else
            {
                Log(logText);
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            crawlerNumber++;
            SimpleCrawler crawler = new SimpleCrawler(
                urlBox.Text, (int)numSel.Value, crawlerNumber);
            crawler.StartCrawl += StartCrawlHandler;
            crawler.Crawling += CrawlingHandler;
            crawler.StopCrawl += StopCrawlHandler;
            crawler.Begin();
        }

        private void StartCrawlHandler(object sender, int id)
        {
            string logText = $"{id}号爬虫：开始爬行了....";
            InvokeLog(logText);
        }

        private void CrawlingHandler(object sender, int id, string info)
        {
            string logText = $"{id}号爬虫：{info}";
            InvokeLog(logText);
        }

        private void StopCrawlHandler(object sender, int id)
        {
            string logText = $"{id}号爬虫：爬行结束";
            InvokeLog(logText);
        }
    }
}
