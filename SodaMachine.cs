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


        }
        //member methods
       
    }
}