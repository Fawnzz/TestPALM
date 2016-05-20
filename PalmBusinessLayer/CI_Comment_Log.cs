using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalmBusinessLayer
{
    class CI_Comment_Log
    {

        private int ciid;
        private int commentId;
        private int userId;
        private int configurationItemId;
        private DateTime timeStamp;
        private string comment;

        public int Ciid
        {
            get { return ciid; }
            set { ciid = value; }
        }

        public int CommentId
        {
            get { return commentId; }
            set { commentId = value; }
        }

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public int ConfigurationItemId
        {
            get { return configurationItemId; }
            set { configurationItemId = value; }
        }

        public DateTime TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }


        //functions still need to be created
        public void AddLogItem()
        {
            //add log item -- not void
        }

        public void SearchLog()
        {
            //search comment log
        }

        public void ViewLog()
        {
            //view comment log
        }

        public void PrintLog()
        {
            //print comment log
        }

    }
}
