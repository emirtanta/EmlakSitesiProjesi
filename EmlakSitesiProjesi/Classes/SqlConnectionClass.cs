using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace EmlakSitesiProjesi.Classes
{
    public class SqlConnectionClass
    {
         public static SqlConnection connection = new SqlConnection("Data Source=LENEVO-PC\\LENEVOSERVER;Initial Catalog=WebFormsEmlakDB;User ID=sa;Password=123");

        //bağlantıyı açıp kapatmaya yarar

        public static void CheckConnection()
        {
            //bağlantı durumu kapalı ise
            if (connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            else
            {
                
            }
        }

        //bağlantıyı açıp kapatmaya yarar bitti

        
    }
}