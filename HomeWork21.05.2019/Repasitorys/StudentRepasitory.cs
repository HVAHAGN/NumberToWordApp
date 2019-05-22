using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork21._05._2019
{
    public class StudentRepasitory : BaseRepastiory<Student>
    {
        public StudentRepasitory(string fileName, IFormatProvider<Student> provider) 
            : base(fileName, provider)
        {
        }
    }
}
