using System;

namespace Task_Method__1_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Min(0));
        }

        static int Min(int nums)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            int min = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (min > num[i])
                {
                    min = num[i];
                }
            }
            return min ;
        }



    }
}
