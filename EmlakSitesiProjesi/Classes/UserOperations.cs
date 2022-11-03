using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmlakSitesiProjesi.Classes
{
    public class UserOperations
    {

        //temp değişkeni direk textbox nesnesi burdana  çağrılmadığı için tanımlandı
        public static void UserRegister(string temp_mail,string temp_name,string temp_surname,string temp_password)
        {
            SqlCommand commandRegister = new SqlCommand("Insert into TableUser(UserMail,UserName,UserSurname,UserPassword,UserRegisterDate) values (@pmail,@pname,@psurname,@ppass,@pdate)", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            //parametrelere değer eklendi

            commandRegister.Parameters.AddWithValue("@pmail", temp_mail);
            commandRegister.Parameters.AddWithValue("@pname", temp_name);
            commandRegister.Parameters.AddWithValue("@psurname", temp_surname);
            commandRegister.Parameters.AddWithValue("@ppass", SHA256Converter.ComputeSha256Hash(temp_password)); //şifreyi şifreli bir şekilde veritabanına ekler
            commandRegister.Parameters.AddWithValue("@pdate", DateTime.Now);

            //parametrelere değer eklendi bitti

            commandRegister.ExecuteNonQuery();
        }

        public static DataTable UserLogin(string mail,string sifre)
        {
            SqlCommand commandLogin = new SqlCommand("Select * from TableUser where UserMail=@pmail and UserPassword=@ppas",SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            commandLogin.Parameters.AddWithValue("@pmail", mail);
            commandLogin.Parameters.AddWithValue("@ppas", SHA256Converter.ComputeSha256Hash(sifre));

            SqlDataAdapter da = new SqlDataAdapter(commandLogin); //sqldeki verileri alır

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
    }
}