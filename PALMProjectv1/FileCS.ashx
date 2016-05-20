<%@ WebHandler Language="C#" Class="FileCS" %>

using System;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public class FileCS : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        // string id = context.Request.QueryString["id"];
       // int id = int.Parse(context.Request.QueryString["id"]);
       int id = int.Parse(context.Request.QueryString["id"]);
       
           //var id = ((LinkButton)sender).CommandArgument;
           byte[] bytes;
           string fileName, contentType;
           //fileName = context.Server.MapPath("~/" + context.Request.QueryString["id"]);
       
        //masterConnectionString or PALMConnectionString6 - > change to use function GetConnection();
        //string constr = ConfigurationManager.ConnectionStrings["PALMConnectionString6"].ConnectionString;
           using (SqlConnection con = PalmDataLayer.Connection.GetConnection())
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                //cmd.CommandText = "SELECT Name, Data, ContentType FROM tblFiles1 WHERE id = @id";
                //cmd.Parameters.AddWithValue("@id", id);

               // cmd.CommandText = "SELECT ContentType, Attachment FROM Support_Doc WHERE SupportDocID = @SupportDocID";
                cmd.CommandText = "SELECT Type, Attachment FROM Support_Doc WHERE SupportDocID = @SupportDocID";
                cmd.Parameters.AddWithValue("@SupportDocID", id);
                cmd.Connection = con;
                con.Open();
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                   
                    while (sdr.Read())
                    {

                        sdr.Read();
                        // bytes = (byte[])sdr["Data"];
                        //contentType = sdr["SupportDoc"].ToString();
                        //fileName = sdr["Name"].ToString();
                        //com.Parameters.AddWithValue("@SupportDoc", filename1);
                        //com.Parameters.AddWithValue("@Name", type);
                        //com.Parameters.AddWithValue("@Data", bytes);


                       // bytes = (byte[])sdr["Data"];
                        //contentType = sdr["ContentType"].ToString();
                        //fileName = sdr["Name"].ToString();

                       
                        bytes = (byte[])sdr["Attachment"];
                        contentType = sdr["Name"].ToString();
                        fileName = sdr["Type"].ToString();
                        
                        context.Response.Clear();
                        context.Response.ClearHeaders();
                        context.Response.ClearContent();
                        
                        
                        context.Response.Buffer = true;
                      // context.Response.Charset = "";
                        //if (context.Request.QueryString["download"] == "1")
                        //{
                            context.Response.AppendHeader("Content-Disposition", "attachment;filename=" + fileName);
                            context.Response.AddHeader("Content-Length", bytes.Length.ToString());
                            context.Response.Cache.SetCacheability(HttpCacheability.NoCache);
                            context.Response.ContentType = "application/pdf";
                            context.Response.AddHeader("Accept-Ranges", "bytes");
                            context.Response.BinaryWrite(bytes);
                            context.Response.Flush();
                           // context.Response.Close();
                            //context.Response.End();
                            try
                            {
                                context.Response.End();
                            }
                            catch (Exception e) 
                            {
                            
                            }
                       // }
                       // context.Response.End();
                    }
                    //con.Close();
                }
                con.Close();
            }


        }
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }
}