using System;

namespace Palindrom_10_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите целое положительное число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = 0;
                bool flag = false;

                if (a < 0)
                {
                    a *= -1;
                    flag = true;
                }

                while (a % 10 != 0)
                {
                    b = (b * 10) + (a % 10);
                    a /= 10;
                }

                Console.Write(b);
                if (flag == true)
                    Console.Write("-");
                Console.WriteLine();
            }
        }
    }
}