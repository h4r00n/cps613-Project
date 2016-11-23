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
    public partial class ProgramCtrl : UserControl
    {
        private string progMajor = string.Empty;
        private string progMinor = string.Empty;
        public string Major
        {
            get { return progMajor; }
            set { progMajor = value; majorLabel.Text = progMajor; }
        }
        public string Minor
        {
            get { return progMinor; }
            set { progMinor = value; minorLabel.Text = progMinor; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            majorLabel.Text = progMajor;
            minorLabel.Text = progMinor;
        }
        public ProgramCtrl()
        {
            InitializeComponent();
        }
        
    }
}
