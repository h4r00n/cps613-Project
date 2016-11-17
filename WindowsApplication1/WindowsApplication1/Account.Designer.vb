<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.UserControl11 = New WindowsApplication1.AcademicProgram()
        Me.UserControl31 = New WindowsApplication1.FinInfo()
        Me.UserControl21 = New WindowsApplication1.PersInfo()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GradesSum1 = New WindowsApplication1.GradesSum()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Semester1 = New WindowsApplication1.Semester()
        Me.UserControl12 = New WindowsApplication1.AcademicProgram()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(619, 557)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.UserControl11)
        Me.TabPage1.Controls.Add(Me.UserControl31)
        Me.TabPage1.Controls.Add(Me.UserControl21)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(611, 531)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Home"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'UserControl11
        '
        Me.UserControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserControl11.Location = New System.Drawing.Point(6, 6)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(399, 114)
        Me.UserControl11.TabIndex = 0
        '
        'UserControl31
        '
        Me.UserControl31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserControl31.Location = New System.Drawing.Point(6, 256)
        Me.UserControl31.Name = "UserControl31"
        Me.UserControl31.Size = New System.Drawing.Size(399, 121)
        Me.UserControl31.TabIndex = 2
        '
        'UserControl21
        '
        Me.UserControl21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserControl21.Location = New System.Drawing.Point(6, 126)
        Me.UserControl21.Name = "UserControl21"
        Me.UserControl21.Size = New System.Drawing.Size(399, 124)
        Me.UserControl21.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GradesSum1)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Semester1)
        Me.TabPage2.Controls.Add(Me.UserControl12)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(611, 531)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Academic Program"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GradesSum1
        '
        Me.GradesSum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GradesSum1.Location = New System.Drawing.Point(6, 422)
        Me.GradesSum1.Name = "GradesSum1"
        Me.GradesSum1.Size = New System.Drawing.Size(399, 84)
        Me.GradesSum1.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(269, 371)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 34)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Edit Current Courses"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 371)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add Course"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Semester1
        '
        Me.Semester1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Semester1.Location = New System.Drawing.Point(6, 144)
        Me.Semester1.Name = "Semester1"
        Me.Semester1.Size = New System.Drawing.Size(399, 272)
        Me.Semester1.TabIndex = 1
        '
        'UserControl12
        '
        Me.UserControl12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserControl12.Location = New System.Drawing.Point(6, 6)
        Me.UserControl12.Name = "UserControl12"
        Me.UserControl12.Size = New System.Drawing.Size(399, 132)
        Me.UserControl12.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(611, 531)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Course Registration"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(611, 531)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Grades"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(611, 531)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Graduation"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Account"
        Me.Size = New System.Drawing.Size(625, 485)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserControl11 As AcademicProgram
    Friend WithEvents UserControl21 As PersInfo
    Friend WithEvents UserControl31 As FinInfo
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents UserControl12 As AcademicProgram
    Friend WithEvents Semester1 As Semester
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GradesSum1 As GradesSum
End Class
