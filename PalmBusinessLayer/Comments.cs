using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalmBusinessLayer
{
    class Comments
    {
        private int commentID;

        public int CommentID
        {
            get { return commentID; }
            set { commentID = value; }
        }
        private int comment;

        public int Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public Comments ( int CommentID, int Comment)
        {
            this.CommentID = commentID;
            this.Comment = comment;
        }
    }
}
