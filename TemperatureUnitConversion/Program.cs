using System;

namespace TempUnitConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = 0;
            Console.Write("Enter the number you want to convert: ");
            int a = (int)Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the unit of the number which you want to convert (C,F,K): ");
            string ua = Console.ReadLine();
            Console.Write("Enter the desired unit (C,F,K): ");
            string ub = Console.ReadLine();

            switch (ua)
            {
                case "C":
                    {
                        switch (ub)
                        {
                            case "C":
                                {
                                    b = a;
                                    Console.WriteLine(b + " °C");
                                    break;
                                }
                            case "F":
                                {
                                    b = a + 33.8;
                                    Console.WriteLine(b + " °F");
                                    break;
                                }
                            case "K":
                                {
                                    break;
                                }
                            default:
                                Console.WriteLine("Invalid secondary unit.");
                                break;
                        }
                        break;
                    }

                case "F":
                    {
                        switch (ub)
                        {
                            case "C":
                                {
                                    break;
                                }
                            case "F":
                                {
                                    b = a;
                                    Console.WriteLine(b + " °F");
                                    break;
                                }
                            case "K":
                                {
                                    break;
                                }
                            default:
                                Console.WriteLine("Invalid secondary unit.");
                                break;
                        }
                        break;
                    }
                case "K":
                    {
                        switch (ub)
                        {
                            case "C":
                                {
                                    break;
                                }
                            case "F":
                                {
                                    break;
                                }
                            case "K":
                                {
                                    b = a;
                                    Console.WriteLine(b + " K");
                                    break;
                                }
                            default:
                                Console.WriteLine("Invalid secondary unit.");
                                break;
                        }
                        break;
                    }
                default:
                    { 
                    Console.WriteLine("Invalid original unit.");
                    break;
                    }
        }


        }
    }
}
