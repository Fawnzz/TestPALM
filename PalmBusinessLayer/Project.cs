using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalmDataLayer;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace PalmBusinessLayer
{
    class Project
    {
        private String id;
        private String name;
        private String description;
        private DateTime startDate;
        private String status;
        private String visible;
        private String client;

        public void setId(String id)
        {
            //sets the given id to the class id
            this.id = id;

        }
        public String getId()
        {
            //public method to return the class id
            return id;
        }
        public void setName(String name)
        {
            //sets the given name to the class name
            this.name = name;

        }
        public String getName()
        {
            //public method to return the class name
            return name;
        }
        public void setDescription(String description)
        {
            //sets the given description to the class description
            this.description = description;

        }
        public String getDescription()
        {
            //public method to return the class description
            return description;
        }
        public void setStartDate(DateTime startDate)
        {
            //sets the given startDate to the class startDate
            this.startDate = startDate;

        }
        public DateTime getStartDate()
        {
            //public method to return the class startDate
            return startDate;
        }
        public void setStatus(String status)
        {
            //sets the given status to the class status
            this.status = status;

        }
        public String getStatus()
        {
            //public method to return the class status
            return status;
        }
        public void setVisible(String visible)
        {
            //sets the given visible to the class visible
            this.visible = visible;

        }
        public String getVisible()
        {
            //public method to return the class visible
            return visible;
        }
        public void setClient(String client)
        {
            //sets the given client to the class client
            this.client = client;

        }
        public String getClient()
        {
            //public method to return the class client
            return client;
        }
        Project()
        {

        }
        Project(String id, String name, String description, DateTime startDate, String status, String visible, String client)
        {
            this.setId(id);
            this.setName(name);
            this.setDescription(description);
            this.setStartDate(startDate);
            this.setStatus(status);
            this.setVisible(visible);
            this.setClient(client);
        }
        public bool validateUser(String user)
        {
            return true;
        }
        public void Export()
        {
            //Export to document
        }
       

    }
}
