using System;
using System.Web;
using System.Web.UI;

namespace ASP.NET_lezione_esercizio_13_02_2024
{
    public partial class Cart : Page
    {
        HttpCookie cookie;
        protected void Page_Load(object sender, EventArgs e)
        {
            cookie = Request.Cookies["cart"];

            if (cookie != null)
            {
                string[] noTitle = cookie.Value.Split('=');
                string[] products = noTitle[1].Split('/');
                foreach (string product in products)
                {
                    cartDiv.InnerHtml += product + "<br>";
                }
            }

        }

        protected void DeleteCookies_Click(object sender, EventArgs e)
        {
            DeleteCookie("cart");
            cartDiv.InnerHtml = "Carrello vuoto";
        }

        protected void DeleteCookie(string cookie)
        {
            HttpCookie userData = new HttpCookie(cookie);
            userData.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Add(userData);
        }
    }
}