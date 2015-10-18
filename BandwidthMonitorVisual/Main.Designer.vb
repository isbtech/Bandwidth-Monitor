<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.AdapterGridView = New System.Windows.Forms.DataGridView()
        Me.AdapterName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UploadSpeed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DownloadSpeed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Conversioncmbbox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GraphResetbtn = New System.Windows.Forms.Button()
        Me.LaunchServerbtn = New System.Windows.Forms.Button()
        Me.webserverportnumeric = New System.Windows.Forms.NumericUpDown()
        Me.UpdateStrip = New System.Windows.Forms.StatusStrip()
        Me.UpdateStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SpeedGraphUpload = New BandwidthMonitorVisual.Graph()
        Me.SpeedGraph = New BandwidthMonitorVisual.Graph()
        Me.httpservermain = New SimpleHttpServer.HttpServer(Me.components)
        Me.Graphwidthnumeric = New System.Windows.Forms.NumericUpDown()
        Me.GraphHeightnumeric = New System.Windows.Forms.NumericUpDown()
        Me.YIntervalnumeric = New System.Windows.Forms.NumericUpDown()
        Me.Maxplotpointsnumeric = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.webservercmdbox = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.AdapterGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.webserverportnumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UpdateStrip.SuspendLayout()
        CType(Me.Graphwidthnumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GraphHeightnumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YIntervalnumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Maxplotpointsnumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdapterGridView
        '
        Me.AdapterGridView.AllowUserToAddRows = False
        Me.AdapterGridView.AllowUserToDeleteRows = False
        Me.AdapterGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AdapterGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AdapterGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.AdapterGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.AdapterGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdapterName, Me.UploadSpeed, Me.DownloadSpeed})
        Me.AdapterGridView.Location = New System.Drawing.Point(12, 12)
        Me.AdapterGridView.Name = "AdapterGridView"
        Me.AdapterGridView.ReadOnly = True
        Me.AdapterGridView.RowHeadersVisible = False
        Me.AdapterGridView.ShowCellErrors = False
        Me.AdapterGridView.ShowCellToolTips = False
        Me.AdapterGridView.ShowEditingIcon = False
        Me.AdapterGridView.ShowRowErrors = False
        Me.AdapterGridView.Size = New System.Drawing.Size(689, 150)
        Me.AdapterGridView.TabIndex = 1
        Me.AdapterGridView.TabStop = False
        '
        'AdapterName
        '
        Me.AdapterName.HeaderText = "Adapter Name"
        Me.AdapterName.Name = "AdapterName"
        Me.AdapterName.ReadOnly = True
        '
        'UploadSpeed
        '
        Me.UploadSpeed.HeaderText = "Upload Speed"
        Me.UploadSpeed.Name = "UploadSpeed"
        Me.UploadSpeed.ReadOnly = True
        '
        'DownloadSpeed
        '
        Me.DownloadSpeed.HeaderText = "Download Speed"
        Me.DownloadSpeed.Name = "DownloadSpeed"
        Me.DownloadSpeed.ReadOnly = True
        '
        'Conversioncmbbox
        '
        Me.Conversioncmbbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Conversioncmbbox.FormattingEnabled = True
        Me.Conversioncmbbox.Items.AddRange(New Object() {"Bytes", "KiloBytes", "MegaBytes"})
        Me.Conversioncmbbox.Location = New System.Drawing.Point(13, 169)
        Me.Conversioncmbbox.Name = "Conversioncmbbox"
        Me.Conversioncmbbox.Size = New System.Drawing.Size(121, 21)
        Me.Conversioncmbbox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(307, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Download"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Upload"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "↑ Start"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 539)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "↑ Start"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(645, 539)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Current ↑"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(645, 358)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Current ↑"
        '
        'GraphResetbtn
        '
        Me.GraphResetbtn.Location = New System.Drawing.Point(140, 169)
        Me.GraphResetbtn.Name = "GraphResetbtn"
        Me.GraphResetbtn.Size = New System.Drawing.Size(89, 23)
        Me.GraphResetbtn.TabIndex = 11
        Me.GraphResetbtn.Text = "Reset Graphs"
        Me.GraphResetbtn.UseVisualStyleBackColor = True
        '
        'LaunchServerbtn
        '
        Me.LaunchServerbtn.Location = New System.Drawing.Point(476, 167)
        Me.LaunchServerbtn.Name = "LaunchServerbtn"
        Me.LaunchServerbtn.Size = New System.Drawing.Size(115, 23)
        Me.LaunchServerbtn.TabIndex = 12
        Me.LaunchServerbtn.Text = "Launch Webserver"
        Me.LaunchServerbtn.UseVisualStyleBackColor = True
        '
        'webserverportnumeric
        '
        Me.webserverportnumeric.Location = New System.Drawing.Point(598, 169)
        Me.webserverportnumeric.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.webserverportnumeric.Name = "webserverportnumeric"
        Me.webserverportnumeric.Size = New System.Drawing.Size(79, 20)
        Me.webserverportnumeric.TabIndex = 13
        Me.webserverportnumeric.Value = New Decimal(New Integer() {8080, 0, 0, 0})
        '
        'UpdateStrip
        '
        Me.UpdateStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateStripStatus})
        Me.UpdateStrip.Location = New System.Drawing.Point(0, 618)
        Me.UpdateStrip.Name = "UpdateStrip"
        Me.UpdateStrip.Size = New System.Drawing.Size(713, 22)
        Me.UpdateStrip.TabIndex = 14
        '
        'UpdateStripStatus
        '
        Me.UpdateStripStatus.Name = "UpdateStripStatus"
        Me.UpdateStripStatus.Size = New System.Drawing.Size(0, 17)
        '
        'SpeedGraphUpload
        '
        Me.SpeedGraphUpload.BorderColor = System.Drawing.Color.Gray
        Me.SpeedGraphUpload.DataColumnForeColor = System.Drawing.Color.Gray
        Me.SpeedGraphUpload.DataSmoothing = True
        Me.SpeedGraphUpload.DataSmoothingLevel = CType(2, Byte)
        Me.SpeedGraphUpload.DrawDataColumn = True
        Me.SpeedGraphUpload.DrawHorizontalLines = True
        Me.SpeedGraphUpload.DrawHoverData = True
        Me.SpeedGraphUpload.DrawHoverLine = True
        Me.SpeedGraphUpload.DrawLineGraph = False
        Me.SpeedGraphUpload.DrawVerticalLines = True
        Me.SpeedGraphUpload.FillColor = System.Drawing.Color.White
        Me.SpeedGraphUpload.GraphBorderColor = System.Drawing.Color.Turquoise
        Me.SpeedGraphUpload.GraphFillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SpeedGraphUpload.HorizontalLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SpeedGraphUpload.HoverBorderColor = System.Drawing.Color.Turquoise
        Me.SpeedGraphUpload.HoverFillColor = System.Drawing.Color.White
        Me.SpeedGraphUpload.HoverLabelBorderColor = System.Drawing.Color.DarkGray
        Me.SpeedGraphUpload.HoverLabelFillColor = System.Drawing.Color.White
        Me.SpeedGraphUpload.HoverLabelForeColor = System.Drawing.Color.Gray
        Me.SpeedGraphUpload.HoverLabelShadowColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SpeedGraphUpload.HoverLineColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.SpeedGraphUpload.LineGraphColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SpeedGraphUpload.Location = New System.Drawing.Point(12, 377)
        Me.SpeedGraphUpload.Name = "SpeedGraphUpload"
        Me.SpeedGraphUpload.OverrideMax = False
        Me.SpeedGraphUpload.OverrideMaxValue = 100.0!
        Me.SpeedGraphUpload.OverrideMin = False
        Me.SpeedGraphUpload.OverrideMinValue = 0!
        Me.SpeedGraphUpload.SidePadding = True
        Me.SpeedGraphUpload.Size = New System.Drawing.Size(689, 159)
        Me.SpeedGraphUpload.TabIndex = 5
        Me.SpeedGraphUpload.Text = "Graph1"
        Me.SpeedGraphUpload.Values = New Single() {5.0!}
        Me.SpeedGraphUpload.VerticalLineColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        'SpeedGraph
        '
        Me.SpeedGraph.BorderColor = System.Drawing.Color.Gray
        Me.SpeedGraph.DataColumnForeColor = System.Drawing.Color.Gray
        Me.SpeedGraph.DataSmoothing = True
        Me.SpeedGraph.DataSmoothingLevel = CType(2, Byte)
        Me.SpeedGraph.DrawDataColumn = True
        Me.SpeedGraph.DrawHorizontalLines = True
        Me.SpeedGraph.DrawHoverData = True
        Me.SpeedGraph.DrawHoverLine = True
        Me.SpeedGraph.DrawLineGraph = False
        Me.SpeedGraph.DrawVerticalLines = True
        Me.SpeedGraph.FillColor = System.Drawing.Color.White
        Me.SpeedGraph.GraphBorderColor = System.Drawing.Color.ForestGreen
        Me.SpeedGraph.GraphFillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.SpeedGraph.HorizontalLineColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.SpeedGraph.HoverBorderColor = System.Drawing.Color.ForestGreen
        Me.SpeedGraph.HoverFillColor = System.Drawing.Color.White
        Me.SpeedGraph.HoverLabelBorderColor = System.Drawing.Color.DarkGray
        Me.SpeedGraph.HoverLabelFillColor = System.Drawing.Color.White
        Me.SpeedGraph.HoverLabelForeColor = System.Drawing.Color.Gray
        Me.SpeedGraph.HoverLabelShadowColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SpeedGraph.HoverLineColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.SpeedGraph.LineGraphColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SpeedGraph.Location = New System.Drawing.Point(12, 196)
        Me.SpeedGraph.Name = "SpeedGraph"
        Me.SpeedGraph.OverrideMax = False
        Me.SpeedGraph.OverrideMaxValue = 100.0!
        Me.SpeedGraph.OverrideMin = False
        Me.SpeedGraph.OverrideMinValue = 0!
        Me.SpeedGraph.SidePadding = True
        Me.SpeedGraph.Size = New System.Drawing.Size(689, 159)
        Me.SpeedGraph.TabIndex = 3
        Me.SpeedGraph.Text = "Graph1"
        Me.SpeedGraph.Values = New Single() {5.0!}
        Me.SpeedGraph.VerticalLineColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        '
        'httpservermain
        '
        Me.httpservermain.ContainerControl = Me
        Me.httpservermain.CustomParserName = Nothing
        Me.httpservermain.HttpVersion = "HTTP/1.1"
        Me.httpservermain.MessageBufferSize = 256
        Me.httpservermain.ServerPort = 80
        Me.httpservermain.ServerVersion = "NetworkMonitorWebserver/1.0.0.0"
        Me.httpservermain.TextEncoding = CType(resources.GetObject("httpservermain.TextEncoding"), System.Text.Encoding)
        '
        'Graphwidthnumeric
        '
        Me.Graphwidthnumeric.Location = New System.Drawing.Point(14, 588)
        Me.Graphwidthnumeric.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.Graphwidthnumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Graphwidthnumeric.Name = "Graphwidthnumeric"
        Me.Graphwidthnumeric.Size = New System.Drawing.Size(90, 20)
        Me.Graphwidthnumeric.TabIndex = 15
        Me.Graphwidthnumeric.Value = New Decimal(New Integer() {800, 0, 0, 0})
        '
        'GraphHeightnumeric
        '
        Me.GraphHeightnumeric.Location = New System.Drawing.Point(110, 588)
        Me.GraphHeightnumeric.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.GraphHeightnumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.GraphHeightnumeric.Name = "GraphHeightnumeric"
        Me.GraphHeightnumeric.Size = New System.Drawing.Size(84, 20)
        Me.GraphHeightnumeric.TabIndex = 16
        Me.GraphHeightnumeric.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'YIntervalnumeric
        '
        Me.YIntervalnumeric.Location = New System.Drawing.Point(200, 588)
        Me.YIntervalnumeric.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.YIntervalnumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.YIntervalnumeric.Name = "YIntervalnumeric"
        Me.YIntervalnumeric.Size = New System.Drawing.Size(81, 20)
        Me.YIntervalnumeric.TabIndex = 17
        Me.YIntervalnumeric.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Maxplotpointsnumeric
        '
        Me.Maxplotpointsnumeric.Location = New System.Drawing.Point(287, 588)
        Me.Maxplotpointsnumeric.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.Maxplotpointsnumeric.Minimum = New Decimal(New Integer() {19, 0, 0, 0})
        Me.Maxplotpointsnumeric.Name = "Maxplotpointsnumeric"
        Me.Maxplotpointsnumeric.Size = New System.Drawing.Size(120, 20)
        Me.Maxplotpointsnumeric.TabIndex = 18
        Me.Maxplotpointsnumeric.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(275, 539)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Webserver Settings"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(298, 572)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Max Plotted Points"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(211, 572)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Y-Interval"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(114, 574)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Graph Height"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 572)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Graph Width"
        '
        'webservercmdbox
        '
        Me.webservercmdbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.webservercmdbox.FormattingEnabled = True
        Me.webservercmdbox.Items.AddRange(New Object() {"Bytes", "KiloBytes", "MegaBytes"})
        Me.webservercmdbox.Location = New System.Drawing.Point(413, 587)
        Me.webservercmdbox.Name = "webservercmdbox"
        Me.webservercmdbox.Size = New System.Drawing.Size(121, 21)
        Me.webservercmdbox.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(437, 571)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Data Type"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(540, 582)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 26)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Server must be restarted " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for the changes to take effect"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 640)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.webservercmdbox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Maxplotpointsnumeric)
        Me.Controls.Add(Me.YIntervalnumeric)
        Me.Controls.Add(Me.GraphHeightnumeric)
        Me.Controls.Add(Me.Graphwidthnumeric)
        Me.Controls.Add(Me.UpdateStrip)
        Me.Controls.Add(Me.webserverportnumeric)
        Me.Controls.Add(Me.LaunchServerbtn)
        Me.Controls.Add(Me.GraphResetbtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SpeedGraphUpload)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SpeedGraph)
        Me.Controls.Add(Me.Conversioncmbbox)
        Me.Controls.Add(Me.AdapterGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Main"
        Me.Text = "Network Monitor"
        CType(Me.AdapterGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.webserverportnumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UpdateStrip.ResumeLayout(False)
        Me.UpdateStrip.PerformLayout()
        CType(Me.Graphwidthnumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GraphHeightnumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YIntervalnumeric, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Maxplotpointsnumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdapterGridView As DataGridView
    Friend WithEvents AdapterName As DataGridViewTextBoxColumn
    Friend WithEvents UploadSpeed As DataGridViewTextBoxColumn
    Friend WithEvents DownloadSpeed As DataGridViewTextBoxColumn
    Friend WithEvents Conversioncmbbox As ComboBox
    Friend WithEvents SpeedGraph As Graph
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SpeedGraphUpload As Graph
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GraphResetbtn As Button
    Friend WithEvents LaunchServerbtn As Button
    Friend WithEvents webserverportnumeric As NumericUpDown
    Friend WithEvents UpdateStrip As StatusStrip
    Friend WithEvents UpdateStripStatus As ToolStripStatusLabel
    Friend WithEvents httpservermain As SimpleHttpServer.HttpServer
    Friend WithEvents Label12 As Label
    Friend WithEvents webservercmdbox As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Maxplotpointsnumeric As NumericUpDown
    Friend WithEvents YIntervalnumeric As NumericUpDown
    Friend WithEvents GraphHeightnumeric As NumericUpDown
    Friend WithEvents Graphwidthnumeric As NumericUpDown
    Friend WithEvents Label13 As Label
End Class
