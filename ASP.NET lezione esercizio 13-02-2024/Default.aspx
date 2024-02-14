<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP.NET_lezione_esercizio_13_02_2024._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>


        <input id="Nome" runat="server" type="text" required/>
        <input id="Cognome" runat="server" type="text" required/>
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />

    </main>

</asp:Content>
