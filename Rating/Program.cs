using System;

namespace Rating
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark;
            Console.WriteLine("Введите оценку");
            mark = Convert.ToInt32(Console.ReadLine());
            if(mark >= 90)
            {
                Console.WriteLine("Отлично");
            }
            else if(mark >= 75)
            {
                Console.WriteLine("Хорошо");
            }
            else if(mark >= 65)
            {
                Console.WriteLine("Удовлетворительно");
            }
            else if(mark >= 60)
            {
                Console.WriteLine("Засчитано");
            }
            else if(mark >= 10)
            {
                Console.WriteLine("Не засчитано");
            }
                else
                {
                  Console.WriteLine("Иди учи...");
                }
            }
        }
    }

