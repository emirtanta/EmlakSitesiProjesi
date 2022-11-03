using EmlakSitesiProjesi.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmlakSitesiProjesi
{
    public partial class UserSelling : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (Convert.ToBoolean(Session["IsUserOnline"])!=true)
            {
                Response.Redirect("Login.aspx");
            }

            if (Page.IsPostBack==false)
            {
                DropDownListCity.DataValueField = "CityID";
                DropDownListCity.DataTextField = "CityName";

                DropDownListCity.DataSource = CityOperations.BindDropdownCity();
                DropDownListCity.DataBind();

                LoadHoods();

                //dropdownlist elemanına manuel olarak veritabanından değer eklemeden değer atama
                
                DropDownListType.Items.Insert(0,"Konut");
                DropDownListType.Items.Insert(1,"Arsa");

                //dropdownlist elemanına manuel olarak veritabanından değer eklemeden değer atama bitti

                LoadRoom();
            }  

            
        }

        
        

        
        //il mahalle biribirine bağlı dropdownlist yapısı için tanımlandı
        protected void DropDownListCity_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            LoadHoods();
            
        }

        protected void DropDownListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListType.SelectedValue.ToString()=="Konut")
            {
                if (DropDownListRoom.Items.Count>0)
                {
                    DropDownListRoom.Visible = true;
                }

                else
                {
                    DropDownListRoom.Visible = true;
                    LoadRoom();
                }
                
            }

            else
            {
                DropDownListRoom.Visible = false;
            }
        }

        public void LoadHoods()
        {
            DropDownListHood.DataValueField = "HoodID";
            DropDownListHood.DataTextField = "HoodName";

            DropDownListHood.DataSource = HoodOperations.BindDropdownHood(Convert.ToInt32(DropDownListCity.SelectedValue));
            DropDownListHood.DataBind();
        }

        public void LoadRoom()
        {
            DropDownListRoom.Items.Insert(0, "3+1");
            DropDownListRoom.Items.Insert(1, "2+1");
            DropDownListRoom.Items.Insert(2, "1+1");
        }

        protected void btnAddProperty_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tboxPhoto.Text.ToString()))
            {
                Response.Write("Fotograf kısmı boş bırakılamaz");
            }

            else if (string.IsNullOrEmpty(tboxPrice.Text.ToString()))
            {
                Response.Write("Fiyat kısmı boş bırakılamaz");
            }

            else if (string.IsNullOrEmpty(tboxTitle.Text.ToString()))
            {
                Response.Write("Başlık kısmı boş bırakılamaz");
            }

            else 
            {
                
            }
        }

        
    }
}