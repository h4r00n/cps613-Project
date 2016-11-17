Public Class DropForm

    Public updatedCourseList As Collection = New Collection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim coursesToRemove As Collection = New Collection
        For Each selectedCourse In CheckedListBox1.SelectedItems
            coursesToRemove.Add(selectedCourse)
        Next
        For Each selectedCourse In coursesToRemove
            CheckedListBox1.Items.Remove(selectedCourse)
        Next

        For Each course In CheckedListBox1.Items
            updatedCourseList.Add(course)
        Next
        ''TODO: send updated list to account.
    End Sub
End Class