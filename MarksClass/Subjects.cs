using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarksClass
{
    public class Subjects
    {
        [PrimaryKey]
        public int SubjectID { get; set; }
        public string Subject { get; set; }
       

        public double Average { get; set; }
        public List<double> Weights {get; set; }
        public List<double> Marks { get; set; }



        public Subjects() { }
        public Subjects(string subject, int subjectID)
        {
            Subject = subject;
            SubjectID = subjectID;
        }
    }
}
