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
            string name;
            Boolean loopCondtional = false;

            // prompt user's name
            Console.WriteLine("Hello, what is your name?");
            name = Console.ReadLine();
            Console.WriteLine("It's nice to meet you, " + name);

            // Main program loop.

            while (loopCondtional != true)
            {
                /* User is prompt for a number between 1 and 100. 
                if its within range the program will continue, otherwise it will re-prompt
                the user to enter a correct range. */
                Console.WriteLine(name + ", Please enter a number between 1 and 100.");
                number = Convert.ToDouble(Console.ReadLine());

                if (number > 0 && number < 100)
                {
                    // Program checks if the number is even or odd
                    if (number % 2 == 0)
                    {
                        // Calculate the range of the given number
                        if(number >= 2 && number <= 25){
                            Console.WriteLine("Your even number is less than 25. \n Press any key to continue");
                            Console.ReadKey();
                        }
                        else if(number >= 26 && number <= 60){
                            Console.WriteLine("Your even number is greater than 25 but less than 60.\n Press any key to continue");
                            Console.ReadKey();
                        }
                        else if(number >= 60){
                            Console.WriteLine("Your even number is greater than 60. \n Press any key to continue");
                            Console.ReadKey();
                        }
                        else{
                            Console.WriteLine(number + " is an even number.\n Press any key to continue.");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        if(number >= 60){
                            Console.WriteLine("Your odd number is greater than 60. \n Press any key to continue.");
                            Console.ReadKey();
                        }
                        else{
                            Console.WriteLine(number + " is an odd number.\n Press any key to continue.");
                            Console.ReadKey();
                        }
                    }

                    // Number's cube and square values are then displayed
                    Console.WriteLine("Number     Squared     Cubed");
                    Console.WriteLine("======     =======     =====");
                    for(double i = 1; i <= number; i++){
                        double baseNumber = i;
                        double numberSquared = Math.Pow(i, 2);
                        double numberCubed = Math.Pow(i, 3);
                        Console.WriteLine(baseNumber + "           " + numberSquared + "           " + numberCubed);

                    }
                    Console.WriteLine("Press any key to continue");
                    Console.WriteLine("==========================================");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("That isn't a number between 1 and 100. Try again.");
                }

                // User is prompt to continue or no, otherwise, program wil terminate
                Console.WriteLine("Would you like to continue, type Y for yes, otherwise type N to exit the program");
                choice = Console.ReadLine();

                if(choice == "y" || choice == "Y"){
                    loopCondtional = false;
                }
                else{
                    loopCondtional = true;
                }

            }

            Console.WriteLine("Thank you for playing, " + name + ". Goodbye!");
        }
    }
}
