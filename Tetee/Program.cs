using System;

namespace Tetee
{
    class Program
    {
      static Random random = new Random();

        static void Main()
        {
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


        

    }
}
