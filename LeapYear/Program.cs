using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Введите год:");
            num = Convert.ToInt32(Console.ReadLine());
            if(num % 4 == 0)
            {
                Console.WriteLine("true");
            }
            else
            {
               Console.WriteLine("false"); 
            }
        }
    }
}
