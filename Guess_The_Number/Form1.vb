'Joshua Pickenpaugh
'October 5th, 2016
'Random Num game (OOP)

Public Class frmMain

    Dim nmbrGen As New NumberGenerator()

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtMyGuess.Text = String.Empty
        lblCmptrResp.Text = String.Empty

        nmbrGen.Clear()
        nmbrGen.RandomNumber()

    End Sub

    Private Sub btnCheckAnswer_Click(sender As Object, e As EventArgs) Handles btnCheckAnswer.Click

        Integer.TryParse(txtMyGuess.Text, nmbrGen.GuessedNumber)

        lblCmptrResp.Text = nmbrGen.CompareGuessedNumberToRandomNumber()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        nmbrGen.RandomNumber()

    End Sub
End Class
