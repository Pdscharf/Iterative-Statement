using System;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Integer value between 1 and 100 to execute an iterative statement.");

            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);
                int count = 0;


                if
                    ((value_of_input >= 1) && (value_of_input <= 100))
                {
                    Console.WriteLine("You have entered " + value_of_input + ". " + "This is the current integer value in the loop: " + count);
                    while (count < 101)
                    {
                        count = count + 1;
                    }
                }
                else
                {
                    input = Console.ReadLine();
                    value_of_input = int.Parse(input);
                }
            }
            catch
            {
                Console.WriteLine("Please enter an integer value");
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
        }
    }
}
