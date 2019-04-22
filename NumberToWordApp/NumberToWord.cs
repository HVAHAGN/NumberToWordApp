using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWordApp
{
    class NumberToWord
    {
         public static string ConvertNumberToWord(Dictionary<int, string> dic, int num)
         {
            if (num >= 0 && num <= 20)
                return dic[num];

            if ((num / 10) >= 2 && num < 100)
            {
                if (num % 10 != 0)
                {
                    if (dic[1] == "One")
                    {
                        return dic[num - (num % 10)] +" "+ dic[num % 10];
                    }
                    else
                    {
                        return dic[num - (num % 10)] + dic[num % 10];
                    }
                }
                else
                    return dic[num];
            }

            if (num >= 100 && num < 1000)
            {
                if (num == 100)
                    return dic[1] + " " +dic[100];
                if (num % 100 == 0)
                    return dic[num / 100] + " " + dic[100];
                else
                    return dic[num / 100] + " " + dic[100] + " " + ConvertNumberToWord(dic, num % 100) ;
            }

            if (num >= 1000 && num < 1000000)
            {
                if (num == 1000)
                    return dic[1] + " " + dic[1000];
                if (num % 1000 == 0)
                    return ConvertNumberToWord(dic, num / 1000) + " " + dic[1000];
                else
                {
                    if (num / 1000 < 100)
                        return ConvertNumberToWord(dic, num / 1000) + " " + dic[1000] + " " + ConvertNumberToWord(dic, num % 1000);
                    else
                        return ConvertNumberToWord(dic, num / 1000) + " " + dic[1000] + " " + ConvertNumberToWord(dic,num%1000);
                }
            }
            if (num >= 1000000 && num < 1000000000)  // million - milliard
            {
                if (num == 1000000)
                    return dic[num];
                if (num % 1000000 == 0)
                    return ConvertNumberToWord(dic,num / 1000000) + " " + dic[1000000];
                else
                {
                    if(num / 1000000 < 100)
                        return ConvertNumberToWord(dic, num / 1000000) + " " + dic[1000000] + " " + ConvertNumberToWord(dic, num % 1000000);
                    else
                        return ConvertNumberToWord(dic, num / 1000000) + " " + dic[1000000] + " " + ConvertNumberToWord(dic,num%1000000);
                }
            }
            return dic[0];
        }
        public static void Print(Dictionary<int, string> dic, int num)
        {
            if (num < 0)
                if(dic[1]=="One")
                {
                    Console.WriteLine("Minus " + ConvertNumberToWord(dic, Math.Abs(num)) + "  ");
                }
                else
                {
                    Console.WriteLine("Մինուս "+ConvertNumberToWord(dic, Math.Abs(num))+" ");
                }
                
            else
                Console.WriteLine("     " + ConvertNumberToWord(dic, num));
        }
    }
}
