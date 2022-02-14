Public Class Main
    Dim Num As Integer
    Dim UserDomain As String
    Dim Button As Integer = 0
    Dim Lost As Integer = 0
    Dim Rcv As Integer = 0
    Dim Min As Integer = 0
    Dim Max As Integer = 0
    Dim avg1 As Integer = 0

    Private Sub Start_BT_Click(sender As Object, e As EventArgs) Handles Start_BT.Click
        If Button = 0 Then
            If TextBox1.TextLength = 0 Then
                MsgBox("Please write a domain in the textbox !", MsgBoxStyle.Critical)
            Else
                Lost = 0
                Rcv = 0
                Min = 1000
                Max = 0
                avg1 = 0

                DataGridView1.Rows.Clear()
                Timer1.Start()
                Num = 0
                Started_time_LB.Visible = True
                Start_LB.Visible = True
                Started_time_LB.Text = My.Computer.Clock.LocalTime
                UserDomain = TextBox1.Text
                Button = 1
                Start_BT.Text = "Stop"
                TextBox1.Enabled = False
            End If
        Else
            Timer1.Stop()
            Button = 0
            Start_BT.Text = "Start"
            TextBox1.Enabled = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim hour = My.Computer.Clock.LocalTime
        Dim Ping As Net.NetworkInformation.PingReply
        Dim SendPing As New Net.NetworkInformation.Ping
        Dim ResponseTime As Decimal

        Try
            Ping = SendPing.Send(UserDomain, 1000)
            ResponseTime = Ping.RoundtripTime
            If Ping.Status = Net.NetworkInformation.IPStatus.TimedOut Then
                ResponseTime = 1000
            End If
        Catch ex As Exception
            ResponseTime = 1000
        End Try

        If ResponseTime = 1000 Then
            DataGridView1.Rows.Add(Num.ToString, hour.ToString, TextBox1.Text, "Error")
            DataGridView1.Item(3, Num).Style.BackColor = Color.Red
            DataGridView1.Sort(Time, System.ComponentModel.ListSortDirection.Descending)
            Lost += 1

        Else
            DataGridView1.Rows.Add(Num.ToString, hour.ToString, TextBox1.Text, ResponseTime)
            DataGridView1.Item(3, Num).Style.BackColor = Color.Green
            DataGridView1.Sort(Time, System.ComponentModel.ListSortDirection.Descending)
            Rcv += 1
            avg1 += ResponseTime
            If ResponseTime >= Max Then
                Max = ResponseTime
            End If

            If ResponseTime <= Min Then
                Min = ResponseTime
            End If
        End If

        Stats()
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

    Private Sub Export_BT_Click(sender As Object, e As EventArgs) Handles Export_BT.Click
        SaveFileDialog1.ShowDialog()
        Dim path As String = SaveFileDialog1.FileName.ToString
        If path = "" Then
            MsgBox("Please define the file path", MsgBoxStyle.Exclamation)
        Else
            Dim StrExport As String = ""
            For Each C As DataGridViewColumn In DataGridView1.Columns
                StrExport &= """" & C.HeaderText & ""","
            Next
            StrExport = StrExport.Substring(0, StrExport.Length - 1)
            StrExport &= Environment.NewLine

            For Each R As DataGridViewRow In DataGridView1.Rows
                For Each C As DataGridViewCell In R.Cells
                    If C.Value IsNot Nothing Then
                        StrExport &= """" & C.Value.ToString & ""","
                    Else
                        StrExport &= """" & "" & ""","
                    End If
                Next
                StrExport = StrExport.Substring(0, StrExport.Length - 1)
                StrExport &= Environment.NewLine
            Next

            Dim tw As IO.TextWriter = New IO.StreamWriter(path)
            tw.Write(StrExport)
            tw.Close()
        End If
    End Sub

    Sub Stats()
        Dim percent As Decimal
        Dim Sent As Integer = Num + 1
        Sent_MLB.Text = Sent.ToString
        Time_MLB.Text = String.Format("{0} s", Sent.ToString)

        'Lost
        percent = Math.Round((Lost / Sent) * 100)
        Lost_MLB.Text = String.Format("{0} / {1}%", Lost.ToString, percent)

        'Received
        percent = Math.Round((Rcv / Sent) * 100)
        Rcv_MLB.Text = String.Format("{0} / {1}%", Rcv.ToString, percent)

        'Avg
        Dim Avg As Decimal = Math.Round(avg1 / Rcv)
        Avg_MLB.Text = String.Format("{0} ms", avg.ToString)

        'Min
        Min_MLB.Text = String.Format("{0} ms", Min.ToString)

        'Max
        Max_MLB.Text = String.Format("{0} ms", Max.ToString)
    End Sub
End Class
