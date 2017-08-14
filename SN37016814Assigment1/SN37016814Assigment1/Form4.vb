Imports System.IO

Public Class Results_form

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.DataGridView1.Rows.Add(txtEventName.Text, EventDate.Text, txtDriver.Text, txtSurname.Text, txtNumLaps.Text, txtPosition.Text
                                  )


        Dim Results_file As String = IO.Path.Combine("C:/Users/Nyathi/Documents/Visual Studio 2012/Projects/SN37016814Assigment1/SN37016814Assigment1/", "Results.txt") 'file path
        Using sw As New StreamWriter(Results_file)


            sw.WriteLine(txtEventName.Text & ",")
            sw.WriteLine(EventDate.Text & ",")
            sw.WriteLine(txtDriver.Text & ",")
            sw.WriteLine(txtSurname.Text & ",")
            sw.WriteLine(txtNumLaps.Text & ",")
            sw.WriteLine(txtPosition.Text & ",")
            sw.Close()

        End Using

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class