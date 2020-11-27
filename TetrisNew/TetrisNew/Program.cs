using System;

namespace TetrisNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

          

            Point p1 = new Point();

            p1.x = 2;
            p1.y = 3;
            p1.z = '*';

            p1.Draw();


            Point p2 = new Point();

            p2.x = 6;
            p2.y = 9;
            p2.z = '#';

            p2.Draw();





            Console.ReadKey();

        }
      
    }
}
