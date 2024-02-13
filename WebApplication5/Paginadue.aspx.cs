using System;
using System.Web;

namespace WebApplication5
{
    public partial class Paginadue1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Login"]["Username"] != "")
            {
                Label1.Text = Request.Cookies["Login"]["Username"];
            }
            else
            {
                Response.Redirect("Default");
            }

        }

        protected void Logout(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("Login");
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
            Response.Redirect("Default");
        }
    }
}