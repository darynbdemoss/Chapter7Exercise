using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Computer
    {       

        public bool Power { get; set; } = false;
        public bool Use { get; set; } = false;
        public double Memory { get; set; }
        public string Brand { get; } = "Hackintosh";

        public Computer(bool power, bool use, double memory, string brand)
        {
            Power = power;
            Use = use;
            Memory = memory;
            Brand = brand;
        }

        public void Sleep()
        {
            Power = true;
            Use = false;
        }

        public string PowerOn()
        {
            if (!Power)
            {
                Use = false;
            }
            else if (Use == true) 
            {
                Power = true;
            }
            
            return "System Powering on!";
        }




    }
}
