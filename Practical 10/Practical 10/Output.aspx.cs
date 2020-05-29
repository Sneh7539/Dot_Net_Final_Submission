using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_10
{
    public partial class Output : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["Usrnm"].ToString()))
            {
                Label3.Text = Request.QueryString["Usrnm"];
            }
            if (!string.IsNullOrEmpty(Request.QueryString["Pwd"].ToString()))
            {
                Label4.Text = Request.QueryString["Pwd"];
            }
        }
    }
}