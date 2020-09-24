using System;
using System.Collections.Generic;
using System.Text;

namespace Soda_Machine
{
    class Dimes : Coin
    {
        public Dimes(double valueOfCoin)
        {
            name = "Dime";
            this.valueOfCoin = valueOfCoin; 
        }
    }
}
