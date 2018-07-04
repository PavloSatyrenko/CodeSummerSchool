using System;

namespace Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            string weather;
            int length;
            Console.WriteLine("Введите погоду (Солнечно или дождливо)");
            weather = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите растояние");
            length = Convert.ToInt32(Console.ReadLine());
            if(weather == "солнечно")
            {
                if(length < 10 )
                {
                    Console.WriteLine("Пешком");
                }
                else if(length < 40)
                {
                    Console.WriteLine("Велосипедом");
                }
                else if(length < 400)
                {
                    Console.WriteLine("Машиной");
                }
                else if(length < 900)
                {
                    Console.WriteLine("Поездом");
                }
                else{
                    Console.WriteLine("Самолетом");
                }
            }
            else if(weather == "дождливо")
            {
                if(length < 10)
                {
                    Console.WriteLine("Машиной");
                }
                if(length < 40)
                {
                    Console.WriteLine("Машиной");
                }
            }
        }
    }
}
