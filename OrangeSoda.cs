using System;
using System.Collections.Generic;
using System.Text;

namespace Soda_Machine
{
    class OrangeSoda : Can
    {
        
        public OrangeSoda()
        { 
            name = "Orange Soda";

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
