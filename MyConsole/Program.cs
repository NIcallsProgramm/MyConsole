using System;
using System.Linq;
using System.Collections.Generic;
using MyConsole;

namespace MyConsole;

public static class Program
{
    public static void Main()
    {
        MyConsole Display = new MyConsole(20);
        bool h = false;
        float w = 7666f;
        int indexW = 0;
        int indexH = 0;
        Cureor Default = new Cursor();
        Cursor Center = new Cursor();
        Cursor Left = new Cursor();
        Dictionary Position = new Dictionary();
        ConsoleKeyInfo input;
        List<Cursor> coords = new List<Cursor>();

        Display.Title(ConsoleColor.Yellow);
        Display.TitleText("Gamememe", default, ConsoleColor.Yellow);
        coords.Add(Display.WriteLine("button1"));
        coords.Add(Display.WriteLine("button2"));
        coords.Add(Display.WriteLine("button3"));
        coords.Add(Display.WriteLine("button4"));
        while (true)
        {
            Display.SelectChar('<', coords[indexW], coords[indexW]);
            input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.A:
                    indexH--; break;
                case ConsoleKey.D:
                    indexH++; break;
                case ConsoleKey.W:
                    indexW = Math.Max(0, indexW--); break;
                case ConsoleKey.S:
                    indexW = Math.Min(indexW, indexW++); break;
                default: break;
            }
        }
        //Console.WriteLine(w);

    }
}
