using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring a variable to store the total number of vowels
            int total = 0;
            //Asking the user to select a method of string manipulation
            Console.WriteLine("What method of string manipulation would you like to use?");
            //Method options for the user to select
            Console.WriteLine("1. Reverse a string  2. Count the vowels  3. Check palindrome");
            //Reading the user input
            string userInput = Console.ReadLine();
            //First option to reverse a string
            if (userInput == "1")

            {
                //Asking the user to enter a string to reverse
                Console.WriteLine("Enter a string to reverse");
                //Reading the input string
                string input = Console.ReadLine();
                //Converts the string to a char array
                char[] charArray = input.ToCharArray();
                //Reverses the string
                Array.Reverse(charArray);
                //Reads reversed string to user
                Console.WriteLine("Youre reversed string is " + new string(charArray));
            }
            //Option to count the vowels in a string
            else if (userInput == "2")
            {
                //Asking the user to enter a string to count the vowels
                Console.WriteLine("Enter a string to count the vowels");
                //Reading the input string and changing it to lower case
                string input = Console.ReadLine().ToLower();
                //Declaring an array of vowels
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                total = input.Count(c => vowels.Contains(c));
                //Testing the total number of vowels in the string
                Console.WriteLine("Your total number of vowels is " + total);
            }
            //Third option to check if the string is a palindrome
            else if (userInput == "3")
            {
                //Asking the user to enter a string to check if it is a palindrome
                Console.WriteLine("Enter a string to check if it is a palindrome");
                //Declaring a variable to store the input string
                var inputString = Console.ReadLine();
                //Reading the input string and checking if it is a palindrome
                Console.WriteLine(IsPalindrome(inputString) ? "It is a palindrome" : "It is not a palindrome");
                {
 
                }
            }
        }
        //Refrence for palindrome method
        public static bool IsPalindrome(string inputString)
        {
            //Calxulating the length of the string
            int length = inputString.Length;
            //Incrementing the length of the string
            for (int i = 0; i < length / 2; i++)
            {
                //Checking if the string is a palindrome
                if (inputString[i] != inputString[length - i - 1])
                {
                    return false;

                }
            }
            return true;
        }
    }
}
