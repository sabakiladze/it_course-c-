using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13_ნასწავლი_მასალის_პრაქტიკული_გამეორება
{
    internal partial class Student: AbstarctStudent, IPrintable
    {



        public Student(string name, string lastnma, int age, string email, Facility facility, double gpa) :base(name, lastnma, age,  email, facility, gpa)
        {
            
        }
       
        public string Print()
        {
            return $"Name: {Name}, Last Name: {LastName}, Age: {Age}, Facility: {_facility}, GPA: {Gpa}";
        }
        
        public static bool operator > (Student s1, Student s2)
        { return s1.Gpa > s2.Gpa; }

        public static bool operator<(Student s1, Student s2)
        { return s1.Gpa< s2.Gpa; }

        

    }
}
