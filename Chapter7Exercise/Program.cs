using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer test = new Computer(true, false, 16, "Dell");

            test.Sleep();
            //Console.WriteLine($"new computer {}");
        }
    }
}
