using System;

namespace Tetee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Max(1, 2, 3));
            Console.WriteLine(Max(4, 2, 3));
            Console.WriteLine(Max(1, 5, 3));
            Console.WriteLine(Max(6, 6, 6));

            Console.WriteLine(IfNumberInRange(5, 0, 10));
            Console.WriteLine(IfNumberInRange(-5, 0, 10));
            Console.WriteLine(IfNumberInRange(-5, 10, 0));
            Console.WriteLine(IfNumberInRange(5, 5, 5));
        }


        static int Max(int sk1, int sk2, int sk3)
        {

            if (sk1 > sk2 && sk1 > sk3)
            {
                return sk1;
            }
            else if (sk2 > sk3)
            {

                return sk2;
            } else

                return sk3;

        }


        static bool IfNumberInRange(int skaicius, int minValue, int maxValue)
        {
            if (minValue > maxValue)
            {
                Console.WriteLine("Demesio, blogi skaiciai");
            }

            bool answer = skaicius >= minValue && skaicius <= maxValue;
            return answer;
        }


    }
}
