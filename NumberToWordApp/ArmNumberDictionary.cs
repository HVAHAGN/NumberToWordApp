using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWordApp
{
    class ArmNumberDictionary
    {
        static public Dictionary<int, string> NumToWord()
        {
            var dic = new Dictionary<int, string>()
            {    
                #region
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
#endregion
            };
            return dic;
        }
    }
}
