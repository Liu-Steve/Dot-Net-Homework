using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Homework9
{
    class SimpleCrawler
    {
        private static string strAbsolute = @"^(http|HTTP|https|HTTPS)://";
        private Hashtable urls = new Hashtable();
        private int count = 0;
        private Form1 form;
        private string startUrl;
        private int maxCount;
        public static void Begin(Form1 form, string startUrl, int maxCount)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            myCrawler.form = form;
            myCrawler.urls.Add(startUrl, false);//加入初始页面
            startUrl = Regex.Replace(startUrl, strAbsolute, "");
            myCrawler.startUrl = startUrl;
            myCrawler.maxCount = maxCount;
            new Thread(myCrawler.Crawl).Start();
        }

        private void Crawl()
        {
            form.Invoke(form.log, new object[] { "开始爬行了.... " });
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) 
                        continue;
                    current = url;
                }
                if (current == null || count > maxCount) 
                    break;
                form.Invoke(form.log, new object[] { "爬行" + current + "页面!" });
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html, current);//解析,并加入新的链接
            }
            form.Invoke(form.log, new object[] { "爬行结束" });
        }

        public string DownLoad(string url)
        {
            if (!Directory.Exists("./page"))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo("./page");
                directoryInfo.Create();
            }
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string strSuffix = @"(.html|.htm|.aspx|.jsp|.php)";
                Match match = new Regex(strSuffix).Match(url);
                string suffix = (match.ToString() != "") ? (match.ToString()) : ".html";
                string fileName = "./page/" + count.ToString() + suffix;
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                form.Invoke(form.log, new object[] { ex.Message });
                return "";
            }
        }

        private void Parse(string html, string current)
        {
            //两个"合在一起匹配"
            //(\?[^""'#>]+)*避免参数对判断后缀产生影响
            string strRef = @"(href|HREF)=[""'][^""'#>]+(.htm|.html|.aspx|.jsp|.php)(\?[^""'#>]+)*[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (!Regex.IsMatch(strRef, strAbsolute))
                    strRef = FormUrl(strRef, current);
                //仅爬取本站下的
                if (!Regex.IsMatch(strRef, startUrl))
                    continue;
                if (strRef.Length == 0) 
                    continue;
                if (urls[strRef] == null) 
                    urls[strRef] = false;//去重并添加
            }
        }

        private string FormUrl(string nowUrl, string baseUrl)
        {
            Uri baseUri = new Uri(baseUrl);
            Uri absoluteUri = new Uri(baseUri, nowUrl);
            return absoluteUri.ToString();
        }
    }
}
