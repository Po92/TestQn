using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class InputValidator
    {
        // Method to read a non-empty string
        public static string ReadNonEmptyString()
        {
            string input;
            while (true)
            {
                input = Console.ReadLine()!;
                if (!string.IsNullOrEmpty(input))
                {
                    return input; // Return valid input
                }
                else
                {
                    Console.WriteLine("Invalid Input.Please try again: ");
                }
            }
        }

        // Method to read a valid DateTime
        public static DateTime ReadDateTime()
        {
            DateTime date;
            while (true)
            {
                string input = Console.ReadLine()!;
                if (DateTime.TryParse(input, out date))
                {
                    return date; // Return valid date
                }
                else
                {
                    Console.WriteLine("Invalid date format. Please try again using format MM/dd/yyyy: ");
                }
            }
        }

        // Method to read a valid integer
        public static int ReadInt()
        {
            int result;
            while (true)
            {
                string input = Console.ReadLine()!;
                if (int.TryParse(input, out result))
                {
                    return result; // Return valid integer
                }
                else
                {
                    Console.Write("Invalid input. Please enter a valid integer: ");
                }
            }
            
        }
    }
}