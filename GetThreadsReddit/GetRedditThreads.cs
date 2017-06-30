using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace GetThreadsReddit
{
    public class GetRedditThreads
    {
        public GetRedditThreads()
        {

        }

        //Initial test code
        public List<XmlNode> GetThreads()
        {

            //Get the data from subreddit
            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = wc.DownloadData("https://www.reddit.com/r/sweden/.xml?count=100&limit=100");

            string webData = System.Text.Encoding.UTF8.GetString(raw);

            //Put the data into a XmlDocument
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(webData);

            //Extract all the threads
            XmlNodeList AllEntrys = doc.GetElementsByTagName("entry");

            List<XmlNode> Nodes = new List<XmlNode>();

            //Do ... for each thread
            foreach (XmlNode node in AllEntrys)
            {
                Nodes.Add(node);
                // Console.WriteLine(node.ChildNodes[AttribueValues.title].InnerXml);
                // Console.WriteLine();
            }

            return Nodes;
        }
}
}
