using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    class SmartPhone : Computer
    {
        public int NumberOfSongs { get; set; }
        public SmartPhone(bool power, bool use, double memory, string brand, int numberOfSongs) : base(power, use, memory, brand)
        {
            NumberOfSongs = numberOfSongs;
        }

        public void IllegalDownload()
        {
            NumberOfSongs++;
        }


    }
}
