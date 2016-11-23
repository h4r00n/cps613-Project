namespace Ramss
{
    partial class SearchCtrl
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
            this.CourceNumInput = new System.Windows.Forms.TextBox();
            this.CourseCodeInput = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CourceNumInput
            // 
            this.CourceNumInput.Location = new System.Drawing.Point(263, 44);
            this.CourceNumInput.MaxLength = 5;
            this.CourceNumInput.Name = "CourceNumInput";
            this.CourceNumInput.Size = new System.Drawing.Size(78, 20);
            this.CourceNumInput.TabIndex = 9;
            // 
            // CourseCodeInput
            // 
            this.CourseCodeInput.Location = new System.Drawing.Point(81, 44);
            this.CourseCodeInput.MaxLength = 5;
            this.CourseCodeInput.Name = "CourseCodeInput";
            this.CourseCodeInput.Size = new System.Drawing.Size(78, 20);
            this.CourseCodeInput.TabIndex = 8;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(174, 47);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(83, 26);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Course Number:\r\n(Optional)";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(4, 47);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(71, 13);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Course Code:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(3, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(136, 24);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Course Search";
            // 
            // SearchCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CourceNumInput);
            this.Controls.Add(this.CourseCodeInput);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "SearchCtrl";
            this.Size = new System.Drawing.Size(414, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox CourceNumInput;
        internal System.Windows.Forms.TextBox CourseCodeInput;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}
