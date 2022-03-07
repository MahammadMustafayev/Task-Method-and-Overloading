using System;

namespace Task_Method_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reqem daxil edin:");
            int numbers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bu rəqəmdə ədəd sayı:");
            Console.WriteLine(NumLength(numbers));
            




        }

        static int NumLength(int numbers)
        {
            
            
                int count = 0;
                while (numbers > 0)
                {
                    numbers /= 10;
                    count++;
                    
                }
                return count;
            
            
            
        }
    }
}
