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
using System.Windows;




namespace PalmBusinessLayer
{
    public class QA_Event
    {
        private int qaID;

        public int QaID
        {
            get { return qaID; }
            set { qaID = value; }
        }
        private int userID;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        private int projectID;

        public int ProjectID
        {
            get { return projectID; }
            set { projectID = value; }
        }
        private DateTime timestamp;


        public DateTime Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private string priority;

        public string Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        private int moduleId;

        public int ModuleId
        {
            get { return moduleId; }
            set { moduleId = value; }
        }
        private int testPlanId;

        public int TestPlanId
        {
            get { return testPlanId; }
            set { testPlanId = value; }
        }
        private int supportDocId;

        public int SupportDocId
        {
            get { return supportDocId; }
            set { supportDocId = value; }
        }
        private string visible;

        public string Visible
        {
            get { return visible; }
            set { visible = value; }
        }

        public void QAEvent(int qaid, int userid, int projectid, DateTime timestamp, string status, string priority, int moduleid, int testplanid, int supportdocid, string visible)
        {
       
            QA_Event qa = new QA_Event();

            // creates object to get Connection
         

            // creates object to get Connection
            //QABL qa = new QABL();


            this.QaID = qaid;
            this.UserID = userid;
            this.ProjectID = projectid;
            this.Timestamp = timestamp;
            this.Status = status;
            this.Priority = priority;
            this.ModuleId = moduleid;
            this.TestPlanId = testplanid;
            this.SupportDocId = supportdocid;
            this.Visible = visible;

            //qa.createQAEvent(this);
        }

        public void QAEvent2()
        {

            //QA_Event qa = new QA_Event();
      

     //       qa.viewQAEvent(this);

        }



        //*****************************************FUNCTIONS FOR STORED PROCEDURE****************************************************//
        
        
        //Create QA Event Stored Procedure
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

        public void viewQAEvent(QA_Event myQA)
        {

            StringBuilder table = new StringBuilder();

           QA_Event qa = new QA_Event();
            try
            {
                SqlConnection myConnection = Connection.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "View";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = myConnection;

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
              //  DataTable dbdataset = new DataTable();
               //sda.Fill(dbdataset);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    table.Append("<table border='1'>");
                    table.Append("<tr><th>ID</th><th>ID2</th>");
                    table.Append("</tr>");

                    while (rdr.Read())
                    {
                        table.Append("<tr>");
                        table.Append("<td>" + rdr[0] + "</td>");
                        table.Append("<td>" + rdr[1] + "</td>");
                        table.Append("/tr>");

                    }
                }
               

            }

            catch (Exception ex)
            {
                throw ex;
            }
        
        }

    

    }
}
