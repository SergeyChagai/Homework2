using System;

namespace Divider_Euklid
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите два положительных целых числа:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int rep = 1;

                if (a < b)
                {
                    int buf = a;
                    a = b;
                    b = buf;
                }

                while (b != 0)
                {
                    rep = b;
                    b = a % b;
                }

                Console.WriteLine($"Наибольший общий делитель равен {rep}");
            }
        }
    }
}
