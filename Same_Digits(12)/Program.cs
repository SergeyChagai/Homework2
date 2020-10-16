using System;

namespace Same_Digits_12_
{
    class Program
    {
        static int Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите два числа: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                bool rep = false;

                if (a < 0)
                    a *= -1;
                if (b < 0)
                    b *= -1;
                while (a % 10 != 0)
                {
                    while (b % 10 != 0)
                    {
                        if (a % 10 == b % 10)
                        {
                            rep = true;
                            break;
                        }
                        b /= 10;
                    }
                    if (a % 10 == b % 10)
                        break;
                    a /= 10;
                }

                switch (rep)
                {
                    case false:
                        Console.WriteLine("В этих числах нет одинаковых цифр");
                        break;
                    case true:
                        Console.WriteLine("В этих числах есть одинаковые цифры");
                        break;
                    }
            }
        }
    }
}
