using _13_ნასწავლი_მასალის_პრაქტიკული_გამეორება;

using static _13_ნასწავლი_მასალის_პრაქტიკული_გამეორება.Student;



List<Student> students = new List<Student>()

            {

                new Student("Giorgi", "Beridze", 20, "giorgi.beridze@email.com", Facility.IT, 85.5),

                new Student("Nino", "Kapanadze", 21, "nino.kapa@email.com", Facility.Business, 92.3),

                new Student("Luka", "Gelasashvili", 19, "luka.gela@email.com", Facility.Design, 78.0),

                new Student("Mariam", "Mextishvili", 22, "mariam.m@email.com", Facility.Medicine, 98.4),

                new Student("Aleksandre", "Tsurtsumia", 20, "aleksa.ts@email.com", Facility.IT, 65.2),



                new Student("Ana", "Chikovani", 18, "ana.chik@email.com", Facility.Business, 88.9),

                new Student("Davit", "Abashidze", 23, "davit.aba@email.com", Facility.Medicine, 74.1),

                new Student("Elen", "Kavtaradze", 21, "elene.kavt@email.com", Facility.Design, 91.0),

                new Student("Saba", "Lomidze", 20, "saba.lom@email.com", Facility.IT, 83.7),

                new Student("Tamta", "Shengelia", 22, "tamta.sh@email.com", Facility.Business, 95.6),



                new Student("Irakli", "Kvirkvelia", 24, "irakli.kv@email.com", Facility.IT, 69.8),

                new Student("Keti", "Tabatadze", 19, "keti.taba@email.com", Facility.Medicine, 87.3),

                new Student("Levan", "Mgeladze", 20, "levan.mge@email.com", Facility.Design, 72.5),

                new Student("Salome", "Janiashvili", 21, "salome.jan@email.com", Facility.Business, 99.1),

                new Student("Zura", "Datunashvili", 22, "zura.dat@email.com", Facility.IT, 81.4)

            };

while (true)

{

    Console.WriteLine("enter number between 1-8");

    Console.WriteLine("1-show all student");

    Console.WriteLine("2-show best student");

    Console.WriteLine("3-show gpa");

    Console.WriteLine("4-search student by lastname");

    Console.WriteLine("5-sort students by GPA");

    Console.WriteLine("6-add new student");

    Console.WriteLine("7-delete student");
    Console.WriteLine("8-write list in a file");

    Console.WriteLine("9-exit");




    bool entere = int.TryParse(Console.ReadLine(), out int entered);



    if (entered < 1 || entered > 8)
    { Console.WriteLine("invalid input"); }

    {

        switch (entered)

        {

            case 1:

                foreach (Student student in students)

                { Console.WriteLine(student); }
                Console.WriteLine();
                break;

            case 2:

                double max = 0;

                Student st = students[0];

                for (int i = 0; i < students.Count; i++)

                {

                    if (students[i].Gpa >= max)

                    {

                        max = students[i].Gpa;

                        st = students[i];

                    }



                }

                Console.WriteLine($"the best student is {st}");
                Console.WriteLine();

                break;

            case 3:

                while (true)

                {

                    Console.Write("Enter student's email to search: ");
                    Console.WriteLine();

                    string email = Console.ReadLine().Trim();

                    Student foundStudent = null;

                    foreach (var student in students)

                    {

                        if (student.Email.Equals(email, StringComparison.OrdinalIgnoreCase))
                        { foundStudent = student; break; }


                    }

                    if (foundStudent != null)

                    {

                        Console.WriteLine(foundStudent);
                        Console.WriteLine();

                        break;

                    }

                    else
                    {
                        Console.WriteLine("student by this email do not exists");
                        Console.WriteLine();
                    }



                }

                break;

            case 4:

                while (true)

                {

                    Console.WriteLine("enter lastname");

                    string lastname = Console.ReadLine();

                    Student found = null;



                    foreach (var student in students)

                    {

                        if (student.LastName.ToLower() == lastname.ToLower())

                        {

                            found = student;

                            break;

                        }

                    }

                    if (found != null)

                    {

                        Console.WriteLine();
                        Console.WriteLine(found);
                        Console.WriteLine();

                        break;

                    }

                    else { Console.WriteLine("student by this email do not exists"); }

                }

                break;

            case 5:

                for (int i = 0; i < students.Count - 1; i++)

                {

                    for (int j = i + 1; j < students.Count; j++)

                    {

                        if (students[i].Gpa > students[j].Gpa)

                        {

                            Student s = students[i];

                            students[i] = students[j];

                            students[j] = s;

                        }

                    }

                }

                foreach (Student student in students)

                    Console.WriteLine(student);

                break;




            case 6:
                {
                    Console.WriteLine("Enroll new student");

                    string name = "";
                    string lastName = "";
                    int age = 0;
                    string email = "";
                    Facility fac;
                    double gpa = 0.0;

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter name: ");
                            name = Console.ReadLine().Trim();
                            break;
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter lastname: ");
                            lastName = Console.ReadLine().Trim();
                            break;
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter age: ");
                            if (!int.TryParse(Console.ReadLine(), out age))
                            {
                                throw new ArgumentException("Age must be a valid integer!");
                            }
                            break;
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter email: ");
                            email = Console.ReadLine().Trim();
                            break;
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter facility (IT, Business, Design, Medicine): ");
                            if (!Enum.TryParse(Console.ReadLine(), true, out fac))
                            {
                                throw new ArgumentException("Invalid facility name!");
                            }
                            break;
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }

                    while (true)
                    {
                        try
                        {
                            Console.Write("Enter GPA: ");
                            if (!double.TryParse(Console.ReadLine(), out gpa))
                            {
                                throw new ArgumentException("GPA must be a valid number!");
                            }
                            break;
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                    }

                    try
                    {
                        Student newStudent = new Student(name, lastName, age, email, fac, gpa);
                        students.Add(newStudent);
                        Console.WriteLine("Student added successfully using constructor!");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Constructor Error: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Unexpected error: {ex.Message}");
                    }
                }
                break;


            case 9:

                return;

            default:

                Console.WriteLine("invalid input");

                break;
            case 8:
                {
                    if (students.Count == 0)
                    {
                        Console.WriteLine("list is empty nothing to write in file");
                        break;
                    }

                    Console.WriteLine("loading");

                    using (StudentStorage storage = new StudentStorage("students_database.txt"))
                    {
                        storage.SaveStudents(students);
                    }

                    Console.WriteLine("data sucessfully entered in file");
                }
                break;


        }



    }


}





