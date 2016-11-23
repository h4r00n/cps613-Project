using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;

namespace Ramss
{
    public partial class SearchCtrl : UserControl
    {
        List<string> allCourses = new List<string>();
        public void clearSearch()
        {
            CourceNumInput.Clear();
            CourseCodeInput.Clear();
        }

        public List<String> searchForCourse()
        {
            List<String> results = new List<string>();
            string searchTerm = "";
            if (CourseCodeInput.Text.Length > 0) {
                searchTerm = CourseCodeInput.Text.ToUpper() + CourceNumInput.Text.ToUpper();
                foreach (string item in allCourses)
                {
                    if (item.Contains(searchTerm))
                    {
                        results.Add(item);
                    }
                }
            } 
            return results;
        }
        public SearchCtrl()
        {
            InitializeComponent();
            this.readDataSet();
        }

        public void readDataSet()
        {
            TextReader fileReader = new StringReader(Ramss.Properties.Resources.courseListing);
            using (TextFieldParser parser = new TextFieldParser(fileReader))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    string courseName = fields[0] + fields[1];
                    allCourses.Add(courseName);
                }
            }
        }
    }
}
