using MarksClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMarks
{
    public class WriteMark
    {
        public void WriteAllMarks()
        {
            dbAction Action = new dbAction();

            IEnumerable<Mark> Mar = Action.QueryMarks();
            foreach (Mark a in Mar)
            {
                switch (a.Subject)
                {

                    case 1:
                        Console.WriteLine("English: " + a.Grade);
                        Console.WriteLine("Weight: " + a.Weight);
                        Console.WriteLine("ID: " + a.ID);
                        Console.WriteLine();

                        break;

                    case 2:
                        Console.WriteLine("French: " + a.Grade);
                        Console.WriteLine("Weight: " + a.Weight);
                        Console.WriteLine("ID: " + a.ID);
                        Console.WriteLine();

                        break;

                    case 3:
                        Console.WriteLine("PE: " + a.Grade);
                        Console.WriteLine("Weight: " + a.Weight);
                        Console.WriteLine("ID: " + a.ID);
                        break;

                }

            }
        }
    }
   
}
