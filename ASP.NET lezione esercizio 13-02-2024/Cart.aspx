<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="ASP.NET_lezione_esercizio_13_02_2024.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="Container">
        <div class="Row">

            <div class="Col-12">
                <asp:Button ID="DeleteCookies" runat="server" Text="Delete Cookies" OnClick="DeleteCookies_Click"  />
            </div>

            <div class="Col-12">
                <div id="cartDiv" runat="server">
                </div>
            </div>
        </div>
    </div>

</asp:Content>