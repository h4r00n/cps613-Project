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
    public partial class GradeCtrl : UserControl
    {
        public void setTerm1(Semester sem)
        {
            termGradeCtrl1.setTerm(sem);
        }
        public void setTerm2(Semester sem)
        {
            termGradeCtrl2.setTerm(sem);
        }

        public GradeCtrl()
        {
            InitializeComponent();
        }
    }
}
