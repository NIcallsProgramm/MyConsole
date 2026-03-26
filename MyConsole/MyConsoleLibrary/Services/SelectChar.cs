using System;
using System.Linq;
using System.Collections.Generic;

namespace MyConsole;

public partial class MyConsole
{
    public void SelectChar(char c, List<Cursor> buttons, out int SelectButton)
    {
        int indexW = 0;
        int oldindexW; if (indexW <= 0) oldindexW = 0; else oldindexW = indexW - 1;
        while (true)
        {
            Console.SetCursorPosition(buttons[oldindexW].X + buttons[oldindexW].Length, buttons[oldindexW].Y); Console.Write("  ");
            Console.SetCursorPosition(buttons[indexW].X + buttons[indexW].Length, buttons[indexW].Y); Console.Write(c);
            ConsoleKeyInfo input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.W:
                    indexW--;
                    oldindexW = indexW + 1;
                    if (indexW < 0) {indexW = buttons.Count - 1; oldindexW = 0;}
                    break;
                case ConsoleKey.UpArrow:
                    indexW--;
                    oldindexW = indexW + 1;
                    if (indexW < 0) { indexW = buttons.Count - 1; oldindexW = 0; }
                    break;

                case ConsoleKey.S:
                    indexW++;
                    if (indexW > buttons.Count - 1) indexW = 0; oldindexW = indexW - 1;
                    if (oldindexW < 0) oldindexW = buttons.Count - 1; break;
                case ConsoleKey.DownArrow:
                    indexW++;
                    if (indexW > buttons.Count - 1) indexW = 0; oldindexW = indexW - 1;
                    if (oldindexW < 0) oldindexW = buttons.Count - 1; break;
                case ConsoleKey.Enter:
                    SelectButton = indexW;
                    return;
                default: break;
            }
        }
    }
}
