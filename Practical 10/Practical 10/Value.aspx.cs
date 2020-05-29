using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_10
{
    public partial class Value : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Response.Redirect("Output.aspx?Usrnm = " + Usrnm.Text + "&Pwd = " + Pwd.Text + "");
            }
        }
    }
}