using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FiguresDraw
{
    class Line : Figures
        {
            public Line() { }
            public Line(byte length, char simbol)
            {
                Length1 = length;
                Simbol = simbol;
            }
            public Line(byte length)
            {
                Length1 = length;
                Simbol = '-';
            }
            public Line(char simbol)
            {
                Simbol = simbol;
                Length1 = 15;
            }

            public virtual void Draw(Line li)
            {
                if (Length1 > 0)
                {
                    for (int i = 0; i < Length1; i++)
                    {
                        System.Threading.Thread.Sleep(55);
                        SetCursorPosition(60 - Length1/2 + i, 16);
                        Write(Simbol);
                    }
                }
            }
            public void LineInfo(Line li)
            {
                   ForegroundColor = ConsoleColor.Red;
                   SetCursorPosition(47, 10);
                   WriteLine($"This is your line!");
                   ForegroundColor = ConsoleColor.Cyan;
                   SetCursorPosition(47, 13);
                   WriteLine($"Your line's length = {Length1}");
                   ResetColor();
            }
    }
}