using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RedditEllerFlashback
{
    public partial class Result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //String Guessed = (String)Session["Guessed"];

            String s = Request.QueryString["guess"];

            StoredThreadInfo Info = (StoredThreadInfo)Session["Thread"];

            if (s == Info.ThreadFrom.ToLower())
            {
                Label1.Text = "Rätt!";
            }
            else
            {
                Label1.Text = "Fel!";
            }


        }
    }
}