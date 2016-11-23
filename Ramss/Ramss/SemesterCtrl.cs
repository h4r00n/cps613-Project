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
    public partial class SemesterCtrl : UserControl
    {
        private List<String> currentCourses = new List<string>();

        public List<String> Courses
        {
            get { return currentCourses; }
            set { currentCourses = value;
                CourseList.Items.Clear();
                foreach (string course in currentCourses ){
                    CourseList.Items.Add(course);
                }
            }
        }

        public SemesterCtrl()
        {
            InitializeComponent();
        }
    }
}
