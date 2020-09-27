﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Soda_Machine
{
    class Customer
    {
        Wallet wallet = new Wallet();
        Backpack backpack = new Backpack();
        SodaMachine sodaMachine = new SodaMachine();
        List<Backpack> backpackList = new List<Backpack>();
        List<double> coinsInMachine = new List<double>();
        Coin quarter = new Quarters();
        Coin dimes = new Dimes();
        Coin nickel = new Nickels();
        Coin penny = new Pennies();
        Can orangeSoda = new OrangeSoda();
        Can cola = new Cola();
        Can rootBeer = new RootBeer(); 

        public Customer()
        {
           
        }

        public void ChooseCoins()
        {
            User_Interface.CoinList();

            string answer = Console.ReadLine();
            for (int input = 0; input < 6; input++)
            {
                if (answer == "1")
                {
                    coinsInMachine.Add(quarter.ValueOfCoin); 
                    wallet.RemoveQuarter();
                    sodaMachine.AddQuarter();
                    ChooseCoins();
                }
                else if (answer == "2")
                {
                    coinsInMachine.Add(dimes.ValueOfCoin); 
                    wallet.RemoveDimes();
                    sodaMachine.AddDime();
                    ChooseCoins();
                }
                else if (answer == "3")
                {
                    coinsInMachine.Add(nickel.ValueOfCoin); 
                    wallet.RemoveNickels();
                    sodaMachine.AddNickel();
                    ChooseCoins();
                }
                else if (answer == "4")
                {
                    coinsInMachine.Add(penny.ValueOfCoin); 
                    wallet.RemovePennies();
                    sodaMachine.AddPenny();
                    ChooseCoins();
                }
                else if (answer == "5")
                {
                    wallet.CoinsInWallet(); 
                }
                else
                {
                    break;
                }
            }
        }
        public void ChooseSoda()
        {

            User_Interface.SodaList();
            string answer = Console.ReadLine();

            for (int index = 0; index < 3; index++)
            {
                if (coinsInMachine.Equals(orangeSoda.Cost) & answer == "1")
                {
                    backpack.AddOrangeSoda();
                    Console.WriteLine("Please wait while we dispense your 'Orange Soda'");
                    sodaMachine.RemoveOrangeSoda();
                    break;
                }
                else if (coinsInMachine.Equals(cola.Cost) & answer == "2")
                {
                    backpack.AddCocaCola();
                    Console.WriteLine("Please wait while we dispense your 'Coca Cola'");
                    sodaMachine.RemoveCocaCola();
                    break;
                }
                else if (coinsInMachine.Equals(rootBeer.Cost) & answer == "3")
                {
                    backpack.AddRootBeer();
                    Console.WriteLine("Please wait while we dispense your 'Root Beer'");
                    sodaMachine.RemoveRootBeer();
                    break;

                }
            }
               
                     
               
        }

 
        
    }
}
