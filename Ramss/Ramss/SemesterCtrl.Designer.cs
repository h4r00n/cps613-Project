namespace Ramss
{
    partial class SemesterCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CourseList = new System.Windows.Forms.ListView();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CourseList
            // 
            this.CourseList.Location = new System.Drawing.Point(3, 29);
            this.CourseList.Name = "CourseList";
            this.CourseList.Size = new System.Drawing.Size(340, 193);
            this.CourseList.TabIndex = 3;
            this.CourseList.UseCompatibleStateImageBehavior = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(-1, 2);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(157, 24);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Current Semester";
            // 
            // SemesterCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CourseList);
            this.Controls.Add(this.Label1);
            this.Name = "SemesterCtrl";
            this.Size = new System.Drawing.Size(351, 228);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListView CourseList;
        internal System.Windows.Forms.Label Label1;
    }
}
