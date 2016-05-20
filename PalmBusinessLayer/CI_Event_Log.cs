using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalmBusinessLayer
{
    class CI_Event_Log
    {

        string changedItemId;
        DateTime timeStamp;
        int projectId;
        int userId;
        string previousVersion;


        public string ChangedItemId
        {
            get { return changedItemId; }
            set { changedItemId = value; }
        }
        
        public DateTime TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }

        public int ProjectId
        {
            get { return projectId; }
            set { projectId = value; }
        }

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public string PreviousVersion
        {
            get { return previousVersion; }
            set { previousVersion = value; }
        }

        //functions still need to be created
        public void CreateCIEvent()
        {
            //create configuration item event
        }

        public void ViewCIEvent()
        {
            //view configuration item event
        }

        public void SearchCIEvent()
        {
            //search configuration item event
        }

    }
}
