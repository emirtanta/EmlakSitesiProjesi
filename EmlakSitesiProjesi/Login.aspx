<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EmlakSitesiProjesi.Login" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <meta http-equiv="content-type" content="text/html;charset=utf-8" />

    <style>
        .mybox{
            width: 200px;
            height: 40px;
            margin-top:20px;
        }
        .mybutton{
            width:100px;
            height:40px;
            margin-top:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" method="post" style="display: flex; flex-direction: column; height: 500px; margin-left: 20px">
        <h2>Giriş Yap</h2>

        
        <asp:TextBox ID="tboxMail" CssClass="form-control mybox" runat="server" placeholder="mail girin"></asp:TextBox>
        
        <asp:TextBox ID="tboxPassword" CssClass="form-control mybox" runat="server" TextMode="Password" placeholder="şifre girin"></asp:TextBox>

        <asp:Button ID="Button1" CssClass="btn btn-danger mybutton" runat="server" Text="Giriş Yap" OnClick="Button1_Click"  />

    </form>
</body>
</html>
