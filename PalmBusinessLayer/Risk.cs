using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PalmDataLayer;

namespace PalmBusinessLayer
{
    public class Risk
    {
       
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        int status_id;
        public int Status_id
        {
            get { return status_id; }
            set { status_id = value; }
        }

        DateTime closing_date;

        public DateTime Closing_date
        {
            get { return closing_date; }
            set { closing_date = value; }
        }

      

        string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        string mitigation;

        public string Mitigation
        {
            get { return mitigation; }
            set { mitigation = value; }
        }
        public int risk_orginal_id;

        public int Risk_orginal_id
        {
            get { return risk_orginal_id; }
            set { risk_orginal_id = value; }
        }

        int response_id;

        public int Response_id
        {
            get { return response_id; }
            set { response_id = value; }
        }

     
        int user_id;

        public int User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }
        string sch_likelihood;

        public string Sch_likelihood
        {
            get { return sch_likelihood; }
            set { sch_likelihood = value; }
        }
        string sch_impact;

        public string Sch_impact
        {
            get { return sch_impact; }
            set { sch_impact = value; }
        }
        string cost_likelihood;

        public string Cost_likelihood
        {
            get { return cost_likelihood; }
            set { cost_likelihood = value; }
        }
        string cost_impact;

        public string Cost_impact
        {
            get { return cost_impact; }
            set { cost_impact = value; }
        }
        string qty_likelihood;

        public string Qty_likelihood
        {
            get { return qty_likelihood; }
            set { qty_likelihood = value; }
        }
        string qty_impact;

        public string Qty_impact
        {
            get { return qty_impact; }
            set { qty_impact = value; }
        }
        private int calculate;

        public int Calculate
        {
            get { return calculate; }
            set { calculate = value; }
        }

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        string value;

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        //calculate variables 
        int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
       

        int total;

        public int Total
        {
            get { return total; }
            set { total = value; }
        }

        int priority_id;

        public int Priority_id
        {
            get { return priority_id; }
            set { priority_id = value; }
        }

       string userClient;

        public string UserClient
        {
            get { return userClient; }
            set { userClient = value; }
        }

        int priority;

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }
       public DataSet Select_Query()
        {
            Risk_RiskDB rb = new Risk_RiskDB(); 
            return rb.Select_Risks(); 
        }

        public void Insert_Query(Risk myRisk)
       {
           Risk_RiskDB rb = new Risk_RiskDB();
           rb.Insert_Risk(myRisk);
          
       }

        public void Update_Query(Risk myRisk)
        {
            Risk_RiskDB rb = new Risk_RiskDB();
            rb.Update_Risk(myRisk);
        }

        public void Delete_Query(int id)
        {
            Risk_RiskDB rb = new Risk_RiskDB();
            rb.Delete_Risk(id);
        }

        int calTotal;

        public int CalTotal
        {
            get { return calTotal; }
            set { calTotal = value; }
        }
       
    }
}