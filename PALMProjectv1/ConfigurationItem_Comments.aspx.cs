using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PALMProjectv1
{
    public partial class ConfigurationItem_Comments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConfigurationItem_View.aspx");
        }

    }
}