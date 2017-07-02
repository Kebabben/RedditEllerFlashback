using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace GetThreadsFlashback
{
    public class GetFlashbackPostsList
    {
        String html = @"https://flashback.org/nya-inlagg";

        public GetFlashbackPostsList()
        {

        }
         
        public List<HtmlNode> GetNewPosts()
        {
            HtmlWeb web = new HtmlWeb();
            web.OverrideEncoding = Encoding.GetEncoding("iso-8859-1");

            HtmlDocument htmlDoc = web.Load(html);

            //Console.OutputEncoding = Encoding.GetEncoding("iso-8859-1");
            //htmlDoc.OptionDefaultStreamEncoding = Encoding.GetEncoding("iso-8859-1");

            


            HtmlNode[] nodes = htmlDoc.DocumentNode.SelectNodes("//a").ToArray();

            List<HtmlNode> Nodes = new List<HtmlNode>();
            foreach (HtmlNode item in nodes)
            {
                if (item.OuterHtml.Contains("/t") && !item.OuterHtml.Contains("thread-goto"))
                {
                    //byte[] bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(item.OuterHtml);
                    //String s = Encoding.UTF8.GetString(bytes);
                    
                    
                    

                    Nodes.Add(item);
                }
            }

            return Nodes;
        }


        

}
}
