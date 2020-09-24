using System;
using System.Collections.Generic;
using System.Text;

namespace Soda_Machine
{
    class Backpack
    {
        public List<Can> cansInBackPack; 
        
        public Backpack()
        {
            OrangeSoda orangeSodaSelected = new OrangeSoda();
            Cola cocaColaSelected = new Cola();
            RootBeer rootBeerSelected = new RootBeer();

            cansInBackPack = new List<Can>(); 

        }
    
    }
        
}
