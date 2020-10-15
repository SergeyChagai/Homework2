using System;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите число ");
                int a = Convert.ToInt32(Console.ReadLine());
                int s = 1;

                if (s * s >= a)
                    Console.WriteLine("Чисел, квадрат которых меньше введенного числа нет.");
                while (s * s < a)
                {
                    Console.Write($"{s} ");
                    s++;
                }
                Console.WriteLine("");
                Console.WriteLine($"Существует {s - 1} положительных целых чисел, квадрат которых меньше {a}");
            }
        }
    }
}
