using System;
using System.Linq;
using System.Collections.Generic;

namespace MyConsole;

public partial class MyConsole
{
    public void SelectChar(char c, Cursor curretpos, Cursor oldpos)
    {
        Console.SetCursorPosition(oldpos.X + oldpos.Length - 1, oldpos.Y); Console.Write(' ');
        Console.SetCursorPosition(curretpos.X + curretpos.Length, curretpos.Y); Console.Write(c);
    }
}
