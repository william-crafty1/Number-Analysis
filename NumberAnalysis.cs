using System;

namespace Number_Analyzer
{
    class NumberAnalysis
    {
        static void Main(string[] args)
        {
            // Initialize variables
            double number;
            string choice;
            Boolean loopCondtional = false;

            // Main program loop.

            while (loopCondtional != true)
            {
                Console.WriteLine("Please enter a number between 1 and 100.");
                number = Convert.ToDouble(Console.ReadLine());

                if (number > 0 && number < 100)
                {
                    loopCondtional = true;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 100.");
                }

            }
        }
    }
}
