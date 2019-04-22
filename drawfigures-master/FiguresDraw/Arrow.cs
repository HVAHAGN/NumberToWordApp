using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FiguresDraw
{
    class Arrow :  Line
    {

        private char arrow { get; } = '>';
        public Arrow()
        {
            arrow = '>';
        }
        public Arrow(byte length, char simbol)
        {
            Length1 = length;
            Simbol = simbol;
            arrow = '>';
        }
        public Arrow(byte length)
        {
            Length1 = length;
            Simbol = '-';
            arrow = '>';
        }
        public Arrow(char simbol)
        {
            Simbol = simbol;
            Length1 = 15;
            arrow = '>';
        }
        public override void Draw(Line li)
        {
            base.Draw(li);
            WriteLine(arrow);
        }
        public void ArrowInfo(Arrow li)
        {
            ForegroundColor = ConsoleColor.Red;
            SetCursorPosition(47, 10);
            WriteLine($"This is your arrow!");
            ForegroundColor = ConsoleColor.Cyan;
            SetCursorPosition(47, 13);
            WriteLine($"Your arrow's length = {Length1}");
            ResetColor();
        }
    }
}