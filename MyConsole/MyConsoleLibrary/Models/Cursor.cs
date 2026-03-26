using System;
using System.Linq;
using System.Collections.Generic;

namespace MyConsole.ASCII;

public class Cursor
{
    public int X;
    public int Y;
    public int Length;
    public Cursor(int x, int y, int length = 0)
    {
        X = x; Y = y; Length = length;
    }
}
