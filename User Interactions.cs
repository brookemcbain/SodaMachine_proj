using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Soda_Machine
{
    class User_Interactions
    {
        SodaMachine sodaMachineOptions; 
        public User_Interactions()
        {
            sodaMachineOptions = new SodaMachine(); 
            Console.WriteLine("Please choose which soda you would like: ");
            string answer = Console.ReadLine();

            if (answer == "1")
            {
                
                Console.WriteLine();
            }

        }
       
        public void Practice()
        {
            
        }
    
    }
}
