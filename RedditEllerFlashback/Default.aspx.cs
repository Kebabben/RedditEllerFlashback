using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using HtmlAgilityPack;
using GetThreadsFlashback;
using GetThreadsReddit;

namespace RedditEllerFlashback
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetFlashbackPostsList Flashback = new GetFlashbackPostsList();

            List<HtmlNode> FlashbackPostList = Flashback.GetNewPosts();

            GetRedditThreads Reddit = new GetRedditThreads();

            List<XmlNode> RedditPostList = Reddit.GetThreads();

            int RandomNumber = new Random().Next();


            HtmlNode SelectedFlashbackPost = FlashbackPostList[RandomNumber % FlashbackPostList.Count];

            XmlNode SelectedRedditPost = RedditPostList[RandomNumber % RedditPostList.Count].ChildNodes[AttribueValues.title];


            FlashbackPostLabel.Text = SelectedFlashbackPost.OuterHtml;

            


            //RedditPostLabel.Text = SelectedRedditPost.InnerText;


            int h = 0;
        }
    }
}