using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalmBusinessLayer
{
    public class Test_Plan
    {
        private int testPlanId;

        public int TestPlanId
        {
            get { return testPlanId; }
            set { testPlanId = value; }
        }
        private int qaId;

        public int QaId
        {
            get { return qaId; }
            set { qaId = value; }
        }
        private int bugId;

        public int BugId
        {
            get { return bugId; }
            set { bugId = value; }
        }
        private string comments;

        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private int supportDocType;

        public int SupportDocType
        {
            get { return supportDocType; }
            set { supportDocType = value; }
        }
    }
}
