using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    static public class Position
    {
        public static Cursor Left()
        {
            return new Cursor(8, Console.CursorTop);
        }
        public static Cursor Center(int I = 0)
        {
            int _windowwidth = Console.WindowWidth - I;
            int _center = (Console.WindowWidth - I) / 2;
            return new Cursor(_center, Console.CursorTop);
        }
        public static Cursor Right(int I = 0)
        {
            int _windowwidth = Console.WindowWidth - I - 8;
            return new Cursor(_windowwidth, Console.CursorTop);
        }

    }
}