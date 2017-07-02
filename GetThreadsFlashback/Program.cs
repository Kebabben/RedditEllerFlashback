using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;


namespace GetThreadsFlashback
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.;

            GetFlashbackPostsList get = new GetFlashbackPostsList();

            get.GetNewPosts();
            






            Console.ReadKey();
        }
    }
}
