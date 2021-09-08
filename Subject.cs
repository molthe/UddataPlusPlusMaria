using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UddataPlusPlusMaria
{
    abstract class Subject
    {
        // declare enums for subject
        enum subjectName { Danish, English, Abstract_Dance, Geometry, Astronomy }
        public int SubjectID { get; set; }
    }
}
