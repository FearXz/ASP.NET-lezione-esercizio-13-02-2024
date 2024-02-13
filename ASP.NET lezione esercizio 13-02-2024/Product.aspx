<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Product.aspx.cs" Inherits="ASP.NET_lezione_esercizio_13_02_2024.Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <p>
       <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    <div class="Container">
        <div class="Row">
            <div class="Col-12">
                <div id="kebab" class=" border border-1">
                    <p>kebab</p>
                    <p>50</p>
                    <asp:Button ID="Button1" Text="Aggiugni" runat="server" OnClick="Button1_Click" CommandArgument="kebab-50" />
                </div>
                <div id="piadina" class=" border border-1">
                    <p>piadina</p>
                    <p>100</p>
                    <asp:Button ID="Button2" Text="Aggiugni" runat="server" OnClick="Button1_Click" CommandArgument="piadina-100" />
                </div>
            </div>
        </div>
    </div>
</body>

</html>

 </asp:Content>


