using System;

namespace Tetee
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            Console.WriteLine("start :" + number);
            Kazkas(number);
            Console.WriteLine("after normal :" + number);
            Kazkas2(ref number);
            Console.WriteLine("after ref :" + number);
            Kazkas3(out number);
            Console.WriteLine("after out :" + number);

        }


        static int Kazkas(int sk)
        {
            sk = sk * 2;
            return sk;

        }

        static int Kazkas2(ref int sk)
        {
            sk = sk * 2;
            return sk;

        }

        static int Kazkas3(out int sk)
        {
            sk = 3;
            sk = sk * 2;
            return sk;

        }
    }
}
