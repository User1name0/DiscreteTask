using System;
using System.Linq;

namespace PerfectNumbers
{
    public class Program
    {
        public static void Main()
        {

            int sum;

            Console.WriteLine("Enter Num 1");
            int Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Num 2");
            int Num2 = int.Parse(Console.ReadLine());

            for (int x = Num1; x <= Num2; x++)

            {

                sum = 0;

                for (int Num3 = 1; Num3 < x; Num3++)

                {

                    if (x % Num3 == 0)

                    {

                        sum += Num3;

                    }
                }

                if (sum == x)

                {

                    Console.WriteLine(x + "  is perfect");

                }
            }
        }
    }

}