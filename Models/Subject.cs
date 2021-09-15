using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddataPlusPlusMaria.Models
{
    //  public enum SubjectName { Danish, English, Abstract_Dance, Geometry, Astronomy, Chess}
    class Subject
    {
        public int SubjectID { get; set; }

        // public string SubjectName { get; set; }// Danish, English, Abstract_Dance, Geometry, Astronom
        //  Language, Logical_Thinking, Practical, Arts
        // declare enums for subject
        public enum SubjectName { Danish, English, Abstract_Dance, Geometry, Astronomy }
    }
}
