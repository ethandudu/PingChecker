Public Class Main
    Dim Num As Integer
    Dim UserDomain
    Private Sub Start_BT_Click(sender As Object, e As EventArgs) Handles Start_BT.Click
        If TextBox1.TextLength = 0 Then
            MsgBox("Please write a domain in the textbox !", MsgBoxStyle.Critical)
        Else
            DataGridView1.Rows.Clear()
            Timer1.Start()
            Num = 0
            Started_time_LB.Visible = True
            Start_LB.Visible = True
            Started_time_LB.Text = My.Computer.Clock.LocalTime
            UserDomain = TextBox1.Text
        End If
    End Sub

    Private Sub Stop_BT_Click(sender As Object, e As EventArgs) Handles Stop_BT.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim hour = My.Computer.Clock.LocalTime
        Dim Ping As Net.NetworkInformation.PingReply
        Dim SendPing As New Net.NetworkInformation.Ping
        Dim ResponseTime As Double

        Try
            Ping = SendPing.Send(UserDomain)
            ResponseTime = Ping.RoundtripTime
        Catch ex As Exception
            ResponseTime = 0
        End Try

        If ResponseTime = 0 Then
            DataGridView1.Rows.Add(Num.ToString, hour.ToString, TextBox1.Text, "Error")
            DataGridView1.Item(3, Num).Style.BackColor = Color.Red
            DataGridView1.Sort(Time, System.ComponentModel.ListSortDirection.Descending)

        Else
            DataGridView1.Rows.Add(Num.ToString, hour.ToString, TextBox1.Text, ResponseTime)
            DataGridView1.Item(3, Num).Style.BackColor = Color.Green
            DataGridView1.Sort(Time, System.ComponentModel.ListSortDirection.Descending)
        End If
        Num += 1
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Start_LB.Visible = False
        Started_time_LB.Visible = False
        Version_LB.Text = My.Application.Info.Version.ToString
    End Sub

    Private Sub Credit_Click(sender As Object, e As EventArgs) Handles Credit.Click
        Process.Start("https://github.com/ethandudu")
    End Sub

    Private Sub Name_Click(sender As Object, e As EventArgs) Handles Icon_PB.Click, Name_LB.Click
        Process.Start("https://github.com/ethandudu/PingChecker")
    End Sub
End Class
