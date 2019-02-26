using SQLite;
using System;

namespace MarksClass
{
    public class Mark
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int Grade { get; set; }
        public int Weight { get; set; }
        public int Subject { get; set; }



        public Mark() { }

        public Mark(int grade, int weight, int subject)
        {
            Grade = grade;
            Weight = weight;
            Subject = subject;
        }
        
        


    }
}
