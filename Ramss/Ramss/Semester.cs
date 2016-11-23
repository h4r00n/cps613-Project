using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramss
{
    public class Semester
    {
        public int semesterNum;
        public Dictionary<String, String> courses;
        public Dictionary<String, Double> courseGrade;
        public List<String> courseList;

        public void init(int newSemNum)
        {
            this.semesterNum = newSemNum;
            this.courseGrade = new Dictionary<string, double>();
            this.courses = new Dictionary<string, string>();
            this.courseList = new List<string>();
        }

        public void addCourse(String courseCode, String courseName, double courseGrade)
        {
            if (!this.courses.ContainsKey(courseCode))
            {
                this.courses.Add(courseCode, courseName);
                this.courseGrade.Add(courseCode, courseGrade);
                this.courseList.Add(courseCode);
            }
        }

        public void dropCourse(String courseCode)
        {
            if (this.courses.ContainsKey(courseCode))
            {
                this.courses.Remove(courseCode);
                this.courseGrade.Remove(courseCode);
                this.courseList.Remove(courseCode);
            }
        }
    }
}
