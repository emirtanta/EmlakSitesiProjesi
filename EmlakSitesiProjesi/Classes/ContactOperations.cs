using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmlakSitesiProjesi.Classes
{
    public class ContactOperations
    {
        public static List<string> GetContactInfo()
        {
            SqlCommand commandGetContactInfo = new SqlCommand("Select * from TableContact where ContactID=@p1",SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            commandGetContactInfo.Parameters.AddWithValue("@p1", 1);

            SqlDataReader drGetContactInfo = commandGetContactInfo.ExecuteReader();

            string c_mail = "";
            string c_phone = "";
            string c_adress = "";

            List<string> mylist = new List<string>();

            while (drGetContactInfo.Read())
            {
                c_mail = drGetContactInfo[1].ToString();
                c_phone = drGetContactInfo[2].ToString();
                c_adress = drGetContactInfo[3].ToString();

                mylist.Add(c_mail);
                mylist.Add(c_phone);
                mylist.Add(c_adress);
            }

            drGetContactInfo.Close();

            return mylist;
        }
    }
}