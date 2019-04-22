using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToWordFormatProvider
{
    interface INumberFormatProvider
    {
        string Format(int value);
    }
}