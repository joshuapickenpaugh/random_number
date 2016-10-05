Public Class NumberGenerator

    Private _intGuessedNumber As Integer
    Private _intRandomNumber As Integer

    Public Property GuessedNumber As Integer
        Get
            Return _intGuessedNumber
        End Get
        Set(value As Integer)
            If value > 0 Then
                _intGuessedNumber = value
            Else
                _intGuessedNumber = 0
            End If
        End Set
    End Property

    Public Sub New()

        _intGuessedNumber = 0

    End Sub

    Public Sub Clear()

        _intGuessedNumber = 0

    End Sub

    Public Sub RandomNumber()

        Dim randGen As New Random

        _intRandomNumber = randGen.Next(1, 10)

    End Sub

    Public Function CompareGuessedNumberToRandomNumber() As String

        Dim strAnswer As String

        If (_intGuessedNumber > _intRandomNumber) Then
            strAnswer = "Your number is higher, try again."
        ElseIf (_intGuessedNumber < _intRandomNumber) Then
            strAnswer = "Your number is lower, try again"
        Else
            strAnswer = "Correct!"
        End If

        Return strAnswer

    End Function

End Class
