using System;

namespace TempUnitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 0;
            Console.Write("Enter the number you want to convert: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the unit of the number which you want to convert (C,F,K): ");
            string ua = Console.ReadLine();
            Console.Write("Enter the desired unit (C,F,K): ");
            string ub = Console.ReadLine();

        }
    }
}
