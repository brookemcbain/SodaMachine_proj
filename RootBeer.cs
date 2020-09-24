using System;
using System.Collections.Generic;
using System.Text;

namespace Soda_Machine
{
    class RootBeer : Can
    {
        
        public RootBeer()
        {
            name = "Root Beer";
            cost = .60;  
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
