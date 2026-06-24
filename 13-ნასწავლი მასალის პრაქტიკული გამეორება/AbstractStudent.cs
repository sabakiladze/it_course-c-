using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static _13_ნასწავლი_მასალის_პრაქტიკული_გამეორება.Student;

namespace _13_ნასწავლი_მასალის_პრაქტიკული_გამეორება
{
    internal class AbstarctStudent
    {
        private string _name;
        private string _lastName;
        private int _age;
        private string _email;
        private double _gpa;
        public Facility _facility;

        public AbstarctStudent(string name, string lastnma, int age, string email, Facility facility, double gpa)
        {
            Name = name;
            LastName = lastnma;
            Age = age;
            Email = email;
            _facility = facility;
            Gpa = gpa;

        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || Regex.IsMatch(value, @"[^a-zA-Z]"))
                {
                    throw new ArgumentException("Name cannot be empty or could't contain numbers or symbols.");
                }
                _name = value;
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || Regex.IsMatch(value, @"[^a-zA-Z]"))
                {
                    throw new ArgumentException("Last name cannot be empty or could't contain numbers or symbols.");
                }
                _lastName = value;
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Age cannot be less than 0 or greater than 100.");
                }
                _age = value;
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    throw new ArgumentException("Email cannot be empty or invalid.");
                }
                _email = value;
            }
        }
        public double Gpa
        {
            get { return _gpa; }
            set
            {
                if (value < 0.0 || value > 100.0)
                {
                    throw new ArgumentException("GPA cannot be less than 0.0 or greater than 100.0.");
                }
                _gpa = value;
            }
        }

    }
}
