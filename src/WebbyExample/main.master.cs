using System;

namespace WebbyExample
{
    public partial class main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Page.Title = "Webby Example - Blog";
        }
    }
}
