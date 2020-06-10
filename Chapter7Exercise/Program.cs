using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer test = new Computer(false, false, 16, "Dell");

            Console.WriteLine($"new computer {test}");
        }
    }
}
