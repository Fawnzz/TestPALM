using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalmBusinessLayer
{
    public class Configuration_Items
    {

        private string sciid;
        public string Sciid
        {
            get { return sciid; }
            set { sciid = value; }
        }

        private int ciid;

        public int Ciid
        {
            get { return ciid; }
            set { ciid = value; }
        }

        private int projectid;

        public int Projectid
        {
            get { return projectid; }
            set { projectid = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private string duedate;

        public string Duedate
        {
            get { return duedate; }
            set { duedate = value; }
        }

        private string sversion;

        public string Sversion
        {
            get { return sversion; }
            set { sversion = value; }
        }

        private int version;

        public int Version
        {
            get { return version; }
            set { version = value; }
        }

        private string suser;

        public string Suser
        {
            get { return suser; }
            set { suser = value; }
        }

        private int user;

        public int User
        {
            get { return user; }
            set { user = value; }
        }

        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private string sstatus;

        public string SStatus
        {
            get { return sstatus; }
            set { sstatus = value; }
        }


        private int priority;

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        private string spriority;

        public string SPriority
        {
            get { return spriority; }
            set { spriority = value; }
        }

        private string reviewed;

        public string Reviewed
        {
            get { return reviewed; }
            set { reviewed = value; }
        }

        private string testedclient;

        private string audience;

        public string Audience
        {
            get { return audience; }
            set { audience = value; }
        }

        private string visible;

        public string Visible
        {
            get { return visible; }
            set { visible = value; }
        }

        private string comment;

public string Comment
{
  get { return comment; }
  set { comment = value; }
}

        //constructor without arguments
        public Configuration_Items()
        {
            
        }

        //constructor with arguments using all strings
        public Configuration_Items(string ciid, string description, string category, string duedate, string user, string status, string priority, string reviewed, string audience, string version)
        {
            this.Sciid = ciid;
            this.Description = description;
            this.Category = category;
            this.Duedate = duedate;
            this.Sversion = version;
            this.Suser = user;
            this.SStatus = status;
            this.SPriority = priority;
            this.Reviewed = reviewed;
            this.Audience = audience;
        }

        public void CreateCI(int projectid, string description, string category, string duedate, int user, int status, int priority, string audience)
        {
            ConfigurationItemsDB ci = new ConfigurationItemsDB();

            this.projectid = projectid;
            this.description = description;
            this.category = category;
            this.duedate = duedate;
            this.user = user;
            this.status = status;
            this.priority = priority;
            this.audience = audience;

            ci.createCI(this);

        }

        public void EditCI(int ciid, string description, string category, int userid, string duedate, int version, int status, int priority, string audience)
        {
            ConfigurationItemsDB ci = new ConfigurationItemsDB();

            this.ciid = ciid;
            this.description = description;
            this.category = category;
            this.user = userid;
            this.duedate = duedate;
            this.version = version;
            this.status = status;
            this.priority = priority;
            this.audience = audience;

            ci.editCI(this);
        }

        public void DisableCI(int ciid)
        {
            ConfigurationItemsDB ci = new ConfigurationItemsDB();

            this.ciid = ciid;

            ci.disableCI(this);
        }

        public void ReviewCI(int ciid)
        {
            ConfigurationItemsDB ci = new ConfigurationItemsDB();
            
            this.ciid = ciid;

            ci.reviewCI(this);
        }

        public void ActivateCI(int ciid)
        {
            ConfigurationItemsDB ci = new ConfigurationItemsDB();

            this.ciid = ciid;

            ci.activateCI(this);
        }

        public void AddComment(int ciid, int version, int userid, string comment)
        {
            ConfigurationItemsDB ci = new ConfigurationItemsDB();

            this.ciid = ciid;
            this.version = version;
            this.user = userid;
            this.comment = comment;

            ci.addComment(this);
        }

        public void ViewCI()
        {
            //View configuration Item -- wont use shouldnt use VOID
        }

        public void CreateCIComment()
        {
            //create configuration item comment
        }
    }
}
