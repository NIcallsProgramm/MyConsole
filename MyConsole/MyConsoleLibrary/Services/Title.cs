using System;
using System.Linq;
using System.Collections.Generic;

namespace MyConsole;

public partial class MyConsole
{
    public Cursor Title(ConsoleColor BgC = ConsoleColor.Black)
    {
        string title = new string(' ', Console.WindowWidth - I);
        Console.BackgroundColor = BgC;
        Console.Write(title);
        int y = Console.CursorTop;
        Console.SetCursorPosition(0, y + 1);
        Console.ResetColor();
        return new Cursor(0, y, title.Length);
    }
    public Cursor TitleText(string input, ConsoleColor TC = ConsoleColor.White, ConsoleColor BgC = ConsoleColor.Black)
    {
        int WindowsWidth = Console.WindowWidth - I;
        string title = new string(' ', (WindowsWidth - input.Length) / 2);
        Console.BackgroundColor = BgC;
        Console.ForegroundColor = TC;
        Console.Write(title);
        Console.Write(input);
        Console.Write(title);
        int y = Console.CursorTop;
        Console.SetCursorPosition(0, y + 1);
        Console.ResetColor();
        return new Cursor(0, y, title.Length);
    }

}
