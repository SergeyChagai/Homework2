using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите номер числа из последовательности Фибоначчи, которое хотите узнать: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int f = 1;
                int f_n_1 = 1;                                          //это для записи предыдущего числа

                for (int i = 3; i <= n; i++)
                {
                    int buf = f;
                    f += f_n_1;
                    f_n_1 = buf;
                }

                Console.WriteLine(f);
            }
        }
    }
}
