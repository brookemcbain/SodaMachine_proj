using System;
using System.Collections.Generic;
using System.Text;

namespace Soda_Machine
{
    class Pennies : Coin
    {
        public Pennies(double valueOfCoin)
        {
            name = "Penny";
            this.valueOfCoin = valueOfCoin; 
        }
        
    }
}
