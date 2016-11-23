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
    public partial class MessageForm : Form
    {
        private string message;
        public string ErrorMessage
        {
            get { return message; }
            set { message = value; textBox1.Text = message; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            textBox1.Text = message;
        }
        public MessageForm()
        {
            InitializeComponent();
        }
    }
}
