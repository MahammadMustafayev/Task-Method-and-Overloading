using System;

namespace TaskMethod_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mətn daxil edin:");
            string text = Console.ReadLine();
            Console.WriteLine("Burda saitlərin sayı:");
            Console.WriteLine(VowelLetter(text));           
        }

        static int VowelLetter(string text)
        {
            int count = 0;
            bool HasA = false;
            foreach (char letter in text)
            {
                if (letter == 'a' || letter == 'ı' || letter=='o' || letter=='u' || letter =='e' || letter=='ə'|| letter=='i'|| letter== 'ö'|| letter=='ü' || letter == 'A' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'E' || letter == 'Ə' || letter == 'İ' || letter == 'Ö' || letter == 'Ü')
                {
                    HasA = true;
                    count++;
                   
                }  
            }
            return count;
        }
    }
}
