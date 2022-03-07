using System;

namespace TaskOverload_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Sahe(4));

        }

        static int Sahe(int side )
        {
            
             return side * side * 3;
           
        }

        static int Sahe(int side1, int side2)
        {
            return side1 * side2;
            
        }
        
        static int Sahe(int side1 , int side2 , int side3)
        {
            return 2 * (side1 * side2 + side1 * side3 + side2 * side3);
        }

        static int Sahe(int side, int side1, int side2, int side3)
        {
            int p = (side1 + side2 + side3) / 2;
            return p * side;
        }
    }
}
