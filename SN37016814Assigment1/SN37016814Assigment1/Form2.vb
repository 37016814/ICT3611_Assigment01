
Imports System.IO


Public Class member_Form

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Public Class Datavalidation

        Inherits Exception


    End Class

    Private Sub member_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles MemberInfo.Enter

    End Sub


    Private Sub Gender_Enter(sender As Object, e As EventArgs) Handles Gender.Enter




    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        Dim Datavalidation As New Datavalidation

        Try
            Dim FirstName As String = textFirstName.Text

            If FirstName = "" Then Throw Datavalidation

        Catch ex As Datavalidation
            MessageBox.Show("member name Missing")
      






            Dim Member_file As String = IO.Path.Combine("C:/Users/Nyathi/Documents/Visual Studio 2012/Projects/SN37016814Assigment1/SN37016814Assigment1/", "Members.txt") 'file path
            Using sw As New StreamWriter(Member_file)
                sw.WriteLine(textMemNumber.Text & ",")
                sw.WriteLine(textFirstName.Text & ",")
                sw.WriteLine(textLastName.Text & ",")
                sw.WriteLine(Birthdate.Text & ",")
                sw.WriteLine(Gender.Text & ",")
                sw.WriteLine(MembershipDate.Text & ",")
                sw.WriteLine(txtOutstandingFee.Text & ",")
                sw.Close()
            End Using

        End Try
    End Sub

    Private Sub rbtMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMale.CheckedChanged
        Gender.Text = rbtMale.Text()





    End Sub

    Private Sub rbtFimale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtFimale.CheckedChanged
        Gender.Text = rbtFimale.Text()

    End Sub

    Private Sub txtOutstandingFee_TextChanged(sender As Object, e As EventArgs) Handles txtOutstandingFee.TextChanged

        Dim Fee As Decimal
        If Decimal.TryParse(txtOutstandingFee.Text, System.Globalization.NumberStyles.Currency, Nothing, Fee) Then
            txtOutstandingFee.Text = Fee.ToString("C")

        End If
    End Sub

    Private Sub btnAdd_KeyDown(sender As Object, e As KeyEventArgs) Handles btnAdd.KeyDown
        If (e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control) Then
            btnAdd.PerformClick()
        End If

    End Sub
End Class