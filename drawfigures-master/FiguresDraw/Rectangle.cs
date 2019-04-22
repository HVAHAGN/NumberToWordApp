using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FiguresDraw
{
    class Rectangle : Figures
    {
        public Rectangle() { }
        public Rectangle(byte length1, byte length2, char simbol)
        {
            Length1 = length1;
            Length2 = length2;
            Simbol = simbol;
        }
        public Rectangle(byte length)
        {
            Length1 = length;
            Length2 = 15;
            Simbol = '-';
        }
        public Rectangle(byte length, char simbol)
        {
            Length1 = length;
            Length2 = 15;
            Simbol = simbol;
        }
        public Rectangle(char simbol)
        {
            Length1 = 15;
            Length2 = 15;
            Simbol = simbol;
        }

        public void Draw(Rectangle rec)
        {
            if (Length1 > 0 && Length2 > 0)
            {
                for (int i = 0; i < Length1; i++)
                {
                    SetCursorPosition(60 - Length1 / 2 + i, 10);
                    Write(Simbol);
                    SetCursorPosition(60 - Length1 / 2 + i, 10 + Length2 / 2);
                    Write(Simbol);
                    System.Threading.Thread.Sleep(50);
                }
                for (int i = 0; i < Length2 / 2; i++)
                {
                    SetCursorPosition(60 - Length1 / 2, 10 + i);
                    Write(Simbol);
                    SetCursorPosition(60 - Length1 / 2 + Length1 - 1, 10 + i);
                    Write(Simbol);
                    System.Threading.Thread.Sleep(50);
                }
            }
        }
        public void RectInfo(Rectangle rec)
        {
            WriteLine();
            ForegroundColor = ConsoleColor.Red;
            SetCursorPosition(47, 5);
            WriteLine("This is your rectangle!");
            SetCursorPosition(60 - Length1 / 2, 9);
            WriteLine($"A1 = {Length1}, A2 = {Length2}");
            ResetColor();
            ForegroundColor = ConsoleColor.Blue;
            SetCursorPosition(60, 12);
            WriteLine($"S = {Length1 * Length2}");
            ForegroundColor = ConsoleColor.Cyan;
            SetCursorPosition(60, 13);
            WriteLine($"P = {Length1 * 2 + Length2 * 2}");
        }
    }
}