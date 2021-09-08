using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddataPlusPlusMaria
{

    // abstract to prevent this class from being instantiated
    // this class inherits subject
    abstract class Person : Subject
    {
        public int id { get; set; }
        public string name { get; set; }
    }

}
