using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;

namespace MarksClass
{
    public class dbAction
    {
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Database.db");
        public void Create()
        {
            var db = new SQLiteConnection(path);
            db.CreateTable<Mark>();
            db.CreateTable<Subjects>();

            Subjects English = new Subjects("English", 1);
            Subjects French = new Subjects("French", 2);
            List<Subjects> SubList = new List<Subjects>();
            SubList.Add(English);
            SubList.Add(French);

            //for (int i = 0; i < SubList.Count; i++)
            //{
            //    Insert(SubList[i]);
            //}


        }

        public void Insert(Mark mark)
        {
            var db = new SQLite.SQLiteConnection(path);
            
            db.Insert(mark);
           
        }
        public void Insert(Subjects subject)
        {
            var db = new SQLite.SQLiteConnection(path);
            db.Insert(subject);
            
        }

        public List<Mark> SelectOne(int id)
        {
            var db = new SQLiteConnection(path);

            return db.Query<Mark>("select * from Mark where ID = ?", id); 
        }

        public IEnumerable<Mark> QueryMarks()//Subjects subj)
        {
            var db = new SQLiteConnection(path);

            return db.Query<Mark>("select * from Mark");//where Subject = ?", subj.SubjectID);
        }

        public IEnumerable<Subjects> QuerySubjects()
        {
            var db = new SQLiteConnection(path);

            return db.Query<Subjects>("select * from Subjects");
        }

        public bool UpdateMark(Mark mark)
        {
            try
            {
                var db = new SQLiteConnection(path);

                db.Update(mark);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

            
        }
        public bool DeleteMark(int id)
        {
            try
            {
                var db = new SQLiteConnection(path);
                db.Delete<Mark>(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ObservableCollection<Averages> GetAverages()
        {
            ObservableCollection<Averages> avers = new ObservableCollection<Averages>();
            List<Mark> Marks = QueryMarks().ToList();
            List <Subjects> sub= QuerySubjects().ToList();

            for (int i = 0; i < Marks.Count; i++)
            {
                double Average = 0;
                double Grade = 0;
                string subject = "";
                int subID = 0;

                if (avers.Count != 0)
                {
                    for (int a = 0; a < avers.Count(); a++)
                    {
                        if (avers[a].SubID == Marks[i].Subject)
                        {
                            avers[a].
                        }
                    }
                }
                else
                {
                    for (int a = 0; a < sub.Count; a++)
                    {
                        if (Marks[i].Subject == sub[a].SubjectID)
                        {
                            subject = sub[a].Subject;
                            Average = (Marks[i].Grade * Marks[i].Weight) / Marks[i].Weight;
                            subID = Marks[i].Subject;
                            avers.Add(new Averages(Average, subject, subID));
                            a = sub.Count;
                        }
                    }
                }
                

                
            }
            
            return avers;
        }
    }
}
