using System;
using System.Linq;
using System.Collections.Generic;

namespace MyConsole;

public partial class MyConsole
{
    public Cursor WriteLine(string input, string pos = null, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
    {
        int _windowwidth = Console.WindowWidth - I;
        int _center = (Console.WindowWidth - I) / 2;
        pos = pos.ToLower();
        switch (pos)
        {
            case null:
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop); break;
            case "left":
                Console.SetCursorPosition(8, Console.CursorTop); break;
            case "center":
                Console.SetCursorPosition(_center - input.Length, Console.CursorTop); break;
            case "right":
                Console.SetCursorPosition(_windowwidth - 8 - input.Length, Console.CursorTop); break;
            default: break;
        }
        Console.ForegroundColor = TC;
        Console.BackgroundColor = BgC;
        Console.Write(input);
        Console.ResetColor();
        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        Console.SetCursorPosition(0, y + 1);
        return new Cursor(x - (input.Length), y, input.Length);
    }

    public Cursor WriteLine(char input, string pos = null, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
    {
        int _windowwidth = Console.WindowWidth - I;
        int _center = (Console.WindowWidth - I) / 2;
        pos = pos.ToLower();
        switch (pos)
        {
            case null:
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop); break;
            case "left":
                Console.SetCursorPosition(8, Console.CursorTop); break;
            case "center":
                Console.SetCursorPosition(_center - 1, Console.CursorTop); break;
            case "right":
                Console.SetCursorPosition(_windowwidth - 8 - 1, Console.CursorTop); break;
            default: break;
        }
        Console.ForegroundColor = TC;
        Console.BackgroundColor = BgC;
        Console.Write(input);
        Console.ResetColor();
        Console.SetCursorPosition(0, Console.CursorTop + 1);
        return new Cursor(Console.CursorLeft, Console.CursorTop, 1);
    }

    public Cursor WriteLine(int iinput, string pos = null, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
    {
        int _windowwidth = Console.WindowWidth - I;
        int _center = (Console.WindowWidth - I) / 2;
        string input = iinput.ToString();
        pos = pos.ToLower();
        switch (pos)
        {
            case null:
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop); break;
            case "left":
                Console.SetCursorPosition(8, Console.CursorTop); break;
            case "center":
                Console.SetCursorPosition(_center - 1, Console.CursorTop); break;
            case "right":
                Console.SetCursorPosition(_windowwidth - 8 - 1, Console.CursorTop); break;
            default: break;
        }
        Console.ForegroundColor = TC;
        Console.BackgroundColor = BgC;
        Console.Write(input);
        Console.ResetColor();
        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        Console.SetCursorPosition(0, y + 1);
        return new Cursor(x - (input.Length), y, input.Length);
    }

    public Cursor WriteLine(bool iinput, string pos = null, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
    {
        int _windowwidth = Console.WindowWidth - I;
        int _center = (Console.WindowWidth - I) / 2;
        string input = iinput.ToString();
        pos = pos.ToLower();
        switch (pos)
        {
            case null:
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop); break;
            case "left":
                Console.SetCursorPosition(8, Console.CursorTop); break;
            case "center":
                Console.SetCursorPosition(_center - 1, Console.CursorTop); break;
            case "right":
                Console.SetCursorPosition(_windowwidth - 8 - 1, Console.CursorTop); break;
            default: break;
        }
        Console.ForegroundColor = TC;
        Console.BackgroundColor = BgC;
        Console.Write(input);
        Console.ResetColor();
        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        Console.SetCursorPosition(0, y + 1);
        return new Cursor(x - (input.Length), y, input.Length);
    }

    public Cursor WriteLine(double iinput, string pos = null, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
    {
        int _windowwidth = Console.WindowWidth - I;
        int _center = (Console.WindowWidth - I) / 2;
        string input = iinput.ToString();
        pos = pos.ToLower();
        switch (pos)
        {
            case null:
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop); break;
            case "left":
                Console.SetCursorPosition(8, Console.CursorTop); break;
            case "center":
                Console.SetCursorPosition(_center - 1, Console.CursorTop); break;
            case "right":
                Console.SetCursorPosition(_windowwidth - 8 - 1, Console.CursorTop); break;
            default: break;
        }
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