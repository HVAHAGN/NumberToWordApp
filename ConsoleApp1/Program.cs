using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToWordFormatProvider
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check Language");

            string lang;
            while (true)
            {
                Console.WriteLine("For English write eng");
                Console.WriteLine("For Armenian write arm");

                lang = Console.ReadLine();
                if (lang == "eng" || lang == "arm")
                    break;

                Console.WriteLine("Sxal...");
            }

            INumberFormatProvider provider;
            switch (lang)
            {
                case "arm":
                    provider = new ArmNumberFormatter();
                    break;

                default:
                    provider = new EngNumberFormatter();
                    break;
            }


            string value = provider.Format(125);
        }
    }
}
