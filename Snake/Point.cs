using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symb;

        public Point()
        {
        }

        public Point (int x, int y, char symb)
        {
            this.x = x;
            this.y = y;
            this.symb = symb;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
        
    }
}
