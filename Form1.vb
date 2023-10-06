Public Class Form1
    Private Sub BtnExtact_Click(sender As Object, e As EventArgs) Handles BtnExtact.Click
        Dim myPhrase As String
        Dim pos, n As Integer
        myPhrase = TxtPhrase.Text
        pos = TxtPos.Text
        n = TxtNumber.Text
        LblExtract.Text = Mid(myPhrase, pos, n)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
