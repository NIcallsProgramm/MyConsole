using System;
using System.Linq;
using System.Collections.Generic;

namespace MyConsole;
public partial class MyConsole
{
    public Cursor WriteCenter(string input, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
    {
        int CenterW = ((Console.WindowWidth - I) - input.Length) / 2;
        Console.SetCursorPosition(CenterW, Console.CursorTop);
        Console.ForegroundColor = TC;
        Console.BackgroundColor = BgC;
        Console.Write(input);
        Console.ResetColor();
        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        return new Cursor(x - (input.Length), Console.CursorTop, input.Length);
    }
    public Cursor WriteCenter(char input, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
    {
        int CenterW = (Console.WindowWidth - I) / 2;
        Console.SetCursorPosition(CenterW, Console.CursorTop);
        Console.ForegroundColor = TC;
        Console.BackgroundColor = BgC;
        Console.Write(input);
        Console.ResetColor();
        return new Cursor(Console.CursorLeft, Console.CursorTop, 1);
    }
    public Cursor WriteCenter(int iinput, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
    {
        string input = iinput.ToString();
        int CenterW = ((Console.WindowWidth - I) - input.Length) / 2;
        Console.SetCursorPosition(CenterW, Console.CursorTop);
        Console.ForegroundColor = TC;
        Console.BackgroundColor = BgC;
        Console.Write(input);
        Console.ResetColor();
        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        return new Cursor(x - (input.Length), Console.CursorTop, input.Length);
    }
    public Cursor WriteCenter(bool iinput, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
    {
        string input = iinput.ToString();
        int CenterW = ((Console.WindowWidth - I) - input.Length) / 2;
        Console.SetCursorPosition(CenterW, Console.CursorTop);
        Console.ForegroundColor = TC;
        Console.BackgroundColor = BgC;
        Console.Write(input);
        Console.ResetColor();
        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        return new Cursor(x - (input.Length), Console.CursorTop, input.Length);
    }
    public Cursor WriteCenter(double iinput, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
    {
        string input = iinput.ToString();
        int CenterW = ((Console.WindowWidth - I) - input.Length) / 2;
        Console.SetCursorPosition(CenterW, Console.CursorTop);
        Console.ForegroundColor = TC;
        Console.BackgroundColor = BgC;
        Console.Write(input);
        Console.ResetColor();
        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        return new Cursor(x - (input.Length), Console.CursorTop, input.Length);
    }
}