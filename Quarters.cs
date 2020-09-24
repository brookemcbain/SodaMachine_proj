using System;
using System.Collections.Generic;
using System.Text;

namespace Soda_Machine
{
    class Quarters : Coin
    {
        
        public Quarters(double valueOfCoin)
        {
            name = "Quarter";
            this.valueOfCoin = valueOfCoin;   
        }
    }
}
