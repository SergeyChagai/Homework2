using System;

namespace Cubic_Root_8_2__
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите целое число, кубический корень которого хотите вычислить: ");
                double n;
                n = Convert.ToInt32(Console.ReadLine());
                double rightBoarder = n;
                double leftBoarder = 0;
                double midPoint = 0;
               
                while (rightBoarder - leftBoarder >= 0.000001)
                {
                    midPoint = (leftBoarder + rightBoarder) / 2;

                    if (midPoint * midPoint * midPoint == n)
                        break;
                    if (midPoint * midPoint * midPoint > n)
                    {
                        rightBoarder = midPoint;
                    }
                    else
                    {
                        leftBoarder = midPoint;
                    }
                }
                Console.WriteLine(midPoint);
            }
        }

    }
}
    

