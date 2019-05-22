using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork21._05._2019
{
   public  class Student
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public byte Age { get; set; }

        public override string ToString()
        {
            return $"{Name} {SurName} {Age}";
        }
    }
}
