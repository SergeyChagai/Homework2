using System;

namespace Impair_Digits_9_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите целое число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int rep = 0;

                while (a % 10 != 0)
                {
                    if ((a % 10) % 2 != 0)
                        rep++;
                    a /= 10;
                }

                Console.WriteLine("Количество нечетных цифр в этом числе равно " + rep);
            }
        }
    }
}
