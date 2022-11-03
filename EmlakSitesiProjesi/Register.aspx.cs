using EmlakSitesiProjesi.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmlakSitesiProjesi
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
        }

        //kayıt ol butonu
        protected void Button1_Click(object sender, EventArgs e)
        {
            UserOperations.UserRegister(tboxMail.Text,tboxName.Text,tboxSurname.Text,tboxPassword.Text);
        }
    }
}