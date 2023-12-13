using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class checking
{
    public static string get_studentNumber(int a)
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (a == 0)
            {
                Console.Write("\nEnter Student Number: ");
            }
            else if (a == 1)
            {
                Console.Write("\nEnter New Student Number: ");
            }
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Student number cannot be empty. Please enter a valid student number.");
                continue;
            }

            if (OtherInformation.get_Phonebook().Any(s => s.StudentNumber == input))
            {
                Console.WriteLine("Student Number Already Exists.");
                continue;
            }
            if (!input.All(c => char.IsDigit(c) || c == '-'))
            {
                Console.WriteLine("Invalid input format (example: 202847 || 28-238-2241). Please enter a valid input.");
                continue;
            }
            else
            {
                return input;
            }
        }
    }
 }