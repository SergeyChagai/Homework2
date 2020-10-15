using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число ");
            int a = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            while (i <= 1000)
            {
                if (i % a == 0)
                    Console.Write($"{i} ");
                i++;
            }
        }
    }
}
