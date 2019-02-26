using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace MarksClass
{
    public class Averages
    {
        public int Grade { get; set; }
        public double Average { get; set; }
        public string Subject { get; set; }


       public Averages()
        {

        }
        public Averages(int grade, double average, string subject)
        {
            Grade = grade;
            Average = average;
            Subject = subject; 
        }



    }
}
