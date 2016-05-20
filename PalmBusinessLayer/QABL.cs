using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalmDataLayer;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;

namespace PalmBusinessLayer
{
    class QABL
    {
        //create QA event
        public void createQAEvent(QA_Event myQA)
        {
            try
            {
                SqlConnection myConnection = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "CreateQAEvent";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = myConnection;

                //this populates database
                cmd.Parameters.AddWithValue("@QAID", myQA.QaID);
                cmd.Parameters.AddWithValue("UserID", myQA.UserID);
                cmd.Parameters.AddWithValue("ProjectID", myQA.ProjectID);
                cmd.Parameters.AddWithValue("Timestamp", myQA.Timestamp);
                cmd.Parameters.AddWithValue("Status", myQA.Status);
                cmd.Parameters.AddWithValue("Priority", myQA.Priority);
                cmd.Parameters.AddWithValue("ModuleID", myQA.ModuleId);
                cmd.Parameters.AddWithValue("TestPlanID", myQA.TestPlanId);
                cmd.Parameters.AddWithValue("SupportDocID", myQA.SupportDocId);
                cmd.Parameters.AddWithValue("Visible", myQA.Visible);

                int rowsEffected = 0;

                myConnection.Open();
                rowsEffected = cmd.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //view QA event
        public int viewQAEvent(QA_Event myQA) 
        {
            SqlConnection myConnection = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ViewQAEvent";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = myConnection;

            cmd.Parameters.AddWithValue("@QAID", myQA.QaID);

            myConnection.Open();

            int output = Convert.ToInt32(cmd.ExecuteScalar());

            myConnection.Close();

            return output;

        }




    }
}
