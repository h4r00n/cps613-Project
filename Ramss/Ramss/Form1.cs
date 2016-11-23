using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ramss
{
    public partial class Form1 : Form
    {
        AcademicProgram myProgram;
        public Form1()
        {
            InitializeComponent();
            myProgram = new AcademicProgram();
            myProgram.init();
            cartCtrl1.CheckedListBox1.CheckOnClick = true;
            semesterCtrl1.CourseList.View = View.List;
            Semester sem1, sem2;
            myProgram.prevSemesters.TryGetValue(1, out sem1);
            myProgram.prevSemesters.TryGetValue(2, out sem2);
            gradeCtrl1.setTerm1(sem1);
            gradeCtrl1.setTerm2(sem2);
        }

        private void updateSemesterView()
        {
            programCtrl1.Major = myProgram.progMajor;
            programCtrl1.Minor = myProgram.progMinor;
            programCtrl2.Major = myProgram.progMajor;
            programCtrl2.Minor = myProgram.progMinor;
            semesterCtrl1.Courses = myProgram.currentSemester.courseList;
        }

        private void programCtrl1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void editCourseBtn_Click(object sender, EventArgs e)
        {
            if (myProgram.currentSemester.courseList.Count > 0) {
                List<String> results = new List<string>();
                results = myProgram.currentSemester.courseList;
                DropForm dropCourseForm = new DropForm();
                foreach (string item in results)
                {
                    dropCourseForm.CheckedListBox1.Items.Add(item);
                }
                dropCourseForm.CheckedListBox1.CheckOnClick = true;
                DialogResult formResult = dropCourseForm.ShowDialog(this);
                if (formResult == DialogResult.Yes)
                {
                    foreach (string item in dropCourseForm.selectedCourseList)
                    {
                        myProgram.currentSemester.dropCourse(item);
                    }
                }
                this.updateSemesterView();
            }
        }

        private void finEnrolBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            searchCtrl1.clearSearch();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            List<String> results = new List<string>();
            results = searchCtrl1.searchForCourse();
            SearchResults resultsForm = new SearchResults();
            foreach (string item in results) {
                resultsForm.CheckedListBox1.Items.Add(item);
            }
            resultsForm.CheckedListBox1.CheckOnClick = true;
            DialogResult formResult = resultsForm.ShowDialog(this);
            if (formResult == DialogResult.Yes)
            {
                foreach (string item in resultsForm.selectedCourseList)
                {
                    cartCtrl1.CheckedListBox1.Items.Add(item);
                }
            }
        }

        private void enrolCartBtn_Click(object sender, EventArgs e)
        {
            List<string> enrolled = new List<string>();
            foreach (string item in cartCtrl1.CheckedListBox1.CheckedItems)
            {
                if (!myProgram.takenCourse(item))
                {
                    myProgram.currentSemester.addCourse(item, "", 0);
                    enrolled.Add(item);
                }
                else
                {
                    MessageForm newMsg = new MessageForm();
                    newMsg.ErrorMessage = "Could not enroll in course: " + item + ". Note: You cannot enroll in courses already taken.";
                    newMsg.ShowDialog(this);
                }
            }
            foreach (string item in enrolled)
            {
                cartCtrl1.CheckedListBox1.Items.Remove(item);
            }
            if (enrolled.Count > 0)
            {
                MessageForm newMsg1 = new MessageForm();
                newMsg1.ErrorMessage = "You have been enrolled in the following courses: " + String.Join(", ", enrolled.ToArray());
                newMsg1.ShowDialog(this);
                this.updateSemesterView();
            }
        }

        private void remCartBtn_Click(object sender, EventArgs e)
        {
            List<string> coursesToRemove = new List<string>();
            foreach (string item in cartCtrl1.CheckedListBox1.CheckedItems)
            {
                coursesToRemove.Add(item);
            }
            foreach (string item in coursesToRemove)
            {
                cartCtrl1.CheckedListBox1.Items.Remove(item);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editProgForm editProg = new editProgForm();
            editProg.EditLabel = "Enter new major:";
            DialogResult formResult = editProg.ShowDialog(this);
            if (formResult == DialogResult.Yes)
            {
                string result = editProg.newProg;
                if (result.Length > 0)
                {
                    myProgram.setMajor(result);
                }
            }
            this.updateSemesterView();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            editProgForm editProg = new editProgForm();
            editProg.EditLabel = "Enter new minor:";
            DialogResult formResult = editProg.ShowDialog(this);
            if (formResult == DialogResult.Yes)
            {
                string result = editProg.newProg;
                if (result.Length > 0)
                {
                    myProgram.setMinor(result);
                }
            }
            this.updateSemesterView();
        }
    }
}
