using System;
using System.Web;
using System.Web.UI.WebControls;

namespace ASP.NET_lezione_esercizio_13_02_2024
{
    public partial class Product : System.Web.UI.Page
    {
        HttpCookie cart;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["login"] != null)
            {
                Label1.Text = "Benvenuto " + Request.Cookies["login"]["nome"] + " " + Request.Cookies["login"]["cognome"];
                cart = new HttpCookie("cart");
                cart.Values["cart"] = string.Empty;
                Response.Cookies.Add(cart);
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string parametro = ((Button)sender).CommandArgument;
            // string[] parametroSplit = parametro.Split('-');

            if (Request.Cookies["cart"] != null)
            {
                string oldCookie = Request.Cookies["cart"].Value;
                cart.Values["cart"] = oldCookie + parametro + "/";
                cart.Expires = DateTime.Now.AddDays(7);
                Response.Cookies.Add(cart);

            }
        }
    }
}