using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using PalmDataLayer;
using System.Data;
namespace PalmBusinessLayer
{
    public class IssuesDB
    {

        public static Issue[] GetIssues()
        {
            
        int count = 0;
        int rows = 0;    
            using (SqlConnection conn = PalmDataLayer.Connection.GetConnection())
            {


               
                
                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("GetIssues", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();


                rows = GetCount();
               
                Issue[] Issues = new Issue[rows];
                // execute the command
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    
                    
                    
                    while (rdr.Read())
                    {
                       
                        Issues[count++] = new Issue(rdr.GetString(0), rdr.GetString(1), rdr.GetInt32(2), rdr.GetInt32(3), rdr.GetString(4), rdr.GetString(5), rdr.GetString(6), rdr.GetString(7), rdr.GetInt32(8), rdr.GetString(9), rdr.GetString(10));
                        
                    }
                    
                }
                return Issues;
            }



        }
        public static int DeleteIssue(string issueid) {


            using (SqlConnection conn = PalmDataLayer.Connection.GetConnection())
            {



                
                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("DeleteIssue", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteIssue";
                cmd.Parameters.AddWithValue("@ID", int.Parse(issueid));
                conn.Open();


               
                // execute the command

                return cmd.ExecuteNonQuery();
                
            }





        }
        public static int EditIssue(string projectid,string status,string priority,string user,string name,string description,string type,string audience,string version,string previous_version)
        {


            using (SqlConnection conn = PalmDataLayer.Connection.GetConnection())
            {




                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("EditIssue", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EditIssue";
                cmd.Parameters.AddWithValue("@projectid", int.Parse(projectid));
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@priority", priority);
                cmd.Parameters.AddWithValue("@userid", int.Parse(user));
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@audience", audience);
                cmd.Parameters.AddWithValue("@version", int.Parse(version));
                cmd.Parameters.AddWithValue("@previous_version", int.Parse(previous_version));
                conn.Open();


             return   cmd.ExecuteNonQuery();
                // execute the command

                
            }
        }

        public static int CreateIssue( string projectid, string status, string priority, string user, string name, string description, string type, string audience, string version, string previous_version)
        {


            using (SqlConnection conn = PalmDataLayer.Connection.GetConnection())
            {




                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("EditIssue", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CreateIssue";
                cmd.Parameters.AddWithValue("@projectid", int.Parse(projectid));
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@priority", priority);
                cmd.Parameters.AddWithValue("@userid", int.Parse(user));
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@audience", audience);
                cmd.Parameters.AddWithValue("@version", int.Parse(version));
                cmd.Parameters.AddWithValue("@previous_version", int.Parse(previous_version));
                conn.Open();



                // execute the command

                return cmd.ExecuteNonQuery();
            }
        }

        public static int GetCount()
        {


            int rows = 0;
            using (SqlConnection conn = PalmDataLayer.Connection.GetConnection())
            {


                conn.Open();


                SqlCommand total = new SqlCommand("CountIssues", conn);
                total.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr2 = total.ExecuteReader();
                rdr2.Read();
                rows = rdr2.GetInt32(0);

                return rows;
            }
        }


             public static int GetLow()
        {

           
            int rows = 0;
            using (SqlConnection conn = PalmDataLayer.Connection.GetConnection())
            {


                conn.Open();


                SqlCommand total = new SqlCommand("CountLow", conn);
                total.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr2 = total.ExecuteReader();
                rdr2.Read();
                rows = rdr2.GetInt32(0);

                return rows;
            }



        }
             public static int GetMedium()
             {


                 int rows = 0;
                 using (SqlConnection conn = PalmDataLayer.Connection.GetConnection())
                 {


                     conn.Open();


                     SqlCommand total = new SqlCommand("CountMedium", conn);
                     total.CommandType = CommandType.StoredProcedure;
                     SqlDataReader rdr2 = total.ExecuteReader();
                     rdr2.Read();
                     rows = rdr2.GetInt32(0);

                     return rows;
                 }



             }
             public static int GetHigh()
             {


                 int rows = 0;
                 using (SqlConnection conn = PalmDataLayer.Connection.GetConnection())
                 {


                     conn.Open();


                     SqlCommand total = new SqlCommand("CountHigh", conn);
                     total.CommandType = CommandType.StoredProcedure;
                     SqlDataReader rdr2 = total.ExecuteReader();
                     rdr2.Read();
                     rows = rdr2.GetInt32(0);

                     return rows;
                 }



             }
     



    }




        










    }


