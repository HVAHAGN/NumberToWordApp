using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToWordFormatProvider
{
    class ArmNumberFormatter : INumberFormatProvider
    {
        static ArmNumberFormatter()
        {
            dic = new Dictionary<int, string>()
            {
                 { 0, "Զրո" },
                { 1, "Մեկ" },
                { 2, "Երկու" },
                { 3, "Երեք"},
                { 4, "Չորս"},
                { 5 ,"Հինգ"},
                { 6 ,"Վեց"},
                { 7 ,"Յոթ"},
                { 8 ,"Ութ"},
                { 9 ,"Ինը"},
                { 10 ,"Տաս"},
                { 11 ,"Տասնմեկ" },
                { 12 ,"Տասներկու" },
                { 13 ,"Տասներեք" },
                { 14 ,"Տասնչորս" },
                { 15 ,"Տասնհինգ" },
                { 16 ,"Տասնվեց" },
                { 17 ,"Տասնյոթ" },
                { 18 ,"Տասնութ" },
                { 19 ,"Տասնինը" },
                { 20 ,"Քսան" },
                { 30 ,"Երեսուն" },
                { 40 ,"Քառասուն" },
                { 50 ,"Հիսուն" },
                { 60 ,"Վաթուն" },
                { 70 ,"Յոթանասուն" },
                { 80 ,"Ութսուն" },
                { 90 ,"Իննսուն" },
                { 100 ,"Հարյուր" },
                { 1000 ,"Հազար" },
                { 1000000 ,"Միլիոն" },
                {1000000000, "Միլիարդ" }
            };
        }

        private static readonly Dictionary<int, string> dic;

        public string Format(int num)
        {
            if (num >= 0 && num <= 20)
                return dic[num];

            if ((num / 10) >= 2 && num < 100)
            {
                if (num % 10 != 0)
                    return dic[num - (num % 10)] + "-" + dic[num % 10];
                else
                    return dic[num];
            }

            if (num >= 100 && num < 1000)
            {
                if (num == 100)
                    return dic[1] + " " + dic[100];
                if (num % 100 == 0)
                    return dic[num / 100] + " " + dic[100];
                else
                    return dic[num / 100] + " " + dic[100] + " " + Format(num % 100);
            }

            if (num >= 1000 && num < 1000000)
            {
                if (num == 1000)
                    return dic[1] + " " + dic[1000];
                if (num % 1000 == 0)
                    return Format(num / 1000) + " " + dic[1000];
                else
                {
                    if (num / 1000 < 100)
                        return Format(num / 1000) + " " + dic[1000] + " " + Format(num % 1000);
                    else
                        return Format(num / 1000) + " " + dic[1000] + " " + Format(num % 1000);
                }
            }
            if (num >= 1000000 && num < 1000000000)  // million - milliard
            {
                if (num == 1000000)
                    return dic[num];
                if (num % 1000000 == 0)
                    return Format(num / 1000000) + " " + dic[1000000];
                else
                {
                    if (num / 1000000 < 100)
                        return Format(num / 1000000) + " " + dic[1000000] + " " + Format(num % 1000000);
                    else
                        return Format(num / 1000000) + " " + dic[1000000] + " " + Format(num % 1000000);
                }
            }
            return dic[0];
        }
    }
}
