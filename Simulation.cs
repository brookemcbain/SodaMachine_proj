using System;
using System.Collections.Generic;
using System.Text;

namespace Soda_Machine
{
    class Simulation
    {
        public double quarters = 20;
        public double dime = 10;
        public double nickels = 20;
        public double pennies = 50;

        SodaMachine sodaMachine = new SodaMachine();
        Customer customer = new Customer(); 
    }
}
