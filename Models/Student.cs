using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddataPlusPlusMaria.Models
{
    // sealed to prevent this class from being used as a base class
    sealed class Student : Person
    {
        public int Grade {  get; set; }
        public int Warnings { get; set; }
    }
}
