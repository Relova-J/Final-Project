static void to_ASEAN_phonebook()
    {
        while (true)
        {
          Console.Write("Enter Student Number: ");
          string studentNumber = Console.ReadLine();
          Console.Write("Enter Surname: ");
          string surname = Console.ReadLine();
          Console.Write("Enter First Name: ");
          string firstName = Console.ReadLine();
          Console.Write("Enter Occupation: ");
          string occupation = Console.ReadLine();
          Console.Write("Enter Gender (M/F): ");
          char gender = Console.ReadKey().KeyChar;
          Console.WriteLine(); 
          Console.Write("Enter Country Code: ");
          int countryCode = Convert.ToInt32(Console.ReadLine());
          Console.Write("Enter Area Code: ");
          int areaCode = Convert.ToInt32(Console.ReadLine());
          Console.Write("Enter Number: ");
          int number = Convert.ToInt32(Console.ReadLine());

          Console.Write("Do you want to enter another entry(Y/N)?")
          char choice = Console.ReadKey().KeyChar;
          Console.WriteLine(); 

          if (char.ToUpper(choice) == 'N')
              break;
        }
    }
