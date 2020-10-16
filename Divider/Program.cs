using System;

namespace Divider
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int rep = 1;

                switch(a)
                {
                    case 0:
                        Console.WriteLine("Ошибка. введите ненулевое число");
                        continue;
                    case 1:
                        Console.WriteLine("Ошибка. введите число больше 1");
                        continue;
                }
                for (int i = 1; i <= a / 2; i++)
                {
                    if (a % i == 0)
                        rep = i;
                }

                Console.WriteLine("Наибольший делитель числа " + a + " равен " + rep);
            }
        }
    }
}
