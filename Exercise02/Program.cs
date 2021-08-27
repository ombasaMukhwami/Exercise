using System;
using Exercise01;
namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = "";
            while(inputNumber != "exit")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Please enter number between 0 to {long.MaxValue:N2}");
                Console.ResetColor();
                inputNumber = Console.ReadLine();
                
                if (long.TryParse(inputNumber, out long number))
                {
                    Console.WriteLine($"-> {number.ToWords()}");
                    Console.Write("");
                }
            }
        }
    }
}
