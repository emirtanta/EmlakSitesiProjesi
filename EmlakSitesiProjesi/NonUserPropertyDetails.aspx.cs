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
    public partial class NonUserPropertyDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var myID =Convert.ToInt32( Request.QueryString["selectedid"]);

            

            DataList1.DataSource= PropertyOperations.GetPropByID(myID);
            DataList1.DataBind();

            //dataReader değerini kapatarak çalışma zamanında hata almamak için
            PropertyOperations.drGetPropByID.Close();
        }
    }
}