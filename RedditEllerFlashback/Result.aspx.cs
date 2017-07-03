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

        private bool Mobile = false;


        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (Request.Browser.IsMobileDevice || Utils.fBrowserIsMobile())
                Mobile = true;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //String Guessed = (String)Session["Guessed"];

            String s = Request.QueryString["guess"];

            StoredThreadInfo Info = (StoredThreadInfo)Session["Thread"];

            if (s == Info.ThreadFrom.ToLower())
            {
                Label1.Text = "Rätt!";
                ContinueButton.Text = "Fortsätt";
            }
            else
            {
                Label1.Text = "Fel!";
                ContinueButton.Text = "Börja om";
            }


            if (Mobile)
            {
                ContinueButton.Style["width"] = "85vw;";
            }


        }

        protected void Continue(object sender, EventArgs e)
        {
            Response.Redirect("~/Start.aspx");
        }
    }
}