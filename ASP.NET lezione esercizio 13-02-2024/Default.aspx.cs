using System;
using System.Web;
using System.Web.UI;

namespace ASP.NET_lezione_esercizio_13_02_2024
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie userData = new HttpCookie("login");

            userData.Values["nome"] = Nome.Value;
            userData.Values["cognome"] = Cognome.Value;

            userData.Expires = DateTime.Now.AddDays(7);

            Response.Cookies.Add(userData);

            Response.Redirect("Product.aspx");
        }
    }
}