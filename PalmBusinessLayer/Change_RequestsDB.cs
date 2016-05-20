using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using PalmDataLayer;

namespace PalmBusinessLayer
{
    public class Change_RequestsDB
    {
        public static List<Change_Request> GetChangeRequest()
        {
            List<Change_Request> myChangeRequest = new List<Change_Request> { };
            SqlConnection conn = Connection.GetConnection();
            SqlCommand comm = new SqlCommand("SP_HomeView_CR", conn);
            comm.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                Change_Request cr;

                while (reader.Read())
                {
                    cr = new Change_Request();

                    cr.ChangeRequestID = reader.GetInt32(0);
                    //cr.UserID = reader.GetInt32(1);
                    cr.Title = reader.GetString(2);
                    cr.Priority = reader.GetString(3);
                    cr.Status = reader.GetString(4);

                    myChangeRequest.Add(cr);
                }
                reader.Close();
            }
            catch (System.IO.IOException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return myChangeRequest;
        }
        public static int NewChangeRequest(Change_Request myChangeRequest)
        {
            int ChangeRequestID;
            SqlConnection conn = Connection.GetConnection();
            SqlCommand comm = new SqlCommand("SP_Create_CR", conn);

            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.AddWithValue("@title", myChangeRequest.Title);
            comm.Parameters.AddWithValue("@priority", myChangeRequest.Priority);
            comm.Parameters.AddWithValue("@status", myChangeRequest.Status);
            comm.Parameters.AddWithValue("@details", myChangeRequest.Details);
            comm.Parameters.AddWithValue("@benefits", myChangeRequest.Benefits);
            comm.Parameters.AddWithValue("@alternatives", myChangeRequest.Alternatives);
            comm.Parameters.AddWithValue("@due_by", myChangeRequest.DueDate).ToString();
            comm.Parameters.AddWithValue("@review_by", myChangeRequest.ReviewDate).ToString();
            comm.Parameters.AddWithValue("@financial_impact", myChangeRequest.FinanceImpact);
            comm.Parameters.AddWithValue("@impact_summary", myChangeRequest.ImpactSummary);
            comm.Parameters.AddWithValue("@resources_required", myChangeRequest.ResourceRequired);
            comm.Parameters.AddWithValue("@schedule_impact", myChangeRequest.ScheduleImpact);
            comm.Parameters.AddWithValue("@type", myChangeRequest.ChangeType);

            try
            {
                conn.Open();
                ChangeRequestID = comm.ExecuteNonQuery();
            }
            catch (System.IO.IOException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

            return ChangeRequestID;
        }
        public static Change_Request ViewChangeRequest(int changeRequestID)
        {
            Change_Request myChangeRequest = new Change_Request();
            SqlConnection conn = Connection.GetConnection();
            SqlCommand comm = new SqlCommand("SP_View_CR", conn);
            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.AddWithValue("@changeRequestID", changeRequestID);

            try
            {           
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read())
                {
                    myChangeRequest.Title = reader.GetString(0);
                    myChangeRequest.Details = reader.GetString(3);
                    myChangeRequest.Benefits = reader.GetString(4);
                    myChangeRequest.Alternatives = reader.GetString(5);

                    myChangeRequest.Priority = reader.GetString(1);
                    myChangeRequest.Status = reader.GetString(2);
                    myChangeRequest.DueDate = reader.GetString(6);
                    myChangeRequest.ReviewDate = reader.GetString(7);

                    myChangeRequest.FinanceImpact = reader.GetDecimal(8);                   
                    myChangeRequest.ScheduleImpact = reader.GetString(11);
                    myChangeRequest.ResourceRequired = reader.GetString(10);
                    myChangeRequest.ImpactSummary = reader.GetString(9);

                    myChangeRequest.ChangeType = reader.GetInt32(12);
                }
            }
            catch (System.IO.IOException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return myChangeRequest;
        }        
        public static bool DeleteChangeRequest(int changeRequestID)
        {
            bool isDeleted = false;
            SqlConnection conn = Connection.GetConnection();
            SqlCommand comm = new SqlCommand("SP_Delete_CR", conn);
            comm.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Open();
            }
            catch (System.IO.IOException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return isDeleted;
        }
    }
}
