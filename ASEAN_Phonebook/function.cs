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




            Console.Write("Enter Surname: ");
            string surname = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(surname))
            {
                Console.WriteLine("Last name cannot be empty. Please enter a valid surname.");
                continue;
            }

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(firstName))
            {
                Console.WriteLine("First name cannot be empty. Please enter a valid first name.");
                continue;
            }

            Console.Write("Enter Occupation: ");
            string occupation = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(occupation))
            {
                Console.WriteLine("Occupation cannot be empty. Please enter a valid occupation.");
                continue;
            }

            Console.Write("Enter Gender (M/F): ");
            if (!char.TryParse(Console.ReadLine(), out char gender))
            {
                Console.WriteLine("Gender cannot be empty and must be single character. Please enter a valid gender (M/F).");
                continue;
            }

            Console.Write("Enter Country Code: ");
            if (!int.TryParse(Console.ReadLine(), out int countryCode))
            {
                Console.WriteLine("Country code cannot be empty and must be numbers. Please enter a valid country code.");
                continue;
            }

            Console.Write("Enter Area Code: ");
            if (!int.TryParse(Console.ReadLine(), out int areaCode))
            {
                Console.WriteLine("Area code cannot be empty and must be numbers. Please enter a valid area code.");
                continue;
            }

            Console.Write("Enter Number: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Number cannot be empty and must be numbers. Please enter a valid number.");
                continue;
            }

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
            string gender;
            if (person.Gender == 'M')
            {
                gender = "his";
            }
            else if (person.Gender == 'F')
            {
                gender = "her";
            }
            else
            {
                gender = "their";
            }
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
                        Console.Write("Enter new surname: ");
                        string newSurname = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(newSurname))
                        {
                            Console.WriteLine("Last name cannot be empty. Please enter a valid surname.");
                            continue;
                        }
                        else 
                        {
                            person.Surname = newSurname;
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write("Enter new first name: ");
                        string newFirstName = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(newFirstName))
                        {
                            Console.WriteLine("First name cannot be empty. Please enter a valid first name.");
                            continue;
                        }
                        else
                        {
                            person.FirstName = newFirstName;
                        }
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Write("Enter new occupation: ");
                        string newOccupation = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(newOccupation))
                        {
                            Console.WriteLine("Occupation cannot be empty. Please enter a valid occupation.");
                            continue;
                        }
                        else
                        {
                            person.Occupation = newOccupation;
                        }
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.Write("Enter new gender (M/F): ");
                        if (char.TryParse(Console.ReadLine(), out char newGender) && (char.ToUpper(newGender) == 'M' || char.ToUpper(newGender) == 'F'))
                        {
                            person.Gender = newGender;
                        }
                        else
                        {
                            Console.WriteLine("Gender cannot be empty and must be a single character. Please enter a valid gender(M/F).");
                        }
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.Write("Enter new country code: ");
                        if (int.TryParse(Console.ReadLine(), out int newCountryCode))
                        {
                            person.CountryCode = newCountryCode;
                        }
                        else
                        {
                            Console.WriteLine("Country code cannot be empty and must be number. Please enter a valid country code.");
                        }
                        Console.WriteLine();
                        break;

                    case 7:
                        Console.Write("Enter new area code: ");
                        if (int.TryParse(Console.ReadLine(), out int newAreaCode))
                        {
                            person.CountryCode = newAreaCode;
                        }
                        else
                        {
                            Console.WriteLine("Area code cannot be empty and must be number. Please enter a valid area code.");
                        }
                        Console.WriteLine();
                        break;

                    case 8:
                        Console.Write("Enter new phone number: ");
                        if (int.TryParse(Console.ReadLine(), out int newNumber))
                        {
                            person.CountryCode = newNumber;
                        }
                        else
                        {
                            Console.WriteLine("Number cannot be empty and must be number. Please enter a valid number.");
                        }
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
                string gender;
                if (person.Gender == 'M')
                {
                    gender = "his";
                }
                else if (person.Gender == 'F')
                {
                    gender = "her";
                }
                else
                {
                    gender = "their";
                }
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