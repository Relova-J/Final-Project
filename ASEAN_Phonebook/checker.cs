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

    public static string get_surname(int a)
    {
        while (true)
        {
            if (a == 0)
            {
                Console.Write("\nEnter Surname Number: ");
            }
            else if (a == 1)
            {
                Console.Write("\nEnter New Surname Number: ");
            }
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Surname cannot be empty. Please enter a valid surname.");
                continue;
            }
            if (!input.All(c => char.IsLetter(c) || c == '-' || c == '.'))
            {
                Console.WriteLine("Invalid input format (example: De-Palo). Please enter a valid input.");
                continue;
            }
            else
            {
                return input;
            }
        }
    }

    public static string get_firstName(int a)
    {
        while (true)
        {
            if (a == 0)
            {
                Console.Write("\nEnter First Name: ");
            }
            else if (a == 1)
            {
                Console.Write("\nEnter New First Name: ");
            }
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("First name cannot be empty. Please enter a valid first name.");
                continue;
            }
            if (!input.All(c => char.IsLetter(c) || c == '-' || c == '.'))
            {
                Console.WriteLine("Invalid input format (example: Trex). Please enter a valid input.");
                continue;
            }
            return input;
        }
    }

    public static string get_occupation(int a)
    {
        while (true)
        { 
            if (a == 0)
            {
                Console.Write("\nEnter Occupation: ");
            }
            else if (a == 1)
            {
                Console.Write("\nEnter New Occupation: ");
            }
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Occupation cannot be empty. Please enter a valid occupation.");
                continue;
            }
            if (!input.All(c => char.IsLetter(c) || c == ' '))
            {
                Console.WriteLine("Invalid input format (example: Teacher). Please enter a valid input.");
                continue;
            }
            return input;
        }
    }

    public static char get_gender(int a)
    {
        while (true)
        {
            if (a == 0)
            {
                Console.Write("\nEnter Gender(M/F): ");
            }
            else if (a == 1)
            {
                Console.Write("\nEnter New Gender(M/F): ");
            }
            if (!char.TryParse(Console.ReadLine(), out char input) && string.IsNullOrEmpty(input.ToString()))
            {
                Console.WriteLine("Gender cannot be empty and must be single character. Please enter a valid input (M/F).");
                continue;
            }
            if (input != 'M' && input != 'F')
            {
                Console.WriteLine("Invalid input format (example: M or F). Please enter a valid input.");
                continue;
            }
            return input;
        }
    }

    public static int get_countryCode(int a)
    {
        while (true)
        {
            if (a == 0)
            {
                Console.Write("\nEnter Country Code: ");
            }
            else if (a == 1)
            {
                Console.Write("\nEnter New Country Code: ");
            }
            if (!int.TryParse(Console.ReadLine(), out int input) && string.IsNullOrEmpty(input.ToString()))
            {
                Console.WriteLine("Country code cannot be empty and must be numbers. Please enter a valid country code.");
                continue;
            }
            if (!(input == 60 || input == 62 || input == 63 || input == 65 || input == 66))
            {
                Console.WriteLine("Invalid input format (Example: 60, 62, 63, 65, or 66 ). Please enter a valid input.");
                continue;
            }
            return input;
        }
    }

    public static string get_areaCode(int a)
    {
        while (true)
        {
            if (a == 0)
            {
                Console.Write("\nEnter Area Code: ");
            }
            else if (a == 1)
            {
                Console.Write("\nEnter New Area Code: ");
            }

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Area code cannot be empty and must be numbers. Please enter a valid area code.");
                continue;
            }
            if (!input.All(c => char.IsDigit(c)))
            {
                Console.WriteLine("Area code must be numbers. Please enter a valid area code.");
                continue;
            }
            return input;
        }
    }

    public static string get_number(int a)
    {
        while (true)
        {
            if (a == 0)
            {
                Console.Write("\nEnter Phone Number: ");
            }
            else if (a == 1)
            {
                Console.Write("\nEnter New Phone Number: ");
            }
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Phone numbers cannot be empty and must be numbers. Please enter a valid phone number.");
                continue;
            }
            if (!input.All(c => char.IsDigit(c)))
            {
                Console.WriteLine("Phone numbers must be numbers. Please enter a valid phone numbers.");
                continue;

 }
