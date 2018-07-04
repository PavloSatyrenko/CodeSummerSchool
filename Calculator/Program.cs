using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            char op;
            int result = 0;
            Console.WriteLine("Введите первое число:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знак:"); 
            op = Convert.ToChar(Console.ReadLine());
            if(op == '+' )
            {
              Convert.ToInt32 (result = num1 + num2);
            }
            else if (op == '-' )
            {
               Convert.ToInt32 (result = num1 - num2);
            }
            else if (op == '*' )
            {
               Convert.ToInt32 (result = num1 * num2);
            }
            else if (op == '/' )
            {
               Convert.ToInt32 (result = num1 / num2);
            }
            else if (op == '%' )
            {
               Convert.ToInt32 (result = num1 % num2);
            }
            Console.WriteLine("Ответ: {0}", result);            
        }
    }
}
