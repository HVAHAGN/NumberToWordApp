using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FiguresDraw
{
    class Square : Figures
    {
        public Square() { }
        public Square(byte length, char simbol)
        {
            Length1 = length;
            Simbol = simbol;
        }
        public Square(byte length)
        {
            Length1 = length;
            Simbol = '-';
        }
        public Square(char simbol)
        {
            Length1 = 15;
            Simbol = simbol;
        }

        public void Draw(Square sq)
        {
            if (Length1 > 0)
            {
                for (int i = 0; i < Length1; i++)
                {
                    SetCursorPosition(60 - Length1 / 2 + i, 10);
                    Write(Simbol);
                    SetCursorPosition(60 - Length1 / 2 + i, 10 + Length1 / 2);
                    Write(Simbol);
                    System.Threading.Thread.Sleep(50);
                }
                for (int i = 0; i < Length1 / 2; i++)
                {
                    SetCursorPosition(60 - Length1 / 2, 10 + i);
                    Write(Simbol);
                    SetCursorPosition(60 - Length1 / 2 + Length1 - 1, 10 + i);
                    Write(Simbol);
                    System.Threading.Thread.Sleep(50);
                }
            }
        }
        public void SquareInfo(Square sq)
        {
            ForegroundColor = ConsoleColor.Red;
            SetCursorPosition(46, 1);
            WriteLine("This is your square!");
            SetCursorPosition(46, 2);
            WriteLine($"Length of your square = {Length1}");
            ForegroundColor = ConsoleColor.Green;
            SetCursorPosition(60 - Length1 / 2, 9);
            WriteLine($"A = B = C = D = {Length1}");
            ResetColor();
            ForegroundColor = ConsoleColor.Blue;
            SetCursorPosition(60, 12);
            WriteLine($"S = {4 * Length1}");
            ForegroundColor = ConsoleColor.Cyan;
            SetCursorPosition(60, 11);
            WriteLine($"P {Length1 + Length1 + Length1 + Length1}");
        }
    }
}