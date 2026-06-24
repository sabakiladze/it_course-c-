using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ნასწავლი_მასალის_პრაქტიკული_გამეორება
{
    internal class StudentStorage:IDisposable
    {
        private StreamWriter _writer;

        public StudentStorage(string filePath)
        {
            _writer = new StreamWriter(filePath, false);
        }

        public void SaveStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                _writer.WriteLine($"{student.Name},{student.LastName},{student.Age},{student.Gpa}");
            }
            Console.WriteLine("student's list wrtite in file.");
        }

        public void Dispose()
        {
            if (_writer != null)
            {
                _writer.Flush(); 
                _writer.Close(); 
                _writer.Dispose();
                Console.WriteLine("clodes.");
            }
        }
    }
}
