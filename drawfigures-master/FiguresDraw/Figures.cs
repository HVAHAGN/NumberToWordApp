using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace FiguresDraw
{
    class Figures
    {
        private byte length1;
        public byte Length1
        {
            get { return length1; }
            set
            {
                if (value <= Console.WindowWidth)
                    length1 = value;
                else
                {
                    Console.WriteLine("Value is higher than Console's WindowWidth. \nThe max WindowWidth value is 120. \nPlease try again");

                }
            }
        }
        private byte length2;
        public byte Length2
        {
            get { return length2; }
            set
            {
                if (value <= Console.WindowWidth)
                    length2 = value;
                else
                {
                    Console.WriteLine("Value is higher than Console's WindowWidth. \nThe max WindowWidth value is 120. \nPlease try again");

                }
            }
        }
        private char simbol;
        public char Simbol
        {
            get { return simbol; }
            set
            {
                if (char.IsLetterOrDigit(value) || char.IsWhiteSpace(value))
                    value = '-';

                simbol = value;
            }
        }
    }
}