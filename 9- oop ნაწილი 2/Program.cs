using System;

public enum Country
{
    Georgia,
    UnitedStates,
    Germany,
    Japan
}

public enum Gender
{
    Male,
    Female,
    Other
}

public enum Contacts
{
    Phone,
    Email,
    Fax
}

public class Employ
{
    public Country Country { get; set; }
    public Gender Gender { get; set; }
    public Contacts Contacts { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Employ(Country country, Gender gender, Contacts contacts, string name, string surname, DateTime dateOfBirth)
    {
        Country = country;
        Gender = gender;
        Contacts = contacts;
        Name = name;
        Surname = surname;
        DateOfBirth = dateOfBirth;
    }

    public int GetAge()
    {
        int age = DateTime.Today.Year - DateOfBirth.Year;
        if (DateOfBirth.Date > DateTime.Today.AddYears(-age))
        {
            age--;
        }
        return age;
    }
}

public class Program
{
    public static void Main()
    {
        Employ[] employs = new Employ[8]
        {
            new Employ(Country.Georgia, Gender.Male, Contacts.Phone, "გიორგი", "კაპანაძე", new DateTime(1990, 5, 15)),
            new Employ(Country.Georgia, Gender.Female, Contacts.Email, "ნინო", "ბერიძე", new DateTime(1995, 8, 22)),
            new Employ(Country.UnitedStates, Gender.Male, Contacts.Phone, "ლუკა", "მამულაშვილი", new DateTime(1988, 12, 10)),
            new Employ(Country.UnitedStates, Gender.Female, Contacts.Email, "მარიამ", "გელაშვილი", new DateTime(2000, 3, 5)),
            new Employ(Country.Germany, Gender.Male, Contacts.Fax, "დავით", "კვარაცხელია", new DateTime(1982, 7, 19)),
            new Employ(Country.Germany, Gender.Female, Contacts.Phone, "ანა", "აშუბა", new DateTime(1993, 11, 30)),
            new Employ(Country.Japan, Gender.Male, Contacts.Email, "ირაკლი", "მაისურაძე", new DateTime(1985, 2, 14)),
            new Employ(Country.Japan, Gender.Female, Contacts.Fax, "თამარ", "ნოზაძე", new DateTime(1998, 9, 9))
        };

        PrintEmployeesByCountry(employs, Country.Georgia);
    }

    public static void PrintEmployeesByCountry(Employ[] employees, Country targetCountry)
    {
        foreach (var emp in employees)
        {
            if (emp.Country == targetCountry)
            {
                Console.WriteLine($"{emp.Name} {emp.Surname} - ასაკი: {emp.GetAge()}");
            }
        }
    }
}