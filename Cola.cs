using System;
using System.Collections.Generic;
using System.Text;

namespace Soda_Machine
{
    class Cola : Can
    {
        public Cola()
        {
            
            name = "Cola";
            cost = .35; 
        }
        public double Cost
        {
            get
            {
                return cost;
            }
        }
    }
}
