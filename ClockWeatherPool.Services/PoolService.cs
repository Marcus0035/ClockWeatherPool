using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using HtmlAgilityPack;

namespace ClockWeatherPool.Services
{
    public class PoolService
    {
        public async Task<string> GetCount()
        {
            using HttpClient client = new HttpClient();
            string url = @$"https://www.dropbox.com/scl/fi/iv7ib1dgbqmiwxzq4zwev/pocet_nav.txt?rlkey=2dhr1e4zaleez0pkyh1a8opi0&raw=1";
            string html = await client.GetStringAsync(url);

            //HtmlDocument doc = new HtmlDocument();
            //doc.LoadHtml(html);

            //var xpath = "//body/pre";
            //HtmlNode node = doc.DocumentNode.SelectSingleNode(xpath);
            return html ?? "Nenalezeno";
        }
    }
}
