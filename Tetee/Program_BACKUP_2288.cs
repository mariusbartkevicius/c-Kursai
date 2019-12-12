using System;

namespace Tetee
{
    class Program
    {
      static Random random = new Random();

        static void Main()
        {
<<<<<<< HEAD
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

=======
            Console.Write("Ivesk skaiciu ir as pasakysiu as jis pirminis: ");
            Int32 skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CheckIsPrime(skaicius));

            Console.WriteLine(D20());

        }
        
        static bool CheckIsPrime(long number)
        {

            if (number <= 1)
                return false;
            else if (number % 2 == 0)
                return number == 2;

            long N = (long)(Math.Sqrt(number) + 0.5);

            for (int i = 3; i <= N; i += 2)
                if (number % i == 0)
                    return false;

            return true;


}
            static int D20()
            {
                return random.Next(0, 20) + 1;
            }


        
>>>>>>> master

    }
}
