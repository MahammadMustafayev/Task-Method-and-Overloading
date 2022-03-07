using System;

namespace Task_Method__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 19, 2, 31, 13, 50 };
            Console.WriteLine("Bu arrayın ən kiçik qiyməti:");
            Console.WriteLine(Min(numbers));
        }

        static int Min(int [] numbers)
        {
            //int[] num = { 1, 2, 3, 4, 5 };
            int min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            return min ;
        }



    }
}
