using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Functions
{
    public static void to_ASEAN_phonebook()
    {
        while (true)
        {
            string studentNumber = checking.get_studentNumber(0);
            string surname = checking.get_surname(0);
            string firstName = checking.get_firstName(0);
            string occupation = checking.get_occupation(0);
            char gender = checking.get_gender(0);
            int countryCode = checking.get_countryCode(0);
            string areaCode = checking.get_areaCode(0);
            string number = checking.get_number(0);

            OtherInformation.add_to_Phonebook(new PersonalInformation(studentNumber, surname, firstName, occupation, gender=char.ToUpper(gender), countryCode, areaCode, number));

            Console.Write("\nDo you want to enter another entry(Y/N)? ");
            if (!char.TryParse(Console.ReadLine(), out char choice))
            {
                Console.WriteLine("Choice cannot be empty or more than one characters. Please enter a valid choice (Y/N).");
                continue;
            }

            if (char.ToUpper(choice) == 'N')
                break;
        }
    }
    public static void edit_ASEAN_phonebook()
    {
        Console.Write("\nEnter Student Number: ");
        string studentNumber = Console.ReadLine();
        if (string.IsNullOrEmpty(studentNumber))
        {
            Console.WriteLine("Input cannot be empty. Please enter a valid student number.");
        }
        PersonalInformation person = OtherInformation.get_Phonebook().Find(s => s.StudentNumber == studentNumber);

        if (person == null)
        {
            Console.WriteLine("Student Number not found.");
            return;
        }

        while (true)
        {
            Console.WriteLine("\nPerson Found:");
            string gender = checking.get_identifier(person.Gender);
            Console.WriteLine($"{person.Surname}, {person.FirstName} with student number {person.StudentNumber}, is a {person.Occupation}. {gender} phone number is {person.CountryCode}-{person.AreaCode}-{person.Number}.");
            Console.WriteLine("\nEdit Menu:");
            Console.WriteLine("[1] Student Number");
            Console.WriteLine("[2] Surname");
            Console.WriteLine("[3] First Name");
            Console.WriteLine("[4] Occupation");
            Console.WriteLine("[5] Gender");
            Console.WriteLine("[6] Country Code");
            Console.WriteLine("[7] Area Code");
            Console.WriteLine("[8] Phone Number");
            Console.WriteLine("[0] None/Go Back");
            Console.Write("\nEnter choice: ");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        string newStudentNumber = checking.get_studentNumber(1);
                        Console.WriteLine();
                        break;

                    case 2:
                        person.Surname = checking.get_surname(1);
                        Console.WriteLine();
                        break;

                    case 3:
                        person.FirstName = checking.get_firstName(1);
                        Console.WriteLine();
                        break;

                    case 4:
                        person.Occupation = checking.get_occupation(1);
                        Console.WriteLine();
                        break;

                    case 5:
                        person.Gender = checking.get_gender(1);
                        Console.WriteLine();
                        break;

                    case 6:
                        person.CountryCode = checking.get_countryCode(1);
                        Console.WriteLine();
                        break;

                    case 7:
                        person.AreaCode = checking.get_areaCode(1);
                        Console.WriteLine();
                        break;

                    case 8:
                        person.Number = checking.get_number(1);
                        Console.WriteLine();
                        break;

                    case 0:
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.WriteLine();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
    public static void get_ASEAN_phonebook()
    {
        List<PersonalInformation> filter_person = new List<PersonalInformation>();
        List<int> choices = new List<int>();
        List<string> country_names = new List<string>();

        while (true)
        {
            Console.WriteLine("\nFrom which country:");
            Console.WriteLine("[1] Malaysia");
            Console.WriteLine("[2] Indonesia");
            Console.WriteLine("[3] Philippines");
            Console.WriteLine("[4] Singapore");
            Console.WriteLine("[5] Thailand");
            Console.WriteLine("[6] ALL");
            Console.WriteLine("[0] None More Country");
            Console.Write("\nEnter choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice == 0)
                {
                    break;
                }
                else if (choice == 6)
                {
                    choices = new List<int> { 1, 2, 3, 4, 5 };
                    break;
                }
                else if (choice > 0 && choice < 6)
                {
                    choices.Add(choice);
                }
                else
                {
                    Console.WriteLine("Invalid Number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }

        foreach (var choice in choices)
        {
            var keyValuePair = OtherInformation.ASEANcountries.ElementAt(choice - 1);

            int countryCode = keyValuePair.Key;
            string countryName = keyValuePair.Value;
            country_names.Add(countryName);

            filter_person.AddRange(OtherInformation.get_Phonebook().Where(person => person.CountryCode == countryCode));
        }

        if (filter_person.Count > 0)
        {
            Console.WriteLine($"\nList of People in {string.Join(", ", country_names)}");

            foreach (PersonalInformation person in filter_person)
            {
                string gender = checking.get_identifier(person.Gender);
                Console.WriteLine($"{person.Surname}, {person.FirstName} with student number {person.StudentNumber}, is a {person.Occupation}. {gender} phone number is {person.CountryCode}-{person.AreaCode}-{person.Number}.");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine($"\nThere is No Person in {string.Join(", ", country_names)}:");
        }
    }
}
