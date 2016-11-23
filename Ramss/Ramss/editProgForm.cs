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
    public partial class editProgForm : Form
    {
        private string labelEdit;
        public string newProg = "";
        public string EditLabel
        {
            get { return labelEdit; }
            set { labelEdit = value; label1.Text = labelEdit; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            label1.Text = labelEdit;
        }
        public editProgForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                newProg = textBox1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
