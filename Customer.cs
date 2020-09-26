using System;
using System.Collections.Generic;
using System.Text;

namespace Soda_Machine
{
    class Customer
    {
        Wallet wallet = new Wallet();
        Backpack backpack = new Backpack();

        public Customer()
        {
            ChooseCoins(); 
        }
        public void Intro()
        {
            Console.WriteLine("Soda Machine");
            Console.WriteLine("1. Orange Soda - $0.06");
            Console.WriteLine("2. Coca Cola - $0.35");
            Console.WriteLine("3. Root Beer - $0.60");
        }
        public void ChooseSoda()
        {
            SodaMachine sodaMachineOptions = new SodaMachine();
            List<Backpack> backpack = new List<Backpack>();
            Wallet wallet = new Wallet();

            string answer = Console.ReadLine();

            for (int index = 0; index < 3; index++)
                if (answer == "1")
                {
                    // add to backpack 
                    Console.WriteLine("Please wait while we dispense your 'Orange Soda'");
                    sodaMachineOptions.RemoveOrangeSoda();
                    break;

                }
                else if (answer == "2")
                {
                    // add to backpack
                    Console.WriteLine("Please wait while we dispense your 'Coca Cola'");
                    sodaMachineOptions.RemoveCocaCola();
                    break;
                }
                else if (answer == "3")
                {
                    //add to backpack
                    Console.WriteLine("Please wait while we dispense your 'Root Beer'");
                    sodaMachineOptions.RemoveRootBeer();
                    break;

                }
                else
                {
                    Console.WriteLine("Please choose an option from the list above, type a number 1- 3");
                }
        }

        public void CoinsInWallet()
        {
            Wallet wallet = new Wallet();

            Console.WriteLine("Please choose which coins you would like to use: ");
            Console.WriteLine("Your wallet: ");
            wallet.CoinsInWallet();

        }
        public void ChooseCoins()
        {
            Wallet wallet = new Wallet();
            SodaMachine coinsInSodaMachine = new SodaMachine();

            Console.WriteLine("Please choose which coins you would like to insert");
            Console.WriteLine("1)"); wallet.DisplayQuarters();
            Console.WriteLine("2)"); wallet.DisplayDimes();
            Console.WriteLine("3)"); wallet.DisplayNickels();
            Console.WriteLine("4)"); wallet.DisplayPennies();
            Console.WriteLine("5) Done with coin transaction");


            Console.WriteLine("Would you like to insert another coin");
            string answer = Console.ReadLine();
            for (int input = 0; input < 6; input++)
            {
                if (answer == "1")
                {
                    wallet.RemoveQuarter();
                    coinsInSodaMachine.AddQuarter();
                    ChooseCoins();
                }
                else if (answer == "2")
                {
                    wallet.RemoveDimes();
                    coinsInSodaMachine.AddDime();
                    ChooseCoins();
                }
                else if (answer == "3")
                {
                    wallet.RemoveNickels();
                    coinsInSodaMachine.AddNickel();
                    ChooseCoins();
                }
                else if (answer == "4")
                {
                    wallet.RemovePennies();
                    coinsInSodaMachine.AddPenny();
                    ChooseCoins();
                }
                else if (answer == "5")
                {
                    // continue on   
                }

            }
        }

    }
