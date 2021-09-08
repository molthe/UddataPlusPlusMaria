using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddataPlusPlusMaria
{
    // sealed to prevent this class from being used as a base class
    sealed class Student : Person
    {
        public int grade {  get; set; }
        public int warnings { get; set; }
    }
}
