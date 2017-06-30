using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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



        }
    }
}