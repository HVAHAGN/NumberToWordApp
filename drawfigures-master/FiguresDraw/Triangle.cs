using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace FiguresDraw
{
    class Triangle : Figures
    {

        public Triangle() { }
        public Triangle(byte length1, byte length2, char simbol)
        {
            Length1 = length1;
            Length2 = length2;
            Simbol = simbol;
        }
        public Triangle(byte length)
        {
            Length1 = length;
            Length2 = 15;
            Simbol = '-';
        }
        public Triangle(byte length, char simbol)
        {
            Length1 = length;
            Length2 = 15;
            Simbol = simbol;
        }
        public Triangle(char simbol)
        {
            Length1 = 15;
            Length2 = 15;
            Simbol = simbol;
        }

        public void Draw(Triangle tri)
        {
            if (Length1 > 0 && Length2 > 0)
            {
                SetCursorPosition(60, 10);
                Write(Simbol);
                for (int i = 0; i < Length1; i++)
                {

                    SetCursorPosition(60 - i, 10 + i);
                    Write(Simbol);
                    SetCursorPosition(60 + i, 10 + i);
                    Write(Simbol);
                }
                SetCursorPosition(60 - Length1, 10 + Length1);

                for (int i = 0; i < Length2; i++)
                {
                    Write(Simbol + " ");
                }
            }
        }
        public void TriangleInfo(Triangle tri)
        {
            ForegroundColor = ConsoleColor.Red;
            SetCursorPosition(46, 5);
            WriteLine("This is your triangle!");
            ResetColor();
            ForegroundColor = ConsoleColor.DarkYellow;
            SetCursorPosition(46, 7);
            WriteLine($"A = B = {Length1}, C = {Length2}");
            ResetColor();
            ForegroundColor = ConsoleColor.Cyan;
            SetCursorPosition(46, 9);
            WriteLine($"P = {Length1 * 2 + Length2}");
        }
    }

}