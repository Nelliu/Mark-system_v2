using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarksClass;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
namespace Marks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {

        dbAction Action = new dbAction();
        ObservableCollection<Subjects> SubjectsX = new ObservableCollection<Subjects>();
        ObservableCollection<Mark> Marks = new ObservableCollection<Mark>(); // pro db
        ObservableCollection<GradeClass> Grades = new ObservableCollection<GradeClass>();

        public TabbedPage1 ()
        {
            InitializeComponent();
            Action.Create();
            AtAppStart();


        }

        private void AtAppStart()
        {
            SubjectsX = new ObservableCollection<Subjects>(Action.QuerySubjects().ToList());
            foreach (Subjects b in SubjectsX)
            {
                SPick.Items.Add(b.Subject);    
            }
            Marks = new ObservableCollection<Mark>(Action.QueryMarks().ToList());

            string subj = "";
            for (int i = 0; i < Marks.Count(); i++)
            {
                for (int a = 0; a < SubjectsX.Count(); a++)
                {
                    if (Marks[i].Subject == SubjectsX[a].SubjectID)
                    {
                        subj = SubjectsX[a].Subject;
                    }
                }

                GradeClass NGrade = new GradeClass(Marks[i].Grade, Marks[i].Weight, subj, Marks[i].Subject);
                Grades.Add(NGrade);

            }

            AddedMarks.ItemsSource = Grades;

            



        }

        private void AddMarkToList(object sender, EventArgs e)
        {
            var selectedGradeV = GPick.SelectedItem.ToString();
            bool SgradetoInt = int.TryParse(selectedGradeV, out int selectedGrade); // parse Selected grade to int "selectedGrade"
            bool a = int.TryParse(WPick.Text, out int weight);  // parse Weight pick to int "weight"
            string subject = SPick.SelectedItem.ToString();
            int subID = 0;

            for (int i = 0; i < SubjectsX.Count(); i++)
            {
                if (SubjectsX[i].Subject == subject)
                {
                    subID = SubjectsX[i].SubjectID;
                }

            }
            Mark mark = new Mark(selectedGrade, weight, subID);
            Marks.Add(mark);
            Action.Insert(mark);


            GradeClass Grade = new GradeClass(selectedGrade, weight, subject, subID);
            Grades.Add(Grade);
           
            
            

        }


    }
}