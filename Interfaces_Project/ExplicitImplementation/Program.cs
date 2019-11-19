using System;

namespace ExplicitImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd numbers : ");
            var generator = new OddGenerator();
            foreach (var odd in generator)
            {
                if (odd > 50) break;
                Console.WriteLine(odd);
            }
            Console.ReadLine();
        }
    }
}
