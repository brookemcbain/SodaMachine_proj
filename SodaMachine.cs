using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Soda_Machine
{
    class SodaMachine
    {

        public List<Coin> register = new List<Coin>();  
        public List<Can> inventory = new List<Can>();
        OrangeSoda orangeSoda;
        Cola cocaCola;
        RootBeer rootBeer;
        Quarters quarters;
        Dimes dimes;
        Nickels nickels;
        Pennies pennies;
        public SodaMachine()
        {
            
        }
    
        public void ItemsInRegister()
        {
            
            
            for (int quarters = 0; quarters < 21; quarters++)
            {
                register.Add(new Quarters());
            }
            for (int dimes = 0; dimes < 11; dimes++)
            {
                register.Add(new Dimes());
            }
            for (int nickels = 0; nickels < 21; nickels++)
            {
                register.Add(new Nickels());
            }
            for (int pennies = 0; pennies < 51; pennies++)
            {
                register.Add(new Pennies());
            }
       
        }
        public void AmountOfOrangeSodaInSodaMachine()
        {
            int numberOfOrangeSodas = 0;
            int numberOfCocaColas = 0;
            int numberOfRootBeers = 0;


            foreach (Can can in inventory)
            {
                if (orangeSoda.name == "Orange Soda")
                {
                    numberOfOrangeSodas++;
                }
            }
            foreach (Can can in inventory)
            {
                if (cocaCola.name == "Coca Cola")
                {
                    numberOfCocaColas++;
                }
            }
            foreach (Can can in inventory)
            {
                if (rootBeer.name == "Root Beer")
                {
                    numberOfRootBeers++;
                }
            }
        }
        public void RemoveOrangeSoda()
        {
            inventory.Remove(orangeSoda);
        }
        public void RemoveCocaCola()
        {
            inventory.Remove(cocaCola);
        }
        public void RemoveRootBeer()
        {
            inventory.Remove(rootBeer);
        }
        public void AddQuarter()
        {
            register.Add(quarters); 
        }
        public void AddDime()
        {
            register.Add(dimes); 
        }
        public void AddNickel()
        {
            register.Add(nickels); 
        }
        public void AddPenny()
        {
            register.Add(pennies); 
        }
        public void QuartersInSodaMachine()
        {
            int quartersInRegister = 0;

            foreach (Coin coin in register)
            {
                if (coin.name == "Quarter")
                {
                    quartersInRegister++;
                }
            }
            
            Console.WriteLine("Soda Machine Change: ");
            Console.WriteLine("Quarters = " + quarters);
        }
        public void DimesInSodaMachine()
        {
            int dimesInRegister = 0;

            foreach (Coin coin in register)
            {
                if (coin.name == "Dime")
                {
                    dimesInRegister++;

                }

            }
            Console.WriteLine("Soda Machine Change: ");
            Console.WriteLine("Quarters = " + quarters);
        }
        public void NickelsInSodaMachine()
        {
            int nickelsInRegister = 0;

            foreach (Coin coin in register)
            {
                if (coin.name == "Nickel")
                {
                    nickelsInRegister++;

                }

            }
            Console.WriteLine("Soda Machine Change: ");
            Console.WriteLine("Quarters = " + quarters);
        }
        public void PenniesInSodaMachine()
        {
            int penniesInRegister = 0;

            foreach (Coin coin in register)
            {
                if (coin.name == "Penny")
                {
                    penniesInRegister++;

                }

            }
            Console.WriteLine("Soda Machine Change: ");
            Console.WriteLine("Quarters = " + quarters);
        }
        
    }
}