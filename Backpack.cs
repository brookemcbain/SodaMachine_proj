using System;
using System.Collections.Generic;
using System.Text;

namespace Soda_Machine
{
    class Backpack
    {
        public List<Can> cansInBackPack = new List<Can>();
        Can orangeSoda = new OrangeSoda();
        Can cocaCola = new Cola();
        RootBeer rootBeer = new RootBeer();
        public Backpack()
        {
           

            

        }
        public void AddOrangeSoda()
        {
            cansInBackPack.Add(orangeSoda); 
        }
        public void AddCocaCola()
        {
            cansInBackPack.Add(cocaCola); 
        }
        public void AddRootBeer()
        {
            cansInBackPack.Add(rootBeer); 
        }
        

    }
        
}
