using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddataPlusPlusMaria.Models
{

    // abstract to prevent this class from being instantiated
    abstract class Person: Subject
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
    }
}
