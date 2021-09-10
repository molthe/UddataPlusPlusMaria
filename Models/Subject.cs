using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddataPlusPlusMaria.Models
{
    //  public enum SubjectName { Danish, English, Abstract_Dance, Geometry, Astronomy, Chess}
    abstract class Subject
    {
        public int SubjectID { get; set; }

        public string SubjectName { get; set; }// Danish, English, Abstract_Dance, Geometry, Astronom

        // declare enums for subject
        public enum SubjectType { Language, Logical_Thinking, Practical, Arts }
    }
}
