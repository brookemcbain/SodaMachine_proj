using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Soda_Machine
{
    abstract class Coin
    {
        protected double valueOfCoin; 
        public double ValueOfCoin { get { return valueOfCoin; } }
        public string name; 
        public Coin()
        {

        }
        
    }
}
