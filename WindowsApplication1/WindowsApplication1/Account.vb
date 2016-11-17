Public Class Account
    Public prevList As Collection = New Collection
    Public currList As Collection = New Collection
    Public dropCourseForm As DropForm

    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Semester1.CourseList.Alignment = ListViewAlignment.Left
        Semester1.CourseList.View = View.List
        prevList.Add("CPS109")
        prevList.Add("CPS110")
        currList.Add("CPS209")
        currList.Add("CPS310")
        Me.updateCourseList()
    End Sub
    Private Sub UserControl11_Click(sender As Object, e As EventArgs) Handles UserControl11.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
    End Sub

    Private Sub updateCourseList()
        Semester1.CourseList.Items.Clear()
        For Each item In currList
            Semester1.CourseList.Items.Add(item)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedTab = TabControl1.TabPages.Item(2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dropCourseForm = New DropForm

        ''dropCourseForm.Parent = Me
        ''dropCourseForm.Activate()
        For Each item In currList
            dropCourseForm.CheckedListBox1.Items.Add(item)
        Next
        Dim result As DialogResult = dropCourseForm.ShowDialog(Me)
        If result = DialogResult.Yes Then
            currList = dropCourseForm.updatedCourseList
            Me.updateCourseList()
        ElseIf result = DialogResult.Cancel Then
        End If
    End Sub
End Class
