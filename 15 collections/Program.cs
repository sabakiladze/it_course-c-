using _15_collections;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

List<Student> students = new List<Student>();
Dictionary<Student, double> grades = new Dictionary<Student, double>();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("======================================================");
    Console.WriteLine("enter one of the following numbers");
    Console.WriteLine("1-Enter Student And Grade");
    Console.WriteLine("2-Search Student");
    Console.WriteLine("3-Update Grade");
    Console.WriteLine("4-Show All Students And Their Grades");
    Console.WriteLine("5-Exit");
    Console.WriteLine("======================================================");

    try
    {
        int entered = Convert.ToInt32(Console.ReadLine().Trim());

        switch (entered)
        {
            case 1:
                string name = "";
                while (true)
                {
                    try
                    {
                        Console.WriteLine("enter the student's name");
                        name = Console.ReadLine().Trim();
                        if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                        {
                            throw new ArgumentException("invalid input, name must contain only english alphabet");
                        }
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Unexpected error: {ex.Message}");
                    }

                }
                Student s1 = new Student(name);
                students.Add(s1);
                while (true)
                {
                    try
                    {
                        Console.WriteLine($"enter student's grade, must be between 0 and 100");
                        bool valid = double.TryParse(Console.ReadLine().Trim(), out double mark);
                        if (!valid || mark < 0 || mark > 100)
                        {
                            throw new ArgumentException("invalid input, grade must be a number and between 0 and 100");
                        }
                        grades[s1] = mark;
                        Console.WriteLine();
                        Console.WriteLine("Student added successfully");
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Unexpected error: {ex.Message}");
                    }
                }
                break;


            case 2:
                while (true)
                {
                    try
                    {
                        Console.WriteLine("search student  by id");

                        bool val = int.TryParse(Console.ReadLine().Trim(), out int id_search);
                        if (val)
                        {
                            var searched = grades.Keys.FirstOrDefault(k => k.Id == id_search);

                            if (searched != null)

                            {
                                Console.WriteLine();
                                Console.WriteLine($"{searched.Id} : {searched.Name} : {grades[searched]}");

                            }

                            else

                            {

                                throw new ArgumentException("Student by this id could't found");

                            }
                            break;
                        }
                        else { throw new ArgumentException("invalid"); }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Unexpected error: {ex.Message}");
                    }
                }
                break;

            case 3:
                int id = 0;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("update student's grade");

                        bool val = int.TryParse(Console.ReadLine().Trim(), out int ids);
                        if (val)
                        {
                            throw new ArgumentException("invalid input, grade must be integer and between 0 and 100");
                        }
                        id = ids;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Unexpected error: {ex.Message}");
                    }
                    break;

                }

                var id_searched = grades.Keys.FirstOrDefault(k => k.Id == id);

                if (id_searched != null)

                {
                    while (true)
                    {
                        try
                        {
                            bool valid = double.TryParse(Console.ReadLine().Trim(), out double mark);

                            if (valid && (0 <= mark && mark <= 100))

                            {

                                grades[id_searched] = mark;

                            }

                            else { throw new ArgumentException("invalid input, grade must be integer and between 0 and 100"); }
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Unexpected error: {ex.Message}");
                        }

                        break;
                    }

                }
                break;

            case 4:

                Console.WriteLine("All students and their grade");

                foreach (var s in grades)

                {

                    Console.WriteLine($"{s.Key.Id} : {s.Key.Name} : {s.Value}");

                }

                break;
            case 5:
                return;
            default:
                Console.WriteLine("Invalid input. Please choose a number between 1 and 5.");
                break;
        }

    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Unexpected error: {ex.Message}");
    }


}





