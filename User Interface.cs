using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Soda_Machine
{
    public static class User_Interface
    {
        public static void SodaList()
        {
            Console.WriteLine("Soda Machine");
            Console.WriteLine("1. Orange Soda - $0.06");
            Console.WriteLine("2. Coca Cola - $0.35");
            Console.WriteLine("3. Root Beer - $0.60");
            
        }
        public static void CoinList()
        {
            Console.WriteLine("Please choose which coins you would like to insert");
            Console.WriteLine("1) Quarter");
            Console.WriteLine("2) Dime");
            Console.WriteLine("3) Nickel"); 
            Console.WriteLine("4) Penny");
            Console.WriteLine("5) Display coins available"); 
            
        }
       
    }

}
   