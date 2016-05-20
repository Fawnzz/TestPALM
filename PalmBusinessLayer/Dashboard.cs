using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Brett Clark
 * January 18, 2016
 * Change Request
 * Class declaration, variable declaration 
 * Function declaration
 */

namespace PalmBusinessLayer
{
    public class Dashboard
    {
        public void RequestChangeRequest()
        {

        }
        public void RequestChangeRequestForm()
        {

        }
        public void DeleteChangeRequest()
        {

        }

        string loggedOnRole;
        int loggedOnUserID;

        public string LoggedOnRole
        {
            get { return loggedOnRole; }
            set { loggedOnRole = value; }
        }
        public int LoggedOnUserID
        {
            get { return loggedOnUserID; }
            set { loggedOnUserID = value; }
        }
    }
}
