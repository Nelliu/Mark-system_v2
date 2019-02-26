using MarksClass;
using System;
using System.Collections.Generic;

namespace CMarks
{
    class Program
    {

        static void Main(string[] args)
        {
            dbAction Action = new dbAction();
            Action.Create();

            WriteMark Writeoff = new WriteMark();

            //Writeoff.WriteAllMarks();


            //while (true)
            //{
            //    try
            //    {
            //        int ToDelete1;
            //        string ToDelete = Console.ReadLine();
            //        bool parse = int.TryParse(ToDelete, out ToDelete1);



            //        if (Action.DeleteMark(ToDelete1) == true)
            //        {
            //            Console.Clear();
            //            Console.WriteLine("Everything is right " + ToDelete );
                        
            //            Writeoff.WriteAllMarks();
            //            break;
                        
                        
            //        }
            //        else
            //        {
            //            Console.Write("Something went wrong oof");
            //            Console.ReadLine();
            //            break;
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Something went wrong");
            //    }
            //}
            while(true)
            {
                Writeoff.WriteAllMarks();
                int ToUpdate;
                string ToUpI = Console.ReadLine();
                bool parse = int.TryParse(ToUpI, out ToUpdate);

                dbAction Action2 = new dbAction();

                List<Mark> Selected = Action2.SelectOne(ToUpdate);

                Console.Clear();
                Console.WriteLine("Grade: " + Selected[0].Grade);
                Console.WriteLine("Weight: " + Selected[0].Weight);
                Console.WriteLine();

                Console.WriteLine("New (or same grade): ");

                int ToUpdate1;
                string ToUpI1 = Console.ReadLine();
                bool parse1 = int.TryParse(ToUpI1, out ToUpdate1);

                Selected[0].Grade = ToUpdate1;

                int ToUpdate2;
                Console.WriteLine("Weight: ");
                string ToUpI2 = Console.ReadLine();
                bool parse2 = int.TryParse(ToUpI2, out ToUpdate2);

                Selected[0].Weight = ToUpdate2;

                Action2.UpdateMark(Selected[0]);


               












            }




        }

        public List<Subjects> SubjectList()
        {
            dbAction Action = new dbAction();
            List<Subjects> Subj = new List<Subjects>();
            IEnumerable<Subjects> Sub = Action.QuerySubjects();
            foreach (Subjects b in Sub)
            {
                Subj.Add(b);
            }
            return Subj;
        }

        
    }
}
