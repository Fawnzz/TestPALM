using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PalmDataLayer;
using System.Data;


namespace PalmBusinessLayer
{
    public class Risk_RiskDB
    {


        public void Insert_Risk(Risk myRisk) //insert method
        {
            SqlConnection conn = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand("spInsertRisk", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            // cmd.Parameters.AddWithValue("@id",myRisk.Id);  // first is table and second is variable
            cmd.Parameters.AddWithValue("@status_id", myRisk.Status_id);
            cmd.Parameters.AddWithValue("@closing_date", SqlDbType.DateTime).Value = Convert.ToDateTime(myRisk.Closing_date);
            cmd.Parameters.AddWithValue("@value", myRisk.Value);
            cmd.Parameters.AddWithValue("@description", myRisk.Description);
            cmd.Parameters.AddWithValue("@mitigation", myRisk.Mitigation);
            cmd.Parameters.AddWithValue("@user_id", myRisk.User_id);
            cmd.Parameters.AddWithValue("@sch_likelihood", myRisk.Sch_likelihood);
            cmd.Parameters.AddWithValue("@sch_impact", myRisk.Sch_impact);
            cmd.Parameters.AddWithValue("@cost_likelihood", myRisk.Cost_likelihood);
            cmd.Parameters.AddWithValue("@cost_impact", myRisk.Cost_impact);
            cmd.Parameters.AddWithValue("@qty_likelihood", myRisk.Qty_likelihood);
            cmd.Parameters.AddWithValue("@qty_impact", myRisk.Qty_impact);
            cmd.Parameters.AddWithValue("@comment", myRisk.Comment);
            cmd.Parameters.AddWithValue("@userClient", myRisk.UserClient);
            cmd.Parameters.AddWithValue("@priority_id", myRisk.Priority_id);
            cmd.Parameters.AddWithValue("@response_id", myRisk.Response_id);
            cmd.Parameters.AddWithValue("@risk_orginal_id", myRisk.risk_orginal_id);
            cmd.Parameters.AddWithValue("@calculate", myRisk.Calculate);


            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }



        }



        public DataSet Select_Risks()
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open(); 
           
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Risks", conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            
            return ds;

        }

        public DataTable CalcSch()
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Risks", conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            int x = Convert.ToInt32(dt.Rows[0][6].ToString()); // converting into int
            return dt; 
         
        }
        public void Update_Risk(Risk myRisk)  // my update method
        {
            Risk_RiskDB da = new Risk_RiskDB(); 
            SqlConnection conn = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand("spUpdateRisk", conn);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@status_id", myRisk.Status_id); // first is table name and second is my variable
            cmd.Parameters.AddWithValue("@closing_date", myRisk.Closing_date);
            cmd.Parameters.AddWithValue("@value", myRisk.risk_orginal_id);
            cmd.Parameters.AddWithValue("@description", myRisk.Description);
            cmd.Parameters.AddWithValue("@mitigation", myRisk.Mitigation);
            cmd.Parameters.AddWithValue("@user_id", myRisk.User_id);
            cmd.Parameters.AddWithValue("@sch_likelihood", myRisk.Sch_likelihood);
            cmd.Parameters.AddWithValue("@sch_impact", myRisk.Sch_impact);
            cmd.Parameters.AddWithValue("@cost_likelihood", myRisk.Cost_likelihood);
            cmd.Parameters.AddWithValue("@cost_impact", myRisk.Cost_impact);
            cmd.Parameters.AddWithValue("@qty_likelihood", myRisk.Qty_likelihood);
            cmd.Parameters.AddWithValue("@qty_impact", myRisk.Qty_impact);
            cmd.Parameters.AddWithValue("@comment", myRisk.Comment);
            cmd.Parameters.AddWithValue("@userClient", myRisk.UserClient);
            cmd.Parameters.AddWithValue("@priority_id", myRisk.Priority_id);
            cmd.Parameters.AddWithValue("@response_id", myRisk.Response_id);
            cmd.Parameters.AddWithValue("@risk_orginal_id", myRisk.risk_orginal_id);
            cmd.Parameters.AddWithValue("@calculate", myRisk.Calculate);
            

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }


        }

        public void Delete_Risk(int id)  // my Delete method
        {

            SqlConnection conn = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand("spDeleteRisk", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
                 
        }


        //private int calPriority(int a, int b, int c, int d, int ef, int f)
        //{
            
        //    int v1 = (a * b) + (c * d) + (ef * f);
        //    int priority;


        //    if (v1 < 100)
        //    {
        //        priority = 2;
        //    }
        //    else if (v1 > 100 && v1 < 200)
        //    {
        //        priority = 5;
        //    }
        //    else if (v1 > 100)
        //    {
        //        priority = 3;
        //    }
        //    else
        //    {
        //        priority = 0;
        //    }
        //    return priority; 
        //}
      
       
    }
   
     }



