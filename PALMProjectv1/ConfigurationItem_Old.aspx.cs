using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PalmBusinessLayer;

namespace PALMProjectv1
{
    public partial class ConfigurationItem_Old : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConfigurationItem_View.aspx");
        }

        protected void gvGetOldCI_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ReactivateCI")
            {

                //retrieve row index
                int index = Convert.ToInt32(e.CommandArgument);

                int ciid = Convert.ToInt32(gvGetOldCI.Rows[index].Cells[0].Text);

                if (ciid == null)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Something has gone wrong');", true);
                }
                else
                {
                    Configuration_Items ci = new Configuration_Items();

                    ci.ActivateCI(ciid);

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Configuration Item Reactivated... Refreshing page');window.location = 'ConfigurationItem_Old.aspx';", true);
                }
            }
        }
    }
}