Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Hello there!")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("The Last Name field must not be blank.", vbExclamation, "Last Name")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("The Last Name field must not be blank.", vbExclamation + vbOKOnly, "Last Name")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("The Last Name field must not be blank.", 48, "Last Name")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MsgBox("A bad database error has occurred.", vbCritical, "UpdateCustomerTable")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Dim intResponse As Integer

        intResponse = MsgBox("Are you sure you want to quit?", vbYesNo + vbQuestion, "Quit")
        If intResponse = vbYes Then
            MsgBox("Code to end the app would go here.")
        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Dim intResponse As Integer

        intResponse = MsgBox("Are you sure you want to quit?", 36, "Quit")
        If intResponse = vbYes Then
            MsgBox("Code to end the app would go here.")
        End If

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        If MsgBox("Are you sure you want to quit?", vbYesNo + vbQuestion, "Quit") = vbYes Then
            MsgBox("Code to end the app would go here.")
        End If

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        Dim intResponse As Integer

        intResponse = MsgBox("Are you sure you want to delete all of the rows in the Customer table?", _
                             vbYesNo + vbQuestion + vbDefaultButton2, _
                             "Delete")
        If intResponse = vbYes Then
            MsgBox("Code to delete the rows would go here.")
        End If

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

End Class
