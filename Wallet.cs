using System;
using System.Collections.Generic;
using System.Text;

namespace Soda_Machine
{
    class Wallet
    {
        public List<Coin> coins;

        public Wallet()
        {
            Quarters quarters = new Quarters(2.50);
            Dimes dimes = new Dimes(1.50);
            Nickels nickels = new Nickels(.50);
            Pennies pennies = new Pennies(.50); 

            coins = new List<Coin>();

            coins.Add(quarters);
            coins.Add(dimes);
            coins.Add(nickels);
            coins.Add(pennies); 

            

        }
    }
}