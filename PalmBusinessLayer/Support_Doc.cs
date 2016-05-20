using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalmBusinessLayer
{
    public class Support_Doc
    {
        private int supportDocId;

        public int SupportDocId
        {
            get { return supportDocId; }
            set { supportDocId = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string attachment;

        public string Attachment
        {
            get { return attachment; }
            set { attachment = value; }
        }
    }
}
