using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            Console.WriteLine("Введите первое число:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("И третее:");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine("Наибольшее число: {0}", num1);
                }
                
            }
            else if (num2 > num1)
            {
                if(num2 > num3)
                {
                    Console.WriteLine("Наибольшее число: {0}", num2);
                }                
            }
            else if (num3 > num1)
            {
                if(num3 > num2)
                {
                    Console.WriteLine("Наибольшее число: {0}", num3);
                }
            }
            else{
                Console.WriteLine("Какие-то из чисел равны");
            }
        }
    }
}
