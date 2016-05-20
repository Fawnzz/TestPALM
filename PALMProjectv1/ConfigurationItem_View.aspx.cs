using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PalmBusinessLayer;
using System.Web.Script.Services;
using System.Web.Services;

namespace Palm
{
    public partial class ConfigurationItem_View : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //if Role is Client, make controls visible = false

            if (Session["Role"].ToString() == "Client")
            {
                gvGetNewCI.Columns[12].Visible = false;
                btnOld.Visible = false;
            }
            
            
            
        }

        protected void btnSwitch_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConfigurationItem_Create.aspx");
        }

        protected void btnOld_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConfigurationItem_Old.aspx");
        }

        protected void btnEditCI_Click(object sender, EventArgs e)
        {
            //create temp variables to pass convert string values
            int version = 0;
            int ciid = 0;
            int userid = 0;
            int status = 0;
            int priority = 0;

            try
            {
                //pass values to variables
                Int32.TryParse(txtCiid.Text, out ciid);
                string description = txtDescrip.Text;
                string category = txtCategory.Text;
                Int32.TryParse(txtUser.Text, out userid);
                string duedate = txtDueDate.Text;
                Int32.TryParse(txtVersion.Text, out version);
                Int32.TryParse(Session["UserID"].ToString(), out userid);
                Int32.TryParse(lstPriority.SelectedValue, out status);
                Int32.TryParse(lstPriority.SelectedValue, out priority);
                string audience = lstAudience.SelectedValue;

                if (ciid == null || description == "" || category == "" || userid == null || duedate == "" || version == null || status == null || priority == 0 || audience == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Must fill out all information');", true);
                }
                else
                {
                    
                    Configuration_Items ci = new Configuration_Items();

                    ci.EditCI(ciid, description, category, userid, duedate, version, status, priority, audience);

                    editDiv.Visible = false;

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Configuration Item Edited.. Returning to View page');window.location = 'ConfigurationItem_View.aspx';", true);
                }
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('An error has occured. If the error persists, contact the system admin.');", true);
            }


        }

        protected void btnAddCom_Click(object sender, EventArgs e)
        {
            //create variables to pass convert string values
            int ciid = 0;
            int version = 0;
            int userid = 0;
            string user = Session["UserID"].ToString();
            string comment = "";

            try
            {
                Int32.TryParse(txtComCIID.Text, out ciid);
                Int32.TryParse(txtComVer.Text, out version);
                Int32.TryParse(user, out userid);
                comment = txtComment.Text;

                if (ciid == null || version == null || userid == null || comment == "")
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Must fill out all information');", true);
                }
                else
                {
                    
                    Configuration_Items ci = new Configuration_Items();

                    ci.AddComment(ciid, version, userid, comment);

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Comment Added.. Returning to View page');window.location = 'ConfigurationItem_View.aspx';", true);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void gvGetNewCI_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //run code based on command name
            if (e.CommandName == "EditCI")
            {
                //retrieve row index
                int index = Convert.ToInt32(e.CommandArgument);
                int version = 0;
                string userid = Session["UserID"].ToString();
                string ciid = gvGetNewCI.Rows[index].Cells[1].Text;
                string description = gvGetNewCI.Rows[index].Cells[2].Text;
                string category = gvGetNewCI.Rows[index].Cells[3].Text;
                string duedate = gvGetNewCI.Rows[index].Cells[4].Text;
                Int32.TryParse(gvGetNewCI.Rows[index].Cells[10].Text, out version);

                version = version + 1;

                txtCiid.Text = ciid;
                txtVersion.Text = version.ToString();
                txtDescrip.Text = description;
                txtCategory.Text = category;
                txtDueDate.Text = duedate;
                txtUser.Text = userid;

                editDiv.Visible = true;

            }
            else if (e.CommandName == "DisableCI")
            {

                //retrieve row index
                int index = Convert.ToInt32(e.CommandArgument);

                int ciid = Convert.ToInt32(gvGetNewCI.Rows[index].Cells[1].Text);

                    Configuration_Items ci = new Configuration_Items();

                    ci.DisableCI(ciid);

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Configuration Item Disabled... Refreshing page');window.location = 'ConfigurationItem_View.aspx';", true);
                
            }
            else if (e.CommandName == "CommentCI")
            {
                //retrieve row index
                int index = Convert.ToInt32(e.CommandArgument);
                int version = 0;

                string ciid = gvGetNewCI.Rows[index].Cells[1].Text;
                Int32.TryParse(gvGetNewCI.Rows[index].Cells[5].Text, out version);

                version = version + 1;

                txtComCIID.Text = ciid;
                txtComVer.Text = version.ToString();

                commentDiv.Visible = true;
                
            }
            else if (e.CommandName == "ViewCIComment")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                //int ciid = 0;

                Session["CIID"] = gvGetNewCI.Rows[index].Cells[1].Text;

                Response.Redirect("ConfigurationItem_Comments.aspx");
            }
            else if (e.CommandName == "ReviewCI")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                int ciid = Convert.ToInt32(gvGetNewCI.Rows[index].Cells[1].Text);

                Configuration_Items ci = new Configuration_Items();

                ci.ReviewCI(ciid);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Configuration Item Reviewed... Refreshing page');window.location = 'ConfigurationItem_View.aspx';", true);
            }
            else if (e.CommandName == "CIVersions")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                Session["CIID"] = gvGetNewCI.Rows[index].Cells[1].Text;

                Response.Redirect("ConfigurationItem_Versions.aspx");
            }
        }

        

        //static method to allow modal to access the create method
        [WebMethod]
        public static void CreateCI(string description, string category, string duedate, string status, string priority, string audience)
        {
            //create ci object and variables
            Configuration_Items ci = new Configuration_Items();
            int projid = 0;
            int userid = 0;
            int stat = 0;
            int pri = 0;
            
            Int32.TryParse(HttpContext.Current.Session["ProjectID"].ToString(), out projid);
            Int32.TryParse(HttpContext.Current.Session["UserID"].ToString(), out userid);
            Int32.TryParse(status, out stat);
            Int32.TryParse(priority, out pri);

            ci.CreateCI(projid, description, category, duedate, userid, stat, pri, audience);

        }

       
    }
}