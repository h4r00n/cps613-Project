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
    public partial class SearchResults : Form
    {
        public List<String> selectedCourseList = new List<string>();
        public SearchResults()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            foreach (string course in CheckedListBox1.CheckedItems){
                selectedCourseList.Add(course);
            }
        }
    }
}
