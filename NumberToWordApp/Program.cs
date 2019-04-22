using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWordApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var numToEngWord = EngNumberDictionary.NumToWord();
            var numToArmWord = ArmNumberDictionary.NumToWord();

            Paint1();

            int yourNumber = Int32.Parse(Console.ReadLine());
            int a = yourNumber;

            Paint2(yourNumber);
            NumberToWord.Print(numToEngWord, yourNumber);
            Paint3(yourNumber);
            NumberToWord.Print(numToArmWord, yourNumber);
            Console.Read();
        }
        static public void Paint1()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(49, 8);
            Console.WriteLine("Please enter your number");
            Console.SetCursorPosition(55, 10);
            Console.WriteLine("-------------");
            Console.SetCursorPosition(54, 11);
            Console.WriteLine("-             -");
            Console.SetCursorPosition(55, 12);
            Console.WriteLine("-------------");
            Console.SetCursorPosition(57, 11);

        }
        static public void Paint2(int a)
        {
            if (a < 10)
                Console.SetCursorPosition(55, 15);
            else if(a < 100)
                Console.SetCursorPosition(52, 15);
            else if(a < 1000)
                Console.SetCursorPosition(46, 15);
            else if (a < 100000)
                Console.SetCursorPosition(37, 15);
            else if (a<1000000)
                Console.SetCursorPosition(28, 15);
            else
                Console.SetCursorPosition(18, 15);
        }
        static public void Paint3(int a)
        {
            if (a < 10)
                Console.SetCursorPosition(55, 17);
            else if (a < 100)
                Console.SetCursorPosition(52, 17);
            else if (a < 1000)
                Console.SetCursorPosition(46, 17);
            else if (a < 100000)
                Console.SetCursorPosition(37, 17);
            else if (a < 1000000)
                Console.SetCursorPosition(28, 17);
            else
                Console.SetCursorPosition(18, 17);
        }
    }
}
