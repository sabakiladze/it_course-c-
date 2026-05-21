namespace leqcia_5_arrayes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            int[] arr1 = new int[3] { 1, 2, 3 };
            int[] arr2 = new int[3] { 4, 5, 6 };
            int[] arr3 = new int[arr1.Length + arr2.Length];
            int index = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[index] = arr1[i];
                index++;
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[index] = arr2[i];
                index++;
            }
            foreach (int itmem in arr3)
            {
                Console.Write(itmem + " ");
            }

           // 2
            int[] arr4 = { 3, 5, -4, 8, 11, 1, -1, 6 };
            int targetsum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr4.Length - 1; i++)
            {
                for (int j = i + 1; j < arr4.Length; j++)
                {
                    if (arr4[i] + arr4[j] == targetsum)
                    {
                        Console.WriteLine($"[{arr4[i]}, {arr4[j]}]");
                    }
                }
            }




        }

    }
}
