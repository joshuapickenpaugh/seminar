Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'Declares variables:
        Const decDISCOUNT_PRICE As Decimal = 80.0
        Const decREGULAR_PRICE As Decimal = 100.0
        Dim intParticipants As Integer
        Dim decTotal As Decimal

        'Assigns variables to text boxes:
        Integer.TryParse(txtParticipants.Text, intParticipants)

        'Calculates:
        If intParticipants > 10 Then
            decTotal = intParticipants * decDISCOUNT_PRICE
        Else decTotal = intParticipants * decREGULAR_PRICE
        End If


    End Sub
End Class
