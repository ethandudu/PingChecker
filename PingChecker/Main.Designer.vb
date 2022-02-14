<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Domain = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Latency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Start_BT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Name_LB = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Icon_PB = New System.Windows.Forms.PictureBox()
        Me.Start_LB = New System.Windows.Forms.Label()
        Me.Started_time_LB = New System.Windows.Forms.Label()
        Me.Credit = New System.Windows.Forms.Label()
        Me.Version_LB = New System.Windows.Forms.Label()
        Me.Export_BT = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Time_MLB = New System.Windows.Forms.Label()
        Me.Avg_MLB = New System.Windows.Forms.Label()
        Me.Max_MLB = New System.Windows.Forms.Label()
        Me.Min_MLB = New System.Windows.Forms.Label()
        Me.Rcv_MLB = New System.Windows.Forms.Label()
        Me.Lost_MLB = New System.Windows.Forms.Label()
        Me.Sent_MLB = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Icon_PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Time, Me.Domain, Me.Latency})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(27, 111)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(512, 197)
        Me.DataGridView1.TabIndex = 4
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 43
        '
        'Time
        '
        Me.Time.HeaderText = "Date"
        Me.Time.Name = "Time"
        Me.Time.ReadOnly = True
        Me.Time.Width = 55
        '
        'Domain
        '
        Me.Domain.HeaderText = "Domain"
        Me.Domain.Name = "Domain"
        Me.Domain.ReadOnly = True
        Me.Domain.Width = 68
        '
        'Latency
        '
        Me.Latency.HeaderText = "Latency"
        Me.Latency.Name = "Latency"
        Me.Latency.ReadOnly = True
        Me.Latency.Width = 70
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TextBox1.Location = New System.Drawing.Point(345, 375)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(110, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Start_BT
        '
        Me.Start_BT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Start_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Start_BT.Location = New System.Drawing.Point(363, 401)
        Me.Start_BT.Name = "Start_BT"
        Me.Start_BT.Size = New System.Drawing.Size(75, 23)
        Me.Start_BT.TabIndex = 2
        Me.Start_BT.Text = "Start"
        Me.Start_BT.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(367, 350)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Destination :"
        '
        'Name_LB
        '
        Me.Name_LB.AutoSize = True
        Me.Name_LB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Name_LB.Location = New System.Drawing.Point(341, 9)
        Me.Name_LB.Name = "Name_LB"
        Me.Name_LB.Size = New System.Drawing.Size(119, 24)
        Me.Name_LB.TabIndex = 4
        Me.Name_LB.Text = "PingChecker"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Icon_PB
        '
        Me.Icon_PB.Image = Global.PingChecker.My.Resources.Resources.icons8_link_100
        Me.Icon_PB.Location = New System.Drawing.Point(375, 36)
        Me.Icon_PB.Name = "Icon_PB"
        Me.Icon_PB.Size = New System.Drawing.Size(50, 50)
        Me.Icon_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Icon_PB.TabIndex = 5
        Me.Icon_PB.TabStop = False
        '
        'Start_LB
        '
        Me.Start_LB.AutoSize = True
        Me.Start_LB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start_LB.Location = New System.Drawing.Point(177, 311)
        Me.Start_LB.Name = "Start_LB"
        Me.Start_LB.Size = New System.Drawing.Size(62, 13)
        Me.Start_LB.TabIndex = 3
        Me.Start_LB.Text = "Started at : "
        '
        'Started_time_LB
        '
        Me.Started_time_LB.AutoSize = True
        Me.Started_time_LB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Started_time_LB.Location = New System.Drawing.Point(247, 311)
        Me.Started_time_LB.Name = "Started_time_LB"
        Me.Started_time_LB.Size = New System.Drawing.Size(124, 13)
        Me.Started_time_LB.TabIndex = 3
        Me.Started_time_LB.Text = "XX/XX/XXXX XX:XX:XX"
        '
        'Credit
        '
        Me.Credit.AutoSize = True
        Me.Credit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Credit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credit.Location = New System.Drawing.Point(12, 426)
        Me.Credit.Name = "Credit"
        Me.Credit.Size = New System.Drawing.Size(140, 13)
        Me.Credit.TabIndex = 3
        Me.Credit.Text = "Made with 💖 by Ethandudu"
        '
        'Version_LB
        '
        Me.Version_LB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Version_LB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version_LB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Version_LB.Location = New System.Drawing.Point(725, 426)
        Me.Version_LB.Name = "Version_LB"
        Me.Version_LB.Size = New System.Drawing.Size(63, 15)
        Me.Version_LB.TabIndex = 3
        Me.Version_LB.Text = "X.X.X.X"
        Me.Version_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Export_BT
        '
        Me.Export_BT.Location = New System.Drawing.Point(464, 314)
        Me.Export_BT.Name = "Export_BT"
        Me.Export_BT.Size = New System.Drawing.Size(75, 23)
        Me.Export_BT.TabIndex = 6
        Me.Export_BT.Text = "Export"
        Me.Export_BT.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.CheckFileExists = True
        Me.SaveFileDialog1.DefaultExt = "csv"
        Me.SaveFileDialog1.Filter = "CSV File|*.csv"
        Me.SaveFileDialog1.RestoreDirectory = True
        Me.SaveFileDialog1.Title = "Choose path for exporting"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Time_MLB)
        Me.GroupBox1.Controls.Add(Me.Avg_MLB)
        Me.GroupBox1.Controls.Add(Me.Max_MLB)
        Me.GroupBox1.Controls.Add(Me.Min_MLB)
        Me.GroupBox1.Controls.Add(Me.Rcv_MLB)
        Me.GroupBox1.Controls.Add(Me.Lost_MLB)
        Me.GroupBox1.Controls.Add(Me.Sent_MLB)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(588, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 116)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stats"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Time elapsed :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Avg :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Max :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Min :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Received :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Lost :"
        '
        'Time_MLB
        '
        Me.Time_MLB.AutoSize = True
        Me.Time_MLB.Location = New System.Drawing.Point(88, 98)
        Me.Time_MLB.Name = "Time_MLB"
        Me.Time_MLB.Size = New System.Drawing.Size(28, 13)
        Me.Time_MLB.TabIndex = 0
        Me.Time_MLB.Text = "XXX"
        '
        'Avg_MLB
        '
        Me.Avg_MLB.AutoSize = True
        Me.Avg_MLB.Location = New System.Drawing.Point(37, 85)
        Me.Avg_MLB.Name = "Avg_MLB"
        Me.Avg_MLB.Size = New System.Drawing.Size(28, 13)
        Me.Avg_MLB.TabIndex = 0
        Me.Avg_MLB.Text = "XXX"
        '
        'Max_MLB
        '
        Me.Max_MLB.AutoSize = True
        Me.Max_MLB.Location = New System.Drawing.Point(37, 72)
        Me.Max_MLB.Name = "Max_MLB"
        Me.Max_MLB.Size = New System.Drawing.Size(28, 13)
        Me.Max_MLB.TabIndex = 0
        Me.Max_MLB.Text = "XXX"
        '
        'Min_MLB
        '
        Me.Min_MLB.AutoSize = True
        Me.Min_MLB.Location = New System.Drawing.Point(37, 59)
        Me.Min_MLB.Name = "Min_MLB"
        Me.Min_MLB.Size = New System.Drawing.Size(28, 13)
        Me.Min_MLB.TabIndex = 0
        Me.Min_MLB.Text = "XXX"
        '
        'Rcv_MLB
        '
        Me.Rcv_MLB.AutoSize = True
        Me.Rcv_MLB.Location = New System.Drawing.Point(71, 46)
        Me.Rcv_MLB.Name = "Rcv_MLB"
        Me.Rcv_MLB.Size = New System.Drawing.Size(28, 13)
        Me.Rcv_MLB.TabIndex = 0
        Me.Rcv_MLB.Text = "XXX"
        '
        'Lost_MLB
        '
        Me.Lost_MLB.AutoSize = True
        Me.Lost_MLB.Location = New System.Drawing.Point(45, 33)
        Me.Lost_MLB.Name = "Lost_MLB"
        Me.Lost_MLB.Size = New System.Drawing.Size(28, 13)
        Me.Lost_MLB.TabIndex = 0
        Me.Lost_MLB.Text = "XXX"
        '
        'Sent_MLB
        '
        Me.Sent_MLB.AutoSize = True
        Me.Sent_MLB.Location = New System.Drawing.Point(45, 20)
        Me.Sent_MLB.Name = "Sent_MLB"
        Me.Sent_MLB.Size = New System.Drawing.Size(28, 13)
        Me.Sent_MLB.TabIndex = 0
        Me.Sent_MLB.Text = "XXX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sent :"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Export_BT)
        Me.Controls.Add(Me.Icon_PB)
        Me.Controls.Add(Me.Name_LB)
        Me.Controls.Add(Me.Version_LB)
        Me.Controls.Add(Me.Started_time_LB)
        Me.Controls.Add(Me.Credit)
        Me.Controls.Add(Me.Start_LB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Start_BT)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PingChecker"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Icon_PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Start_BT As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Name_LB As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Icon_PB As PictureBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Time As DataGridViewTextBoxColumn
    Friend WithEvents Domain As DataGridViewTextBoxColumn
    Friend WithEvents Latency As DataGridViewTextBoxColumn
    Friend WithEvents Start_LB As Label
    Friend WithEvents Started_time_LB As Label
    Friend WithEvents Credit As Label
    Friend WithEvents Version_LB As Label
    Friend WithEvents Export_BT As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Avg_MLB As Label
    Friend WithEvents Max_MLB As Label
    Friend WithEvents Min_MLB As Label
    Friend WithEvents Rcv_MLB As Label
    Friend WithEvents Lost_MLB As Label
    Friend WithEvents Sent_MLB As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Time_MLB As Label
End Class
