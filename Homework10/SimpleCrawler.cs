using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Homework10
{
    class SimpleCrawler
    {
        public event Action<object, int> StartCrawl;
        public event Action<object, int, string> Crawling;
        public event Action<object, int> StopCrawl;
        //检测是否是绝对地址
        private static readonly string strAbsolute = 
            @"^(http|HTTP|https|HTTPS)://";
        //发现Url
        private static readonly string UrlDetect = 
            @"(href|HREF)[ ]*=[ ]*[""'](?<url>[^""'#>]+)[""']";
        //解析Url
        private static readonly string UrlParse = 
            @"^(?<protocal>https?)://(?<host>[\w\d.-]+)(:\d+)?($|/)(\w+/)*(?<file>[^#?]*)(?<parameter>(\?[^""'#>]+)*)";
        //文件类型解析
        private static readonly string fileFilter = @"(.html|.htm|.aspx|.jsp|.php)";
        //private Hashtable urls = new Hashtable();
        //url去重 ConcurrentDictionary线程安全
        private ConcurrentDictionary<string, bool> urls = 
            new ConcurrentDictionary<string, bool>();
        //下载队列 ConcurrentQueue线程安全
        private ConcurrentQueue<string> queue = new ConcurrentQueue<string>();
        //已爬取的网页数
        private int count = 0;
        //初始Url
        private string startUrl;
        //初始host
        private string startHost;
        //最大爬取数
        private readonly int maxCount;
        //爬虫编号
        private readonly int id;

        public SimpleCrawler(string startUrl, int maxCount, int id)
        {
            this.startUrl = startUrl;
            this.maxCount = maxCount;
            this.id = id;
        }

        public void Begin()
        {
            //加入初始页面
            urls.TryAdd(startUrl, false);
            queue.Enqueue(startUrl);
            Match parseUrl = Regex.Match(startUrl, UrlParse);
            startHost = parseUrl.Groups["host"].Value;
            new Thread(Crawl).Start();
        }

        private void Crawl()
        {
            StartCrawl(this, id);
            var tasks = new List<Task>();
            while (true)
            {
                if (queue.IsEmpty)
                    Task.WaitAll(tasks.ToArray());
                queue.TryDequeue(out string current);
                urls.TryGetValue(current, out bool downloaded);
                if (downloaded)
                    continue;
                if (current == null || count >= maxCount) 
                    break;
                Crawling(this, id, $"爬行{current}页面!");
                count++;
                urls[current] = true;
                Task task = Task.Run(() =>
                {
                    string html = DownLoad(current, count); // 下载
                    Parse(html, current);//解析,并加入新的链接
                });
                tasks.Add(task);
            }
            StopCrawl(this, id);
        }

        public string DownLoad(string url, int count)
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
                //添加后缀名
                Match match = new Regex(fileFilter).Match(url);
                string suffix = (match.ToString() != "") ? (match.ToString()) : ".html";
                string fileName = "./page/" + count.ToString() + suffix;
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Crawling(this, id, ex.Message);
                return "";
            }
        }

        private void Parse(string html, string current)
        {
            //两个"合在一起匹配"
            //(\?[^""'#>]+)*避免参数对判断后缀产生影响
            //string strRef = @"(href|HREF)=[""'][^""'#>]+(.htm|.html|.aspx|.jsp|.php)(\?[^""'#>]+)*[""']";
            var matches = new Regex(UrlDetect).Matches(html);
            foreach (Match match in matches)
            {
                /*
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
                */
                string htmlUrl = match.Groups["url"].Value;
                if (htmlUrl == null || htmlUrl == "" || htmlUrl.StartsWith("javascript:"))
                    continue;
                htmlUrl = FormUrl(htmlUrl, current);
                Match parseUrl = Regex.Match(htmlUrl, UrlParse);
                string host = parseUrl.Groups["host"].Value;
                string file = parseUrl.Groups["file"].Value;
                if (host == startHost && Regex.IsMatch(file, fileFilter))
                {
                    queue.Enqueue(htmlUrl);
                    urls[current] = false;
                }
            }
        }

        //是相对地址则转绝对
        private string FormUrl(string nowUrl, string baseUrl)
        {
            if (Regex.IsMatch(nowUrl, strAbsolute))
                return nowUrl;
            Uri baseUri = new Uri(baseUrl);
            Uri absoluteUri = new Uri(baseUri, nowUrl);
            return absoluteUri.ToString();
        }
    }
}
