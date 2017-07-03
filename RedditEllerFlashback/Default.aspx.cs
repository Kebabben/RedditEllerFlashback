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


        protected void StartClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Start.aspx");
        }
    }
}