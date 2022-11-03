<%@ Page Title="" Language="C#" MasterPageFile="~/NonUser.Master" AutoEventWireup="true" CodeBehind="NonUserPropertyDetails.aspx.cs" Inherits="EmlakSitesiProjesi.NonUserPropertyDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" id="form1" method="post">
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                Başlık<asp:Label ID="Label1" runat="server" Text='<%# Eval("PropertyTitle") %>'></asp:Label>
                <br />
                <br />
                <asp:Image ID="Image1" ImageUrl='<%#Eval("PropertyPhotos") %>' runat="server" />

                <br />
                <br />

                Tür:<asp:Label ID="Label2" runat="server" Text='<%#Eval("PropertyType") %>'></asp:Label>

                <br />

                Şehir:<asp:Label ID="Label3" runat="server" Text='<%#Eval("PropertyCity") %>'></asp:Label>

                <br />

                <br />
                Mahalle:<asp:Label ID="Label6" runat="server" Text='<%#Eval("PropertyHood") %>'></asp:Label>

                Fiyat:<asp:Label ID="Label4" runat="server" Text='<%#Eval("PropertyPrice") %>'></asp:Label>

                <br />

                Oda Sayısı:<asp:Label ID="Label5" runat="server" Text='<%#Eval("PropertyRoom") %>'></asp:Label>

            </ItemTemplate>
        </asp:DataList>
    </form>
</asp:Content>
