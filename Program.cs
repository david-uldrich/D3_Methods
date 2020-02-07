// Programmer: David Uldrich
// Date: 02/06/2020
// Project: D3_Methods
// Description: Create a custom method and use it to display a message showing a user's name

using System;
using System.Linq;

namespace D3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display opening message asking for name input
            Console.WriteLine("Please enter your first and last name...");

            // Initiate Try-Catch to validate user input
            try
            {
                // Call custom method
                UserName();
                Console.WriteLine("Press any key to exit the program...");
            }
            catch
            {
                // Display error message
                Console.WriteLine("Please enter a valid name value. Press any key to exit and try again...");
            }
        }

        static void UserName()
        {
            // Declare string value to hold user input
            string input = Console.ReadLine();

            // Create boolean to test if all values in input are letters or spaces
            bool result = input.All(c => Char.IsLetter(c) || c == ' ');

            // Use if statement to validate user input by testing boolean
            if (result == true)
            {
                // Display user input in a hello message
                Console.WriteLine("Hello " + input + "!");
            }
            else
            {
                // Display error message
                Console.WriteLine("Please enter a valid name value. Press any key to exit and try again...");
            }
            
        }
    }
}
