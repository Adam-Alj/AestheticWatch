Public Class Form1
    Dim flag As Integer
    Dim milisec As Integer
    Dim seconds As Integer
    Dim minutes As Integer
    Dim hours As Integer

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.yes, AudioPlayMode.BackgroundLoop)
        flag = 0
        milisec = 0
        seconds = 0
        minutes = 0
        hours = 0
        Timer1.Interval = 1
        PictureBox4.BackColor = Color.Empty
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        milisec = milisec + 1
        If (milisec = 60) Then
            seconds = seconds + 1
            milisec = 0
        End If

        If (seconds = 60) Then
            minutes = minutes + 1
            seconds = 0
        End If

        If (minutes = 60) Then
            hours = hours + 1
            minutes = 0
        End If

        Label2.Text = hours.ToString("D2") + " : " + minutes.ToString("D2") + " : " + seconds.ToString("D2") + " : " + milisec.ToString("D2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (flag = 0) Then
            Button2.Text = "STOP"
            Timer1.Enabled = True
            flag = 1
        Else
            Button2.Text = "S T A R T"
            Timer1.Enabled = False
            flag = 0
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        milisec = 0
        seconds = 0
        minutes = 0
        hours = 0
        Label2.Text = hours.ToString("D2") + " : " + minutes.ToString("D2") + " : " + seconds.ToString("D2") + " : " + milisec.ToString("D2")
    End Sub

End Class
