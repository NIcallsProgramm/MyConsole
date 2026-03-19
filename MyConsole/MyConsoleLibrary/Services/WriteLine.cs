using System;
using System.Linq;
using System.Collections.Generic;

namespace MyConsole;

public partial class MyConsole
{
    public Cursor WriteLine(string input, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
    {
        Console.ForegroundColor = TC;
        Console.BackgroundColor = BgC;
        Console.Write(input);
        Console.ResetColor();
        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        Console.SetCursorPosition(0, y + 1);
        return new Cursor(x - (input.Length), y, input.Length);
    }
    public Cursor WriteLine(char input, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
    {

        
        Console.ForegroundColor = TC;
        Console.BackgroundColor = BgC;
        Console.Write(input);
        Console.ResetColor();
        Console.SetCursorPosition(0, Console.CursorTop + 1);
        return new Cursor(Console.CursorLeft, Console.CursorTop, 1);
    }
    public Cursor WriteLine(int iinput, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
    {
        string input = iinput.ToString();
        
        Console.ForegroundColor = TC;
        Console.BackgroundColor = BgC;
        Console.Write(input);
        Console.ResetColor();
        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        Console.SetCursorPosition(0, y + 1);
        return new Cursor(x - (input.Length), y, input.Length);
    }
    public Cursor WriteLine(bool iinput, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
    {
        string input = iinput.ToString();
        
        Console.ForegroundColor = TC;
        Console.BackgroundColor = BgC;
        Console.Write(input);
        Console.ResetColor();
        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        Console.SetCursorPosition(0, y + 1);
        return new Cursor(x - (input.Length), y, input.Length);
    }
    public Cursor WriteLine(double iinput, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
    {
        string input = iinput.ToString();
        
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
