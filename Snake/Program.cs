using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char symbl = '*';
            Draw(x1, y1, symbl);

            int x2 = 4;
            int y2 = 5;
            char symbl1 = '#';
            Draw(x2, y2, symbl1);
            Console.ReadLine();
        }
        static void Draw(int x, int y, char symbl)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbl);
        }
    }
}
