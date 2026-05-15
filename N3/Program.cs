using System.Text;

namespace N3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1
            string correctUsername = "admin";
            string correctPassword = "1234";

            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Access denied");
            }

            //2

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine("Result: " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            // goto case2 შიეძლება დავწერო სხვა ქეისში და იქიდან გადავიდე case2 ში, 
            // არსებობს goto default ში და გადავიდეს default ში. თუ გამოვიყენებ goto ს იმ ქეისში აღარაა საჭირო break.

            //3
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Enter age: ");

            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if (age >= 0 && age <= 12)
                {
                    Console.WriteLine("ბავშვი");
                }
                else if (age <= 19)
                {
                    Console.WriteLine("თინეიჯერი");
                }
                else if (age <= 64)
                {
                    Console.WriteLine("ზრდასრული");
                }
                else
                {
                    Console.WriteLine("პენსიონერი");
                }
            }
            else
            {
                Console.WriteLine("არასწორი მონაცემი");
            }
        }
    }
    }
}
