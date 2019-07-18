using System;
namespace Powers_Table
{
    public class PowersTableTest
    {
      public static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
            string userChoice = "Y";
            do
            {
                // Ask user for an integer value
                Console.WriteLine("Please enter an integer:");

                // Checks to make sure user input is valid
                // If valid the program will execute
                // If not valid, the program will promt the user for another input
                try
                {
                    int userNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                    Console.WriteLine("Number\t\tSquared\t\tCubed");
                    Console.WriteLine("~~~~~~\t\t~~~~~~\t\t~~~~~~");
                    PowersTable.TableMaker(userNumber);
                }
                catch
                {
                    Console.WriteLine("\nInvalid. Please try again.\n");
                    continue;
                }

                Console.WriteLine("Would you like to continue? Y/N.");
                userChoice = Console.ReadLine().ToUpper();
            } while (userChoice == "Y");
            Console.WriteLine("Thanks for making a table!");
        }
    }
}
