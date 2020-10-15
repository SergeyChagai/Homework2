using System;

namespace Homework2
{
    class Degree
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Введите число А");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите степень B");
                int b = Convert.ToInt32(Console.ReadLine());
                int i = 1;
                int degree = a;

                Console.Write($"Число {a}, возведенное в степень {b} равно ");
                if (b == 0)
                    Console.WriteLine("1");
                else
                {
                    while (i < b)
                    {
                        degree = degree * a;
                        i++;
                    }
                    Console.WriteLine(degree);
                }
            }
        }
    }
}
