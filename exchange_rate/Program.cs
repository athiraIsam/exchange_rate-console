using System;

namespace exchange_rate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============American Dollars Rate Converter===============\n");

            //declare variable
            int menuChoice = 0;
            double americanDollars = 0.0;
            double conversionRate = 0.0;
            double convertedCurrency = 0.0;

            ConversionHelper.displayMenu();

            Console.Write("Your choice is:");
            var strMenuChoice =Console.ReadLine();

            try
            {
                menuChoice = int.Parse(strMenuChoice);

                while (menuChoice > 0 && menuChoice < 4)
                {
                    Console.Write("\nNumber of American dollars:");
                    var input = Console.ReadLine();

                    if (Double.TryParse(input, out americanDollars))
                    {
                        ConversionHelper.assignRate(menuChoice, out conversionRate);

                        ConversionHelper.convertDollars(americanDollars, conversionRate, out convertedCurrency);

                        Console.WriteLine($"USD: {convertedCurrency}\n");

                        ConversionHelper.displayMenu();

                        input = Console.ReadLine();

                        if (!Int32.TryParse(input, out menuChoice))
                        {
                            Console.WriteLine("No, input could not be parsed.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No, input could not be parsed.");
                    }

                   
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Invalid Input");
            }
           
        }

    
    }
}
