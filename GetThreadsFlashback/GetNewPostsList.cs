using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace GetThreadsFlashback
{
    class GetNewPostsList
    {
        String html = @"https://flashback.org/nya-inlagg";

        GetNewPostsList()
        {

        }
         
        List<HtmlNode> GetNewPosts()
        {
            HtmlWeb web = new HtmlWeb();

            HtmlDocument htmlDoc = web.Load(html);

            Console.OutputEncoding = Encoding.GetEncoding("iso-8859-1");
            htmlDoc.OptionDefaultStreamEncoding = Encoding.GetEncoding("iso-8859-1");

            
            HtmlNode[] nodes = htmlDoc.DocumentNode.SelectNodes("//a").ToArray();

            List<HtmlNode> Nodes = new List<HtmlNode>();
            foreach (HtmlNode item in nodes)
            {
                if (item.OuterHtml.Contains("/t") && !item.OuterHtml.Contains("thread-goto"))
                    Nodes.Add(item);
            }

            return Nodes;
        }


        

}
}
