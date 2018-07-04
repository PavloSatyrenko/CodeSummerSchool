using System;

namespace triangle
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
            Console.WriteLine("Введите второе число:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третее число:");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 >= num2)
            {
                if(num1 >= num3)
                {
                    if(num1 < num2 + num3)
                    {
                        Console.WriteLine("true");
                    }
                }
            }
            else if (num2 >= num1)
            {
                if(num2 >= num3)
                {
                    if(num2 < num1 + num3)
                    {
                        Console.WriteLine("true");
                    }
                }
            }
            else if (num3 >= num1)
            {
                if(num3 >= num2)
                {
                    if(num3 < num1 + num2)
                    {
                        Console.WriteLine("true");
                    }
                }
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
