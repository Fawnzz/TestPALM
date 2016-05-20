using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalmBusinessLayer
{
    public class Bugs
    {
        private int bugID;

        public int BugID
        {
            get { return bugID; }
            set { bugID = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
