using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Soda_Machine
{
    class SodaMachine
    {

        public List<Coin> register;
        public List<Can> inventory;

        public SodaMachine()
        {
            OrangeSoda orangeSoda = new OrangeSoda();
            Cola cocaCola = new Cola();
            RootBeer rootBeer = new RootBeer();

            inventory = new List<Can>();

            inventory.Add(orangeSoda);
            inventory.Add(cocaCola);
            inventory.Add(rootBeer);
            inventory.Add(orangeSoda);
            inventory.Add(orangeSoda);
            inventory.Add(cocaCola);
            inventory.Add(cocaCola);
            inventory.Add(cocaCola);
            inventory.Add(cocaCola);
            inventory.Add(rootBeer);
            inventory.Add(rootBeer);
            inventory.Add(rootBeer);
            inventory.Add(rootBeer);

            Quarters quartersInRegister = new Quarters(5.00);
            Dimes dimesInRegister = new Dimes(1.00);
            Nickels nickelsInRegister = new Nickels(1.00);
            Pennies penniesInRegister = new Pennies(0.50);

            register = new List<Coin>();

            register.Add(quartersInRegister);
            register.Add(dimesInRegister);
            register.Add(nickelsInRegister);
            register.Add(penniesInRegister);

            inventory.ForEach(Console.WriteLine);  
        }
        public void ItemsInRegister()
        {
      
            
        }
 
    }
}