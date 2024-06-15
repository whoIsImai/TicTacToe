Public Class Form1

    Dim PlayerTurn As New Player
    Dim arrbuttons() As Button
    Dim icounter As Integer = 0
    Dim intplayerO As Integer
    Dim intplayerX As Integer
    Private Sub buttons(sender As Object, e As EventArgs) Handles btnTopRight.Click, btnTopLeft.Click, btnMiddleTop.Click, btnMiddleRight.Click, btnMiddleLeft.Click, btnMiddleBottom.Click, btnCenter.Click, btnBottomRight.Click, btnBottomLeft.Click
        Dim clickedButton As Button = DirectCast(sender, Button)

        icounter = icounter Mod 2
        If icounter = 0 Then
            clickedButton.Text = PlayerTurn.X.ToString()
            clickedButton.BackColor = Color.Green
            clickedButton.Enabled = False
        ElseIf icounter = 1 Then
            clickedButton.Text = PlayerTurn.O.ToString()
            clickedButton.BackColor = Color.Red
            clickedButton.Enabled = False
        End If
        icounter = icounter + 1
        CheckWin()
    End Sub
    Public Sub CheckWin()
        If (btnTopLeft.Text = PlayerTurn.X.ToString() And btnMiddleTop.Text = PlayerTurn.X.ToString() And btnTopRight.Text = PlayerTurn.X.ToString() Or
            btnMiddleLeft.Text = PlayerTurn.X.ToString() And btnCenter.Text = PlayerTurn.X.ToString() And btnMiddleRight.Text = PlayerTurn.X Or
            btnBottomLeft.Text = PlayerTurn.X.ToString() And btnMiddleBottom.Text = PlayerTurn.X.ToString() And btnBottomRight.Text = PlayerTurn.X Or
            btnTopLeft.Text = PlayerTurn.X.ToString() And btnMiddleLeft.Text = PlayerTurn.X.ToString() And btnBottomLeft.Text = PlayerTurn.X Or
            btnMiddleTop.Text = PlayerTurn.X.ToString() And btnCenter.Text = PlayerTurn.X.ToString() And btnMiddleBottom.Text = PlayerTurn.X Or
            btnTopRight.Text = PlayerTurn.X.ToString() And btnMiddleRight.Text = PlayerTurn.X.ToString() And btnBottomRight.Text = PlayerTurn.X Or
            btnTopLeft.Text = PlayerTurn.X.ToString() And btnCenter.Text = PlayerTurn.X.ToString() And btnBottomRight.Text = PlayerTurn.X Or
            btnTopRight.Text = PlayerTurn.X.ToString() And btnCenter.Text = PlayerTurn.X.ToString() And btnBottomLeft.Text = PlayerTurn.X) Then

            intplayerX = intplayerX + 1
            lblwin.Text = $"Score : {intplayerX} vs {intplayerO}"

        ElseIf (btnTopLeft.Text = PlayerTurn.O.ToString() And btnMiddleTop.Text = PlayerTurn.O.ToString() And btnTopRight.Text = PlayerTurn.O.ToString() Or
         btnMiddleLeft.Text = PlayerTurn.O.ToString() And btnCenter.Text = PlayerTurn.O.ToString() And btnMiddleRight.Text = PlayerTurn.O Or
        btnBottomLeft.Text = PlayerTurn.O.ToString() And btnMiddleBottom.Text = PlayerTurn.O.ToString() And btnBottomRight.Text = PlayerTurn.O Or
        btnTopLeft.Text = PlayerTurn.O.ToString() And btnMiddleLeft.Text = PlayerTurn.O.ToString() And btnBottomLeft.Text = PlayerTurn.O Or
        btnMiddleTop.Text = PlayerTurn.O.ToString() And btnCenter.Text = PlayerTurn.O.ToString() And btnMiddleBottom.Text = PlayerTurn.O Or
        btnTopRight.Text = PlayerTurn.O.ToString() And btnMiddleRight.Text = PlayerTurn.O.ToString() And btnBottomRight.Text = PlayerTurn.O Or
        btnTopLeft.Text = PlayerTurn.O.ToString() And btnCenter.Text = PlayerTurn.O.ToString() And btnBottomRight.Text = PlayerTurn.O Or
        btnTopRight.Text = PlayerTurn.O.ToString() And btnCenter.Text = PlayerTurn.O.ToString() And btnBottomLeft.Text = PlayerTurn.O) Then
            intplayerO = intplayerO + 1
            lblwin.Text = $"Score : {intplayerX} vs {intplayerO}"
            'DRAW
        End If
    End Sub
    Private Sub BtnRestart_Click(sender As Object, e As EventArgs) Handles BtnRestart.Click
        arrbuttons = {btnTopLeft, btnMiddleTop, btnTopRight, btnMiddleLeft, btnCenter, btnMiddleRight, btnBottomLeft, btnMiddleBottom, btnBottomRight}

        For i As Integer = 0 To arrbuttons.GetUpperBound(0)
            arrbuttons(i).Text = ""
            arrbuttons(i).BackColor = DefaultBackColor
            arrbuttons(i).Enabled = True
        Next
    End Sub
End Class
