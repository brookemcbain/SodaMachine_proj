using System;
using System.Collections.Generic;
using System.Text;

namespace Soda_Machine
{
    abstract class Can
    {
        protected double cost;
        public double Cost { get { return cost; } set { Cost = cost; } }
        public string name;


        public Can()
        {
            
        }
    }   
}
