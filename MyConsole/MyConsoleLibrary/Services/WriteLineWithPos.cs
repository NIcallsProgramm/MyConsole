using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    partial class MyConsole
    {
        public Cursor WriteLine(string input, Cursor pos, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
        {
            Console.SetCursorPosition(pos.X - input.Length, pos.Y);
            Console.ForegroundColor = TC;
            Console.BackgroundColor = BgC;
            Console.Write(input);
            Console.ResetColor();
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            Console.SetCursorPosition(0, y + 1);
            return new Cursor(x - (input.Length), y, input.Length);
        }
        public Cursor WriteLine(char input, Cursor pos, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
        {

            Console.SetCursorPosition(pos.X - 1, pos.Y);
            Console.ForegroundColor = TC;
            Console.BackgroundColor = BgC;
            Console.Write(input);
            Console.ResetColor();
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            return new Cursor(Console.CursorLeft, Console.CursorTop, 1);
        }
        public Cursor WriteLine(int iinput, Cursor pos, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
        {
            string input = iinput.ToString();
            Console.SetCursorPosition(pos.X - input.Length, pos.Y);
            Console.ForegroundColor = TC;
            Console.BackgroundColor = BgC;
            Console.Write(input);
            Console.ResetColor();
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            Console.SetCursorPosition(0, y + 1);
            return new Cursor(x - (input.Length), y, input.Length);
        }
        public Cursor WriteLine(bool iinput, Cursor pos, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
        {
            string input = iinput.ToString();
            Console.SetCursorPosition(pos.X - input.Length, pos.Y);
            Console.ForegroundColor = TC;
            Console.BackgroundColor = BgC;
            Console.Write(input);
            Console.ResetColor();
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            Console.SetCursorPosition(0, y + 1);
            return new Cursor(x - (input.Length), y, input.Length);
        }
        public Cursor WriteLine(double iinput, Cursor pos, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
        {
            string input = iinput.ToString();
            Console.SetCursorPosition(pos.X - input.Length, pos.Y);
            Console.ForegroundColor = TC;
            Console.BackgroundColor = BgC;
            Console.Write(input);
            Console.ResetColor();
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            Console.SetCursorPosition(0, y + 1);
            return new Cursor(x - (input.Length), y, input.Length);
        }
    }
}
