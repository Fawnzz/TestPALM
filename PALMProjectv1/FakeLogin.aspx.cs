using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PALMProjectv1
{
    public partial class FakeLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           //Session.Abandon();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Session["ProjectID"] = lstProject.SelectedValue;
            Session["UserID"] = lstUser.SelectedValue;
            Session["Role"] = lstRole.SelectedValue;

            Response.Redirect("ConfigurationItem_View.aspx");
        }
    }
}