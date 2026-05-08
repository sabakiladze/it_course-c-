namespace N2_assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("enter age");
            int age = int.Parse(Console.ReadLine());
            string output = (age >= 18) ? "congrats, you can vote" : "sorry, you are not allowed to vote";

            //2
            Console.WriteLine("enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter third number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            string biggest =
                (num1 >= num2 && num1 >= num3) ? $"{num1} is the biggest" :
                (num2 >= num1 && num2 >= num3) ? $"{num2} is the biggest" :
                $"{num3} is the biggest";

            Console.WriteLine(biggest);

            //3
            Console.WriteLine("Enter first number");
            int num_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num_2 = Convert.ToInt32(Console.ReadLine());

            int result = (num1 == num2) ? (num1 + num2) * 3 : num1 + num2;

            Console.WriteLine(result);
        }
    }
}
