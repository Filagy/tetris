using System;

namespace TetrisNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            int x1 = 2;
            int y1 = 3;
            char z1 = '*';

            Drow(x1, y1, z1);

            int x2 = 4;
            int y2 = 6;
            char z2 = '#';

            Drow(x2, y2, z2);

            Console.ReadKey();

        }
        static void Drow(int x,int y, char z)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(z);
        }
    }
}
