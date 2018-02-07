using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace MyCodeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            WebClient client = new WebClient(); // DownloadString()是一个下载网页的方法，位于System.Net命名空间的WebClient类中
            string reply = client.DownloadString(url);
            Console.WriteLine(reply);

            File.WriteAllText(@"C:\Users\lx389\Documents\reply.txt", reply);
        }
        public string ScrapeWebpage(string url,string filepath)
        {

        }
    }
}
