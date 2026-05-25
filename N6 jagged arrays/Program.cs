namespace N6_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int[][] grades =
            {
                new int[]{ 90, 80, 70 },
                new int[] { 85, 75, 65 },
                new int[] { 95, 85, 75 }
              };
            for (int i = 0; i < grades.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < grades[i].Length; j++)
                {
                    sum += grades[i][j];
                }
                double avg= (double)sum / grades[i].Length;
                Console.WriteLine($"Average for student {i + 1}: {avg}");
            }

            //2
            Random random = new Random();

            int[] passcodes = new int[10];

            for (int i = 0; i < passcodes.Length; i++)
            {
                passcodes[i] = random.Next(1000, 10000);
                Console.WriteLine(passcodes[i]); 
            }

            Console.Write("Enter passcode: ");
            int userCode = Convert.ToInt32(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < passcodes.Length; i++)
            {
                if (userCode == passcodes[i])
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Wrong");
            }

            //3
            int[] numbers = { 5, -10, 20, 3, -50, 100, 7 };

            int min = numbers[0];
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);

            //4
            string[] words = { "Hello", "World", "CSharp" };

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    Console.WriteLine(words[i][j]);
                }
            }

            //5
            string[] emails =
                        {"test@gmail.com", "hello.com","admin@yahoo.com" };
            for (int i = 0; i < emails.Length; i++)
            {
                bool hasAt = false;

                for (int j = 0; j < emails[i].Length; j++)
                {
                    if (emails[i][j] == '@')
                    {
                        hasAt = true;
                        break;
                    }
                }

                if (hasAt)
                {
                    Console.WriteLine(emails[i] + " Valid");
                }
                else
                {
                    Console.WriteLine(emails[i] + " -Invalid");
                }
            }
        }
        


    }
    
}
