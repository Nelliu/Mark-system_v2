using System;
using System.Collections.Generic;
using System.Text;

namespace Marks
{
    public class GradeClass
    {
        public string Grade { get; set; }
        public string Weight { get; set; }
        public string Subject { get; set; }
        public int SubID { get; set; }
     

    
        public GradeClass(int grade, int weight, string subj, int sID)
        {
            Grade = "Grade: " + grade;
            Weight = "Average: " + weight;
            Subject = subj;
            SubID = sID;
           
        }
    }
}
