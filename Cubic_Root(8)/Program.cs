﻿using System;

namespace Cubic_Root_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите целое число, кубический корень которого хотите вычислить: ");
                int a = Convert.ToInt32(Console.ReadLine());
                double root = 0;
                double step = 1;
                bool flag = false;

                if (a < 0)
                {
                    a *= -1;
                    flag = true;
                }

                while (root * root * root != a && step >= 0.0000000001)
                {
                    if (root * root * root < a)
                        root += step;
                    else if (root * root * root > a)
                    {
                        root -= step;
                        step = step / 10;
                        root += step;
                    }
                }

                if (flag == true)
                    root *= -1;
                Console.WriteLine($"Кубический корень числа {a} равен {root}");
            }
        }
    }
}