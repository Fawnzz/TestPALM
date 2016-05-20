using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalmBusinessLayer
{
    class Likelihood
    {
        private int likelihoodID;

        public int LikelihoodID
        {
            get { return likelihoodID; }
            set { likelihoodID = value; }
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

        public Likelihood(int LikelihoodID, int Value, string Desc)
        {
            this.LikelihoodID = likelihoodID;
            this.Value = value;
            this.Desc = desc; 
        }
    }
}
