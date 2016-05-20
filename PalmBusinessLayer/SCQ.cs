using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalmBusinessLayer
{
    class SCQ
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int impactID;

        public int ImpactID
        {
            get { return impactID; }
            set { impactID = value; }
        }
        private int likelihoodID;

        public int LikelihoodID
        {
            get { return likelihoodID; }
            set { likelihoodID = value; }
        }
        private int riskID;

        public int RiskID
        {
            get { return riskID; }
            set { riskID = value; }
        }

        public SCQ (int RiskID, int ImpactID, int LikelihoodID, int Id)
        {
            this.RiskID = riskID;
            this.LikelihoodID = likelihoodID;
            this.ImpactID = impactID;
            this.Id = id;
        }
    }
}
