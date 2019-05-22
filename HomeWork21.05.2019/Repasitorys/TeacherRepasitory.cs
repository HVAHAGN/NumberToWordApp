using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork21._05._2019
{
    public class TeacherRepasitory : BaseRepastiory<Teacher>
    {
        public TeacherRepasitory(string fileName, IFormatProvider<Teacher> provider)
            : base(fileName, provider)
        {
        }
    }
}
