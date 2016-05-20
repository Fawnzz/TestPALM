using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalmBusinessLayer
{
   public class Issue

    {
        private int audience;

        public int Audience
        {
            get { return audience; }
            set { audience = value; }
        }

        private string version;

        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        private string previous_version;

        public string Previous_version
        {
            get { return previous_version; }
            set { previous_version = value; }
        }
        
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string projectid;

        public string Projectid
        {
            get { return projectid; }
            set { projectid = value; }
        }
        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        private int priority;

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        private string assigneduserid;

        public string Assigneduserid
        {
            get { return assigneduserid; }
            set { assigneduserid = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string visibility;

        public string Visibility
        {
            get { return visibility; }
            set { visibility = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Issue(string id, string projectid, int status, int priority, string assigneduserid, string name, string description, string type, int audience, string version, string previous_version)
        {
            this.Name = name;
            this.Id = id;
            this.Projectid = projectid;
            this.Status = status;
            this.Priority = priority;
            this.Assigneduserid = assigneduserid;
            this.Description = description;
            this.Type = type;
            this.Audience = audience;
            this.Version = version;
            this.Previous_version = previous_version;

        
        
        }


    }
}
