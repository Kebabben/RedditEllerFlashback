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
    public partial class Start : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Request.Browser.IsMobileDevice)
                MasterPageFile = "~/Default.aspx";
        }


        StoredThreadInfo Info = new StoredThreadInfo();


        protected void Page_Load(object sender, EventArgs e)
        {
            //Get flashback posts
            GetFlashbackPostsList Flashback = new GetFlashbackPostsList();

            List<HtmlNode> FlashbackPostList = Flashback.GetNewPosts();


            //Get reddit posts
            GetRedditThreads Reddit = new GetRedditThreads();

            List<XmlNode> RedditPostList = Reddit.GetThreads();


            //Randomize a number
            int RandomNumber = new Random().Next();


            //Select a flashback and a reddit post
            XmlNode SelectedRedditPost = RedditPostList[RandomNumber % RedditPostList.Count];

            HtmlNode SelectedFlashbackPost = FlashbackPostList[RandomNumber % FlashbackPostList.Count];


            //Randomize between Flashback or Reddit
            if (RandomNumber % 2 == 0)
            {
                //Flashback has been selected

                //Store the threads information in a class

                Info.LinkToThread = "www.flashback.org/" + SelectedFlashbackPost.Attributes["href"].Value;
                Info.NameOfThread = SelectedFlashbackPost.InnerText;
                Info.ThreadFrom = "Flashback";

                //FlashbackPostLabel.Text = Info.NameOfThread;

                //Store the data in session

            }
            else
            {
                //Reddit has been selected

                //Store the threads information in a class

                Info.LinkToThread = SelectedRedditPost.ChildNodes[AttribueValues.link].OuterXml.Split('"')[1];
                Info.NameOfThread = SelectedRedditPost.ChildNodes[AttribueValues.title].FirstChild.Value;
                Info.ThreadFrom = "Reddit";

                //FlashbackPostLabel.Text = Info.NameOfThread;


            }





            int h = 0;
        }

        protected void Page_LoadComplete()
        {
            //Create a list of all thread names that's been guessed
            List<String> GuessedThreads = new List<string>();

            //Load from Session (if there is any) and store it in GuessedThreads

            GuessedThreads = (List<String>)Session["AlreadyGuessed"];

            //If there's no Session, reset GuessedThreads
            if (GuessedThreads == null)
                GuessedThreads = new List<string>();

            //Add the newest guessed
            GuessedThreads.Add(ThreadLabel.Text);

            //Store guessed threads in it's Session
            Session["AlreadyGuessed"] = GuessedThreads;

            Session["Thread"] = Info;


            ThreadLabel.Text = Info.NameOfThread;
        }

        protected void VoteFlashback(object sender, EventArgs e)
        {
            //Session["Guessed"] = "Flashback";


            Response.Redirect("~/Result.aspx" + "?guess=flashback");


            //Response.Redirect(HttpContext.Current.Request.Path);
        }

        protected void VoteReddit(object sender, EventArgs e)
        {
            //Session["Guessed"] = "Reddit";

            Response.Redirect("~/Result.aspx" + "?guess=reddit");
        }
    }
}