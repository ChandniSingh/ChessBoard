using System;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solution1");
            Solution2();

            Console.WriteLine();

            Console.WriteLine("Solution2");

            Solution1();

        }

        private static void Solution2()
        {
            for (int t = 0; t < 4; t++)
            {

                for (int i = 0; i < 4; i++)
                {
                    Console.Write("xo");

                }
                Console.WriteLine("");

                for (int i = 0; i < 4; i++)
                {
                    Console.Write("ox");

                }
                Console.WriteLine("");

            }
        }

        private static void Solution1()
        {
            for (int y = 0; y < 8; y++)
            {



                for (int r = 0; r < 8; r++)
                {
                    if ((r + y) % 2 == 0)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write("o");
                    }


                }
                Console.WriteLine();

            }
        }
    }
}
