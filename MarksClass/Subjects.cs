using System;
using System.Collections.Generic;
using System.Text;

namespace MarksClass
{
    public class Subjects
    {
        public string Subject { get; set; }
        public int SubjectID { get; set; }

        public Subjects() { }
        public Subjects(string a, int b)
        {
            Subject = a;
            SubjectID = b;
        }
    }
}
