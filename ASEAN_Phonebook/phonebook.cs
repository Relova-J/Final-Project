using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PersonalInformation
{
    private string studentNumber;
    private string surname;
    private string firstName;
    private string occupation;
    private char gender;
    private int countryCode;
    private int areaCode;
    private int number;

    public PersonalInformation(string studentNumber, string surname, string firstName, string occupation, char gender, int countryCode, int areaCode, int number)
    {
        this.studentNumber = studentNumber;
        this.surname = surname;
        this.firstName = firstName;
        this.occupation = occupation;
        this.gender = gender;
        this.countryCode = countryCode;
        this.areaCode = areaCode;
        this.number = number;
    }

    public string StudentNumber
    {
        get { return studentNumber; }
        set { studentNumber = value; }
    }

    public string Surname
    {
        get { return surname; }
        set { surname = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string Occupation
    {
        get { return occupation; }
        set { occupation = value; }
    }

    public char Gender
    {
        get { return gender; }
        set { gender = value; }
    }

    public int CountryCode
    {
        get { return countryCode; }
        set { countryCode = value; }
    }

    public int AreaCode
    {
        get { return areaCode; }
        set { areaCode = value; }
    }

    public int Number
    {
        get { return number; }
        set { number = value; }
    }
}


class OtherInformation
{
    public static Dictionary<int, string> ASEANcountries = new Dictionary<int, string>()
    {
        { 60, "Federation of Malaysia" },
        { 62, "Republic of Indonesia" },
        { 63, "Republic of the Philippines" },
        { 65, "Republic of Singapore" },
        { 66, "Kingdom of Thailand" }
    };
    private static List<PersonalInformation> ASEANphonebook = new List<PersonalInformation>();

    public static void add_to_Phonebook(PersonalInformation person)
    {
        ASEANphonebook.Add(person);
    }

    public static List<PersonalInformation> get_Phonebook()
    {
        return ASEANphonebook;
    }
}