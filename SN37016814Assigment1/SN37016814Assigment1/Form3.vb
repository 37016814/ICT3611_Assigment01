Imports System.IO

Public Class Events_form

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim Events_file As String = IO.Path.Combine("C:/Users/Nyathi/Documents/Visual Studio 2012/Projects/SN37016814Assigment1/SN37016814Assigment1/", "Events.txt") 'file path
        Using sw As New StreamWriter(Events_file)
            sw.WriteLine(txtEventName.Text & ",")
            sw.WriteLine(EventDate.Text & ",")
            sw.WriteLine(txtFee.Text & ",")
            sw.WriteLine(txtLocation.Text & ",")
            sw.WriteLine(txtLaps.Text & ",")
            sw.Close()

        End Using







    End Sub

    Private Sub btnAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles btnAdd.KeyDown
        If (e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control) Then
            btnAdd.PerformClick()
        End If







    End Sub
End Class