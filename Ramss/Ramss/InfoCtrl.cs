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
    public partial class InfoCtrl : UserControl
    {
        private string headerText, label1Text, label2Text;

        public string Header
        {
            get { return headerText; }
            set { headerText = value; Label1.Text = headerText; }
        }

        public string Labl1
        {
            get { return label1Text; }
            set { label1Text = value; Label3.Text = label1Text; }
        }
        public string Labl2
        {
            get { return label2Text; }
            set { label2Text = value; Label4.Text = label2Text; }
        }
        public InfoCtrl()
        {
            InitializeComponent();
        }
    }
}
