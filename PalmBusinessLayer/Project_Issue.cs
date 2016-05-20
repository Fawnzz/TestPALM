using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalmBusinessLayer
{
    class Project_Issue
    {
        private String id;
        private String project;
        private String status;
        private DateTime assignedUser;
        private String description;
        private String type;
        private String visible;

        public void setId(String id){
        //sets the given id to the class id
            this.id = id;
        
        }
        public String getId(){
        //public method to return the class id
            return id;
        }
        public void setProject(String project){
        //sets the given project to the class project
            this.project = project;
        
        }
        public String getProject(){
        //public method to return the class project
            return project;
        }
        public void setStatus(String status){
        //sets the given status to the class status
            this.status = status;
        
        }
        public String getStatus(){
        //public method to return the class status
            return status;
        }
        public void setassignedUser(DateTime assignedUser){
        //sets the given assignedUser to the class assignedUser
            this.assignedUser = assignedUser;
        
        }
        public DateTime getassignedUser(){
        //public method to return the class assignedUser
            return assignedUser;
        }
        public void setDescription(String description){
        //sets the given status to the class description
            this.description = description;
        
        }
        public String getDescription(){
        //public method to return the class description
            return description;
        }
        public void setType(String type){
        //sets the given type to the class type
            this.type = type;
        
        }
        public String getType(){
        //public method to return the class type
            return type;
        }
        public void setVisible(String visible){
        //sets the given visible to the class visible
            this.visible = visible;
        
        }
        public String getVisible(){
        //public method to return the class visible
            return visible;
        }
        Project_Issue()
        {

        }
        Project_Issue(String id, String project, String status, DateTime assignedUser, String description, String type, String visible)
        {
            this.setId(id);
            this.setProject(project);
            this.setStatus(status);
            this.setassignedUser(assignedUser);
            this.setDescription(description);
            this.setType(type);
            this.setVisible(visible);
        }
        public bool validateUser(String user){
            return true;
        }
        public void Export(){
        //Export to document
        }
    }

}
