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