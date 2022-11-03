using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmlakSitesiProjesi
{
    public partial class UserMainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //kullanıcı giriş yapmamışsa
            if (Convert.ToBoolean(Session["IsUserOnline"])!=true)
            {
                Response.Redirect("Login.aspx");
            }

            //kullanıcı giriş yaptığında
            else
            {
                userMail.InnerHtml ="Hoşgeldiniz "+ Session["UserMail"].ToString();
            }
        }
    }
}