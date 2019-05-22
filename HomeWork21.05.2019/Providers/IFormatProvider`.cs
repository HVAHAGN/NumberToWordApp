using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork21._05._2019
{
    public interface IFormatProvider<T>
    {
        string Serialize(T model);
        T Deserialize(string model);
    }
}
