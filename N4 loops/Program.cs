using System.Security.Cryptography.X509Certificates;

namespace N4_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i * number);
            }

            //2
            Console.Write("enter height: ");
            int number5 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number5; i++)
            {
                for (int space = 0; space < number5 - i - 1; space++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }



            //3
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < number2; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;

                }

            }
            Console.WriteLine(sum);
            //4
            Random random = new Random();
            int number3 = random.Next(1, 100);
            int number4 = Convert.ToInt32(Console.ReadLine());
            while (number3 != number4)
            {

                Console.WriteLine("try again");
                number4 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"you have guessed it");

        }
    }
}
