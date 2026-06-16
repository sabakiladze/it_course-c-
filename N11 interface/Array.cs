using System.Globalization;

namespace N11_interface
{
    public class Array : IOutput2, ICalc
    {
        private int[] _numbers;

        public Array(int[] numbers1)
        {
            _numbers = numbers1;
        }
        public int[] Number
        {
            get { return _numbers; }
            set { _numbers = value; }
        }

        public void ShowEven()
        {
            foreach (var n in Number)
            {
                if (n % 2 == 0) Console.WriteLine(n);
            }
        }
        public void ShowOdd()
        {
            foreach (var n in Number)
            {
                if (n % 2 != 0) Console.WriteLine(n);
            }
        }

        public void CountDistinct()
        {
            int count = Number.Length;
            
            for (int i=0; i<Number.Length; i++)
            {
                bool isDistinct = true;
                for (int j=i+1; j<Number.Length; j++)
                {
                    if (Number[i] == Number[j])
                    {
                      isDistinct= false;
                      break;
                    }
                    
                }
                if (isDistinct==false)
                {
                    count--;
                }
            }
            Console.WriteLine(count);

        }

        public void EqualToValue(int value)
        {
            int count1 = 0;
            for(int i=0; i<Number.Length; i++)
            {
                if (Number[i] >= value)
                {
                    count1++;
                }
            }
            Console.WriteLine(count1);
        }
        static void Main(string[] args)
        {
            int[] myNumbers = { 1, 2, 3, 4, 5, 6,1};
            Array arrayObject = new Array(myNumbers);


            arrayObject.ShowEven();
            arrayObject.ShowOdd();
            arrayObject.CountDistinct();
            arrayObject.EqualToValue(3);
        }
    }
}
