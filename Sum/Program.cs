using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите два числа");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int rep = 0;

                if (a > b)
                {
                    int buf = a;
                    a = b;
                    b = buf;
                }

                while (a <= b)
                {
                    if (a % 7 == 0)
                    {
                        rep += a;
                        //Console.Write(a + " ");               чтобы вывести промежуточные значения
                    }
                    a++;
                }

                //Console.WriteLine();                          чтобы ответ был с новой строки
                Console.WriteLine(rep);
            }
        }
    }
}
