using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace MarksClass
{
    public class Averages
    {
        public double Average { get; set; }
        public string Subject { get; set; }
        public int SubID { get; set; }
        

       public Averages()
        {

        }
        public Averages(double average, string subject, int subID)
        {
            Average = average;
            Subject = subject;
            SubID = subID;
        }



    }
}
