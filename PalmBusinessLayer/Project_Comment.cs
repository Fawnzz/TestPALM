using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalmBusinessLayer
{
    class Project_Comment
    {
        private String id;
        private String type;
        private Object Commentable;
        private String comment;
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
        public void setType(String type)
        {
            //sets the given id to the class type
            this.type = type;

        }
        public String getType()
        {
            //public method to return the class type
            return type;
        }
        public void setCommentable(Object Commentable)
        {
            //sets the given Commentable to the class Commentable
            this.Commentable = Commentable;

        }
        public Object getCommentable()
        {
            //public method to return the class Commentable
            return Commentable;
        }
        public void setComment(String comment)
        {
            //sets the given comment to the class comment
            this.comment = comment;

        }
        public String getComment()
        {
            //public method to return the class comment
            return comment;
        }


        Project_Comment(String id, String type, Object Commentable, String comment)
        {
            this.setId(id);
            this.setType(type);
            this.setCommentable(Commentable);
            this.setComment(comment);

        }
    }
}
