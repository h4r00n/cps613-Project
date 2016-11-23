namespace Ramss
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.programCtrl1 = new Ramss.ProgramCtrl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.editCourseBtn = new System.Windows.Forms.Button();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.semesterCtrl1 = new Ramss.SemesterCtrl();
            this.programCtrl2 = new Ramss.ProgramCtrl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.searchBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.remCartBtn = new System.Windows.Forms.Button();
            this.enrolCartBtn = new System.Windows.Forms.Button();
            this.finEnrolBtn = new System.Windows.Forms.Button();
            this.cartCtrl1 = new Ramss.CartCtrl();
            this.searchCtrl1 = new Ramss.SearchCtrl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gradeCtrl1 = new Ramss.GradeCtrl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.infoCtrl1 = new Ramss.InfoCtrl();
            this.infoCtrl2 = new Ramss.InfoCtrl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(471, 597);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.infoCtrl2);
            this.tabPage1.Controls.Add(this.infoCtrl1);
            this.tabPage1.Controls.Add(this.programCtrl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(463, 571);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // programCtrl1
            // 
            this.programCtrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.programCtrl1.Location = new System.Drawing.Point(3, 3);
            this.programCtrl1.Major = "Computer Science";
            this.programCtrl1.Minor = "N/A";
            this.programCtrl1.Name = "programCtrl1";
            this.programCtrl1.Size = new System.Drawing.Size(456, 152);
            this.programCtrl1.TabIndex = 0;
            this.programCtrl1.Click += new System.EventHandler(this.programCtrl1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.linkLabel2);
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Controls.Add(this.editCourseBtn);
            this.tabPage2.Controls.Add(this.addCourseBtn);
            this.tabPage2.Controls.Add(this.semesterCtrl1);
            this.tabPage2.Controls.Add(this.programCtrl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(720, 571);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Program";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(8, 124);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(54, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Edit Minor";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(8, 76);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(54, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Edit Major";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // editCourseBtn
            // 
            this.editCourseBtn.Location = new System.Drawing.Point(299, 391);
            this.editCourseBtn.Name = "editCourseBtn";
            this.editCourseBtn.Size = new System.Drawing.Size(148, 42);
            this.editCourseBtn.TabIndex = 4;
            this.editCourseBtn.Text = "Edit Current Courses";
            this.editCourseBtn.UseVisualStyleBackColor = true;
            this.editCourseBtn.Click += new System.EventHandler(this.editCourseBtn_Click);
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.Location = new System.Drawing.Point(8, 391);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(102, 42);
            this.addCourseBtn.TabIndex = 3;
            this.addCourseBtn.Text = "Add Course";
            this.addCourseBtn.UseVisualStyleBackColor = true;
            this.addCourseBtn.Click += new System.EventHandler(this.addCourseBtn_Click);
            // 
            // semesterCtrl1
            // 
            this.semesterCtrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.semesterCtrl1.Courses = ((System.Collections.Generic.List<string>)(resources.GetObject("semesterCtrl1.Courses")));
            this.semesterCtrl1.Location = new System.Drawing.Point(3, 161);
            this.semesterCtrl1.Name = "semesterCtrl1";
            this.semesterCtrl1.Size = new System.Drawing.Size(456, 284);
            this.semesterCtrl1.TabIndex = 2;
            // 
            // programCtrl2
            // 
            this.programCtrl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.programCtrl2.Location = new System.Drawing.Point(3, 3);
            this.programCtrl2.Major = "Computer Science";
            this.programCtrl2.Minor = "N/A";
            this.programCtrl2.Name = "programCtrl2";
            this.programCtrl2.Size = new System.Drawing.Size(456, 152);
            this.programCtrl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.searchBtn);
            this.tabPage3.Controls.Add(this.cancelBtn);
            this.tabPage3.Controls.Add(this.remCartBtn);
            this.tabPage3.Controls.Add(this.enrolCartBtn);
            this.tabPage3.Controls.Add(this.finEnrolBtn);
            this.tabPage3.Controls.Add(this.cartCtrl1);
            this.tabPage3.Controls.Add(this.searchCtrl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(720, 571);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Course Registration";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(304, 100);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(99, 36);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(8, 100);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(99, 36);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // remCartBtn
            // 
            this.remCartBtn.Location = new System.Drawing.Point(224, 360);
            this.remCartBtn.Name = "remCartBtn";
            this.remCartBtn.Size = new System.Drawing.Size(179, 36);
            this.remCartBtn.TabIndex = 4;
            this.remCartBtn.Text = "Remove selected course(s)";
            this.remCartBtn.UseVisualStyleBackColor = true;
            this.remCartBtn.Click += new System.EventHandler(this.remCartBtn_Click);
            // 
            // enrolCartBtn
            // 
            this.enrolCartBtn.Location = new System.Drawing.Point(8, 360);
            this.enrolCartBtn.Name = "enrolCartBtn";
            this.enrolCartBtn.Size = new System.Drawing.Size(179, 36);
            this.enrolCartBtn.TabIndex = 3;
            this.enrolCartBtn.Text = "Enroll in selected course(s)";
            this.enrolCartBtn.UseVisualStyleBackColor = true;
            this.enrolCartBtn.Click += new System.EventHandler(this.enrolCartBtn_Click);
            // 
            // finEnrolBtn
            // 
            this.finEnrolBtn.Location = new System.Drawing.Point(238, 434);
            this.finEnrolBtn.Name = "finEnrolBtn";
            this.finEnrolBtn.Size = new System.Drawing.Size(179, 36);
            this.finEnrolBtn.TabIndex = 2;
            this.finEnrolBtn.Text = "Finish Enrolling";
            this.finEnrolBtn.UseVisualStyleBackColor = true;
            this.finEnrolBtn.Click += new System.EventHandler(this.finEnrolBtn_Click);
            // 
            // cartCtrl1
            // 
            this.cartCtrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cartCtrl1.Location = new System.Drawing.Point(3, 159);
            this.cartCtrl1.Name = "cartCtrl1";
            this.cartCtrl1.Size = new System.Drawing.Size(414, 258);
            this.cartCtrl1.TabIndex = 1;
            // 
            // searchCtrl1
            // 
            this.searchCtrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchCtrl1.Location = new System.Drawing.Point(3, 3);
            this.searchCtrl1.Name = "searchCtrl1";
            this.searchCtrl1.Size = new System.Drawing.Size(414, 150);
            this.searchCtrl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gradeCtrl1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(720, 571);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Grades";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gradeCtrl1
            // 
            this.gradeCtrl1.Location = new System.Drawing.Point(3, 3);
            this.gradeCtrl1.Name = "gradeCtrl1";
            this.gradeCtrl1.Size = new System.Drawing.Size(522, 564);
            this.gradeCtrl1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(0, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(471, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "http:\\\\THE BEST URL EVER";
            // 
            // infoCtrl1
            // 
            this.infoCtrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoCtrl1.Header = "Personal Information";
            this.infoCtrl1.Labl1 = "Name: Bob Dole";
            this.infoCtrl1.Labl2 = "Address: 123 Fake Street";
            this.infoCtrl1.Location = new System.Drawing.Point(3, 161);
            this.infoCtrl1.Name = "infoCtrl1";
            this.infoCtrl1.Size = new System.Drawing.Size(456, 106);
            this.infoCtrl1.TabIndex = 1;
            // 
            // infoCtrl2
            // 
            this.infoCtrl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoCtrl2.Header = "Financial Summary";
            this.infoCtrl2.Labl1 = "Current balance: $99999";
            this.infoCtrl2.Labl2 = " ";
            this.infoCtrl2.Location = new System.Drawing.Point(3, 273);
            this.infoCtrl2.Name = "infoCtrl2";
            this.infoCtrl2.Size = new System.Drawing.Size(456, 106);
            this.infoCtrl2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 620);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "RAMSS - Prototype - Team A6";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private ProgramCtrl programCtrl1;
        private ProgramCtrl programCtrl2;
        private SemesterCtrl semesterCtrl1;
        private System.Windows.Forms.Button editCourseBtn;
        private System.Windows.Forms.Button addCourseBtn;
        private CartCtrl cartCtrl1;
        private SearchCtrl searchCtrl1;
        private System.Windows.Forms.Button finEnrolBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button remCartBtn;
        private System.Windows.Forms.Button enrolCartBtn;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private GradeCtrl gradeCtrl1;
        private InfoCtrl infoCtrl1;
        private InfoCtrl infoCtrl2;
    }
}

