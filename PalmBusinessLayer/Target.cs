using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalmBusinessLayer
{
    class Target
    {
        private String id;
        private String name;
        private String description;
        private String status;
        private String project;

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
        public void setProject(String project)
        {
            //sets the given project to the class project
            this.project = project;

        }
        public String getProject()
        {
            //public method to return the class project
            return project;
        }
        Target(String id, String name, String description, String status, String project){
            this.setId(id);
            this.setName(name);
            this.setDescription(description);
            this.setStatus(status);
            this.setProject(project);
        }
        public bool validateUser(String user)
        {
            return true;
        }
        public void AddToListbox(string sql)
        {

        }
    }
}
