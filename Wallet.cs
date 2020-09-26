using System;
using System.Collections.Generic;
using System.Text;

namespace Soda_Machine
{
    class Wallet
    {
        public List<Coin> coins;

        Quarters quarters; 
        Dimes dimes;
        Nickels nickels;
        Pennies pennies;

        public Wallet()
        { 

            coins = new List<Coin>();

        }
        public void CoinsInWallet()
        {
    
            for(int quarters = 0 ; quarters < 11; quarters++)
            {
                coins.Add(new Quarters()); 
            }
            for (int dimes = 0; dimes < 16; dimes++)
            {
                coins.Add(new Dimes()); 
            }
            for (int nickels = 0; nickels < 16; nickels++)
            {
                coins.Add(new Nickels()); 
            }
            for (int pennies = 0; pennies < 26; pennies++)
            {
                coins.Add(new Pennies()); 
            }

        }
        public void DisplayQuarters()
        {
            int amountOfQuarters = 0; 

            foreach (Coin coin in coins)
            {
                if(quarters.name == "Quarter") 
                {
                    amountOfQuarters++;
                }
            }

            Console.WriteLine("Quarters: $" + amountOfQuarters);
        }
        public void DisplayDimes()
        {
            int amountOfDimes = 0;
            
            {
                foreach (Coin coin in coins)
                {
                    if(dimes.name == "Dime")
                    {
                        amountOfDimes++; 
                    }
                }
            
                Console.WriteLine("Dimes: $" + dimes.ValueOfCoin); 
            }
        }
        public void DisplayNickels()
        {
            int amountOfNickels = 0;

            foreach (Coin coin in coins)
            {
                if (nickels.name == "Nickel")
                {
                    amountOfNickels++;
                }
            }

            Console.WriteLine("Nickels: $" + amountOfNickels);
        }
        public void DisplayPennies()
        {
            int amountOfPennies = 0;

            foreach (Coin coin in coins)
            {
                if (pennies.name == "Penny")
                {
                    amountOfPennies++;
                }
            }

            Console.WriteLine("Pennies: $" + amountOfPennies);
        }
        public void RemoveQuarter()
        {
            coins.Remove(quarters);
        }
        public void RemoveDimes()
        {
            coins.Remove(dimes); 
        }
        public void RemoveNickels()
        {
            coins.Remove(nickels); 
        }
        public void RemovePennies()
        {
            coins.Remove(pennies); 
        }
    }
}