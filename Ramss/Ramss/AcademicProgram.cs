using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramss
{
    class AcademicProgram
    {
        public String progMajor = "Computer Science";
        public String progMinor = "N/A";
        public SortedList<int, Semester> prevSemesters;
        public Semester currentSemester;
        public Semester winterSemester;

        public void init()
        {
            this.prevSemesters = new SortedList<int, Semester>();
            //initialize prev semesters
            this.currentSemester = new Semester();
            this.currentSemester.init(this.prevSemesters.Count + 1);
            this.winterSemester = new Semester();
            this.winterSemester.init(this.prevSemesters.Count + 2);
            this.initPrevSems();
        }

        public void setMajor(String newMajor)
        {
            this.progMajor = newMajor;
        }
        public void setMinor(String newMinor)
        {
            this.progMinor = newMinor;
        }

        public void initPrevSems()
        {
            Semester sem1 = new Semester();
            sem1.init(1);
            sem1.addCourse("CPS109", "", 4.0);
            sem1.addCourse("MTH110", "", 3.0);
            sem1.addCourse("MTH207", "", 3.6);
            sem1.addCourse("PCS110", "", 4.0);
            sem1.addCourse("CPS213", "", 4.0);
            prevSemesters.Add(1, sem1);

            Semester sem2 = new Semester();
            sem2.init(2);
            sem2.addCourse("CPS209", "", 4.0);
            sem2.addCourse("CPS393", "", 2.9);
            sem2.addCourse("MTH210", "", 3.5);
            sem2.addCourse("MTH310", "", 3.6);
            sem2.addCourse("CPS310", "", 4.0);
            prevSemesters.Add(2, sem2);


        }

        public Boolean takenCourse(string course)
        {
            Boolean result = false;
            for (int i = 0; i < prevSemesters.Count; i++)//(Semester sem in prevSemesters)
            {
                Semester sem;
                prevSemesters.TryGetValue(i+1, out sem);
                if (sem.courseList.Contains(course))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
