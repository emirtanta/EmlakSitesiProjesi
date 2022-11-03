using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace EmlakSitesiProjesi.Classes
{
    public class PropertyOperations
    {
        public static SqlDataReader drGetAllProp;
        public static SqlDataReader drGetPropByID;
        public static SqlDataReader GetAllProp()
        {
            SqlCommand commandLoadProperties = new SqlCommand("select * from TableProperty where PropertyApprove=@p1", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            //1=> onaylı ürünü getirir
            commandLoadProperties.Parameters.AddWithValue("@p1", 1);

            //veri okuyarak web kısmında gösterildi
             drGetAllProp = commandLoadProperties.ExecuteReader();

            return drGetAllProp;
            //veri okuyarak web kısmında gösterildi bitti
        }

        //id değerine göre emlak datasını getirir
        public static SqlDataReader GetPropByID(int fake_id)
        {
            SqlCommand commandGetProperties = new SqlCommand("select * from TableProperty where PropertyID=@pid", SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            commandGetProperties.Parameters.AddWithValue("@pid", fake_id);

            drGetPropByID = commandGetProperties.ExecuteReader();

            return drGetPropByID;
        }

        //ürün ekleme
        //cityID=>dropdownlistcity
        //hoodID=>dropdownlisthood
        //room=>dropdownlistroom
        //type=>dropdownlisttype
        public static void AddProperty(string title,string price,int cityID,int hoodID,string room,string photoLink,string type)
        {
            //
            SqlCommand commandAddProperty = new SqlCommand("Insert Into TableProperty (PropertyTitle,PropertyPrice,PropertyCity,PropertyHood,PropertyRoom,PropertyPhotos,PropertyType) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)",SqlConnectionClass.connection);

            SqlConnectionClass.CheckConnection();

            commandAddProperty.Parameters.AddWithValue("@p1", title);
            commandAddProperty.Parameters.AddWithValue("@p2", price);
            commandAddProperty.Parameters.AddWithValue("@p3", cityID);
            commandAddProperty.Parameters.AddWithValue("@p4", hoodID);
            commandAddProperty.Parameters.AddWithValue("@p5", room);
            commandAddProperty.Parameters.AddWithValue("@p6", photoLink);
            commandAddProperty.Parameters.AddWithValue("@p7", type);

            commandAddProperty.ExecuteNonQuery();
        }
    }
}