using System;

namespace Pair_Impair_11_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите целое положительное число");
                int n = Convert.ToInt32(Console.ReadLine());
                int x = 0;

                for (int i = 1; i <= n; i++)
                {
                    int sum_p = 0;
                    int sum_imp = 0;
                    int buf = i;

                    while (buf % 10 != 0)
                    {
                        if ((buf % 10) % 2 == 0)
                            sum_p += buf % 10;
                        else if ((buf % 10) % 2 != 0)
                            sum_imp += buf % 10;
                        buf /= 10;
                    }
                    if (sum_p > sum_imp)
                        x++;
                }
                Console.WriteLine($"Количество чисел от 1 до {n}, сумма четных цифр которых больше суммы нечетных цифр равно {x}");
            }
        }
    }
}
