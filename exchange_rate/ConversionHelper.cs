using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exchange_rate
{
    public static class ConversionHelper
    {
        public static void convertDollars(double dollar, double convertRate, out double converted)
        {
            converted = dollar * convertRate;
        }

        public static void assignRate(int choice, out double conversionRate)
        {
            conversionRate = 0;
            switch (choice)
            {
                case 1:
                    conversionRate = .63071;
                    break;
                case 2:
                    conversionRate = 14.0043;
                    break;
                case 3:
                    conversionRate = 70.4800;
                    break;
                default:
                    Console.WriteLine("Invalid input, try again");
                    break;
            }
        }

        public static void displayMenu()
        {
            Console.WriteLine("Please select one.");

            Console.WriteLine("1. British Pounds");
            Console.WriteLine("2. Mexican Pesos");
            Console.WriteLine("3. Japanase Yen");
            Console.WriteLine("4. Exit Program\n");
        }
    }
}
