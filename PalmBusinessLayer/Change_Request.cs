using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Brett Clark
 * January 18, 2016
 * Change Request
 * Class declaration, variable declaration   
 */

namespace PalmBusinessLayer
{
    public class Change_Request
    {
        int changeRequestID;
        int userID;    
        int version;

        string title;
        string details;
        string benefits;
        string alternatives;

        string priority;
        string status;
        string dueDate;
        string reviewDate;
        
        decimal financeImpact;
        string scheduleImpact;
        string resourceRequired;
        string impactSummary;

        int changeType;


        //Getters & Setters
        public int ChangeRequestID
        {
            get { return changeRequestID; }
            set { changeRequestID = value; }
        }
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public int Version
        {
            get { return version; }
            set { version = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Details
        {
            get { return details; }
            set { details = value; }
        }
        public string Benefits
        {
            get { return benefits; }
            set { benefits = value; }
        }
        public string Alternatives
        {
            get { return alternatives; }
            set { alternatives = value; }
        }
        public string Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        public string ReviewDate
        {
            get { return reviewDate; }
            set { reviewDate = value; }
        }
        public decimal FinanceImpact
        {
            get { return financeImpact; }
            set { financeImpact = value; }
        }
        public string ScheduleImpact
        {
            get { return scheduleImpact; }
            set { scheduleImpact = value; }
        }
        public string ResourceRequired
        {
            get { return resourceRequired; }
            set { resourceRequired = value; }
        }
        public string ImpactSummary
        {
            get { return impactSummary; }
            set { impactSummary = value; }
        }
        public int ChangeType
        {
            get { return changeType; }
            set { changeType = value; }
        }
    }
}
