using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ramss
{
    public partial class TermGradeCtrl : UserControl
    {
        //private Semester sem;
        private double termGPA = 0;
        public void setTerm(Semester sem)
        {
            double gpa = 0;
            double courses = 0;
            foreach (string course in sem.courseList)
            {
                double cGrade = 0;
                sem.courseGrade.TryGetValue(course, out cGrade);
                gpa += cGrade;
                courses++;
                this.dataGridView1.Rows.Add(course, cGrade);
                gpaLabel.Text = termGPA.ToString();
            }
            termGPA = gpa / courses;
            this.termNumLabel.Text = sem.semesterNum.ToString();
        }
        public TermGradeCtrl()
        {
            InitializeComponent();
            //dataGridView1.AllowUserToAddRows = true;
        }
    }
}
