<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserSelling.aspx.cs" Inherits="EmlakSitesiProjesi.UserSelling" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" method="post">
        <h2>Kullanıcı Satış Sayfası</h2>
        
        <br />
        
        <asp:TextBox ID="tboxTitle" runat="server" Height="33px" Width="376px" placeholder="Başlık"></asp:TextBox>

        <br />
        <br />

        <asp:TextBox ID="tboxPrice" runat="server" Height="33px" Width="376px" placeholder="Fiyat"></asp:TextBox>

        <br />
        <br />

        <asp:DropDownList ID="DropDownListCity" AutoPostBack="true"  runat="server" Height="33px" Width="376px" OnSelectedIndexChanged="DropDownListCity_SelectedIndexChanged"></asp:DropDownList>

        <br />
        <br />

        <asp:DropDownList ID="DropDownListHood" runat="server" Height="33px" Width="376px"></asp:DropDownList>

        <br />
        <br />

        <asp:DropDownList ID="DropDownListType" OnSelectedIndexChanged="DropDownListType_SelectedIndexChanged" AutoPostBack="true" runat="server" Height="33px" Width="376px"></asp:DropDownList>

        

        <br />
        <br />

        <asp:DropDownList ID="DropDownListRoom" runat="server" Height="33px" Width="376px"></asp:DropDownList>

        <br />
        <br />

        <asp:TextBox ID="tboxPhoto" runat="server" Height="33px" Width="376px" placeholder="Fotograf linki"></asp:TextBox>

        <br />
        <br />

        <asp:Button ID="btnAddProperty" runat="server" CssClass="btn btn-success" Text="Ekle" OnClick="btnAddProperty_Click" />
        
    </form>
</asp:Content>
