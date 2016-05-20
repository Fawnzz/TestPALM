using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using PalmDataLayer;
namespace PalmBusinessLayer
{
    public class ConfigurationItemsDB
    {

        public static Configuration_Items[] GetCI()
        {
            int count = 0;
            int rows = 0;

            using (SqlConnection conn = PalmDataLayer.Connection.GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("spGetLatestVersionCI", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                rows = GetCount();

                Configuration_Items[] CI = new Configuration_Items[rows];

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        CI[count++] = new Configuration_Items(rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5), rdr.GetString(6), rdr.GetString(7), rdr.GetString(8), rdr.GetString(9));
                    }
                }
                return CI;
            }
            
        }

        public static int GetCount()
        {


            int rows = 0;
            using (SqlConnection conn = PalmDataLayer.Connection.GetConnection())
            {


                conn.Open();


                SqlCommand total = new SqlCommand("CountCI", conn);
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


                SqlCommand total = new SqlCommand("CountLowCI", conn);
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


                SqlCommand total = new SqlCommand("CountMediumCI", conn);
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


                SqlCommand total = new SqlCommand("CountHighCI", conn);
                total.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr2 = total.ExecuteReader();
                rdr2.Read();
                rows = rdr2.GetInt32(0);

                return rows;
            }



        }

        public void createCI(Configuration_Items ci)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "spCreateCI";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@ProjectID", ci.Projectid);
                cmd.Parameters.AddWithValue("@Description", ci.Description);
                cmd.Parameters.AddWithValue("@Category", ci.Category);
                cmd.Parameters.AddWithValue("@DueDate", ci.Duedate);
                cmd.Parameters.AddWithValue("@User", ci.User);
                cmd.Parameters.AddWithValue("@Status", ci.Status);
                cmd.Parameters.AddWithValue("@Priority", ci.Priority);
                cmd.Parameters.AddWithValue("@Audience", ci.Audience); 

                int rowseffected = 0;

                con.Open();
                rowseffected = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void editCI(Configuration_Items ci)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "spEditCI";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@ciid", ci.Ciid);
                cmd.Parameters.AddWithValue("@description", ci.Description);
                cmd.Parameters.AddWithValue("@category", ci.Category);
                cmd.Parameters.AddWithValue("@userid", ci.User);
                cmd.Parameters.AddWithValue("@duedate", ci.Duedate);
                cmd.Parameters.AddWithValue("@version", ci.Version);
                cmd.Parameters.AddWithValue("@status", ci.Status);
                cmd.Parameters.AddWithValue("@priority", ci.Priority);
                cmd.Parameters.AddWithValue("@audience", ci.Audience);

                int rowseffected = 0;

                con.Open();
                rowseffected = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void addComment(Configuration_Items ci)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "spCreateCIComment";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@comment", ci.Comment);
                cmd.Parameters.AddWithValue("@ciid", ci.Ciid);
                cmd.Parameters.AddWithValue("@version", ci.Version);
                cmd.Parameters.AddWithValue("@userid", ci.User);

                int rowseffected = 0;

                con.Open();
                rowseffected = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void disableCI(Configuration_Items ci)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "spDisableCI";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@ciid", ci.Ciid);

                int rowseffected = 0;

                con.Open();
                rowseffected = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void reviewCI(Configuration_Items ci)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "spReviewCI";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@ciid", ci.Ciid);

                int rowseffected = 0;

                con.Open();
                rowseffected = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void activateCI(Configuration_Items ci)
        {
            try
            {
                SqlConnection con = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "spReactivateCI";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@ciid", ci.Ciid);

                int rowseffected = 0;

                con.Open();
                rowseffected = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
