using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Laptop : Computer
    {
        public double Weight { get; set; }

        public Laptop(bool power, bool use, double memory, string brand, double weight) : base(power, use, memory, brand)
        {
            Weight = weight;
        }

        public bool IsAThickBoy()
        {
            if(Weight > 55.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
