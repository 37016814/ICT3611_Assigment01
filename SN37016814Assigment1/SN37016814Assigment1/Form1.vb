Public Class Main_Form

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Motor Racing club application developed by Student number 37016814 for ICT3611", MsgBoxStyle.Information, "About Menu Strip")

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        member_Form.Show()


    End Sub

    Private Sub btnAddRaceResults_Click(sender As Object, e As EventArgs) Handles btnAddRaceResults.Click
        Results_form.Show()

    End Sub

    Private Sub btnEvents_Click(sender As Object, e As EventArgs) Handles btnEvents.Click
        Events_form.Show()

    End Sub

    Private Sub btnEvents_KeyDown(sender As Object, e As KeyEventArgs) Handles btnEvents.KeyDown
        Select Case e.KeyCode
            Case Keys.E
                btnEvents.PerformClick()
        End Select


    End Sub

    Private Sub btnRegister_KeyDown(sender As Object, e As KeyEventArgs) Handles btnRegister.KeyDown
        If e.KeyCode = Keys.M AndAlso e.Modifiers = Keys.Alt Then
            e.Handled = True
            btnRegister.PerformClick()
        End If
    End Sub

    Private Sub btnAddRaceResults_KeyDown(sender As Object, e As KeyEventArgs) Handles btnAddRaceResults.KeyDown
        Select Case e.KeyCode
            Case Keys.A

                btnAddRaceResults.PerformClick()
        End Select

    End Sub

    Private Sub btnExit_KeyDown(sender As Object, e As KeyEventArgs) Handles btnExit.KeyDown

        Select Case e.KeyCode
            Case Keys.E

                btnExit.PerformClick()
        End Select

    End Sub
End Class
