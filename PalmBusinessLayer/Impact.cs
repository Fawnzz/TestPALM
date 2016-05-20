using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalmBusinessLayer
{
    class Impact
    {
        private int impactID;

        public int ImpactID
        {
            get { return impactID; }
            set { impactID = value; }
        }
        private int value;

        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        private string desc;

        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }

        public Impact (int ImpactID, int Value, int Desc)
        {
            this.ImpactID = impactID;
            this.Value = value;
            this.Desc = desc; 
        }
    }
}
