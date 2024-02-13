using System;
using System.Web;
using System.Web.UI;

namespace WebApplication5
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("Login");
            cookie.Values["Username"] = username.Text;
            cookie.Values["Password"] = password.Text;
            cookie.Expires = DateTime.Now.AddDays(5);
            Response.Cookies.Add(cookie);
            Response.Redirect("Paginadue");
        }
    }
}