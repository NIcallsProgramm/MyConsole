using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using MyConsole;

namespace MyConsole;

public static class Program
{
    public static void Main()
    {
        MyConsole Display = new MyConsole();
        bool h = false;
        float w = 7666f;
        int SelectButton;
        List<Cursor> Buttons = new List<Cursor>();
        Display.Title(ConsoleColor.Yellow);
        Display.TitleText("Gamememe", default, ConsoleColor.Yellow);
        Buttons.Add(Display.WriteLine("Старт", Position.Center()));
        Buttons.Add(Display.WriteLine("Авторы", Position.Center()));
        Buttons.Add(Display.WriteLine("Настройки", Position.Center()));
        Buttons.Add(Display.WriteLine("Выход", Position.Center()));
        Display.SelectChar('-', Buttons, out SelectButton);
        Console.Clear();
        switch (SelectButton)
        {
            case 0:
                Display.WriteLine("Старт"); break;
            case 1:
                Display.WriteLine("Авторы"); break;
            case 2:
                Display.WriteLine("Настройки"); break;
            case 3:
                Display.WriteLine("Выход"); break;
            default: break;
        }
    }
}
