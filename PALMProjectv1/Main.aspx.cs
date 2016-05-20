using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PalmBusinessLayer;

namespace Palm
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // my four objects
            Bugs bugObject = new Bugs();
            Test_Plan testplanObject = new Test_Plan();
            QA_Event qaEventObject = new QA_Event();
            PalmBusinessLayer.Support_Doc supportDocObject = new PalmBusinessLayer.Support_Doc();
        }
    }
}