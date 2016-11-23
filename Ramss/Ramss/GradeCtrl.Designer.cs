namespace Ramss
{
    partial class GradeCtrl
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
            this.termGradeCtrl1 = new Ramss.TermGradeCtrl();
            this.label1 = new System.Windows.Forms.Label();
            this.termGradeCtrl2 = new Ramss.TermGradeCtrl();
            this.label2 = new System.Windows.Forms.Label();
            this.cgpaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // termGradeCtrl1
            // 
            this.termGradeCtrl1.Location = new System.Drawing.Point(7, 53);
            this.termGradeCtrl1.Name = "termGradeCtrl1";
            this.termGradeCtrl1.Size = new System.Drawing.Size(333, 240);
            this.termGradeCtrl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grades History";
            // 
            // termGradeCtrl2
            // 
            this.termGradeCtrl2.Location = new System.Drawing.Point(7, 299);
            this.termGradeCtrl2.Name = "termGradeCtrl2";
            this.termGradeCtrl2.Size = new System.Drawing.Size(333, 240);
            this.termGradeCtrl2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cummulative GPA:";
            // 
            // cgpaLabel
            // 
            this.cgpaLabel.AutoSize = true;
            this.cgpaLabel.Location = new System.Drawing.Point(105, 37);
            this.cgpaLabel.Name = "cgpaLabel";
            this.cgpaLabel.Size = new System.Drawing.Size(22, 13);
            this.cgpaLabel.TabIndex = 4;
            this.cgpaLabel.Text = "4.0";
            // 
            // GradeCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cgpaLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.termGradeCtrl2);
            this.Controls.Add(this.termGradeCtrl1);
            this.Controls.Add(this.label1);
            this.Name = "GradeCtrl";
            this.Size = new System.Drawing.Size(522, 564);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TermGradeCtrl termGradeCtrl1;
        private System.Windows.Forms.Label label1;
        private TermGradeCtrl termGradeCtrl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cgpaLabel;
    }
}
