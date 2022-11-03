<%@ Page Title="" Language="C#" MasterPageFile="~/NonUser.Master" AutoEventWireup="true" CodeBehind="NonUserProperty.aspx.cs" Inherits="EmlakSitesiProjesi.NonUserProperty" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <a href="NonUserPropertyDetails.aspx?selectedid=<%#Eval("PropertyID") %>">
                <div style="width:90%;min-height:150px;margin:10px;padding:20px;border:1px solid #dadada;display:flex;flex-direction:row;justify-content:space-between;align-items:center">
                <asp:Image ID="Image1" ImageUrl='<%#Eval("PropertyPhotos") %>' runat="server" width="260px" height="130px"></asp:Image>
                <h2><%#Eval("PropertyTitle") %></h2>
                <h2><%#Eval("PropertyPrice") %></h2>
            </div>
            </a>
            
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
