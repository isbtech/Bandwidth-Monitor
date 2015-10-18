Imports System.Threading
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.IO


Public Class Main
    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Conversioncmbbox.SelectedIndex = 0
        webservercmdbox.SelectedIndex = 0
        Dim Getinfosub = New Thread(Sub() Me.GetInfo())
        Getinfosub.IsBackground = True
        Getinfosub.Start()

    End Sub
    Dim i1 As Integer
    Private Sub GetInfo()

        Dim networkInterfaces As New System.Diagnostics.PerformanceCounterCategory("Network Interface")
        Dim nics As String() = networkInterfaces.GetInstanceNames()
        Dim bytesSent(nics.Length - 1) As System.Diagnostics.PerformanceCounter
        Dim bytesReceived(nics.Length - 1) As System.Diagnostics.PerformanceCounter
        Dim i As Integer
        For i = 0 To nics.Length - 1
            bytesSent(i) = New System.Diagnostics.PerformanceCounter("Network Interface", "Bytes Sent/sec", nics(i), True)
            bytesReceived(i) = New System.Diagnostics.PerformanceCounter("Network Interface", "Bytes received/sec", nics(i), True)
        Next


        For i = 0 To nics.Length - 1
            Dim AddItemsub = New Thread(Sub() Me.AddItem(nics(i)))
            AddItemsub.IsBackground = True
            AddItemsub.Start()
            Do Until AddItemsub.IsAlive = False
                Threading.Thread.Sleep(100)
            Loop

        Next
        Do
            If running = True Then
                i1 += 1
            End If
            For i = 0 To nics.Length - 1
                Try
                    If i1 = 20 Then

                        SetItemText(Math.Abs(bytesSent(i).NextValue), Math.Abs(bytesReceived(i).NextValue), i, True)

                        Threading.Thread.Sleep(100)

                        i1 = 0
                    Else
                        SetItemText(Math.Abs(bytesSent(i).NextValue), Math.Abs(bytesReceived(i).NextValue), i, False)

                        Threading.Thread.Sleep(100)
                    End If

                    'AdapterListBox.Items(i) = String.Format("     interface {0}: {1} bytes sent/sec, {2} bytes received/sec.  ", i, bytesSent(i).NextValue, bytesReceived(i).NextValue)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Next
            Threading.Thread.Sleep(100)
        Loop
    End Sub
    Private Delegate Sub SetItemTextDelegate(ByVal upload As Integer, ByVal download As Integer, ByVal index As Integer, ByVal logpoints As Boolean)

    Dim DataDownload As String
    Private Sub SetItemText(ByVal upload As Integer, ByVal download As Integer, ByVal index As Integer, ByVal logpoints As Boolean)
        If Me.InvokeRequired Then
            Me.Invoke(New SetItemTextDelegate(AddressOf SetItemText), upload, download, index, logpoints)
        Else
            If Conversioncmbbox.Text = "Bytes" Then
                AdapterGridView.Rows(index).Cells(1).Value = (Math.Round(upload, 2).ToString & " B/s").ToString
                AdapterGridView.Rows(index).Cells(2).Value = (Math.Round(download, 2).ToString & " B/s").ToString
            ElseIf Conversioncmbbox.Text = "KiloBytes" Then
                AdapterGridView.Rows(index).Cells(1).Value = (Math.Round(upload / 1024, 2).ToString & " KB/s").ToString
                AdapterGridView.Rows(index).Cells(2).Value = (Math.Round(download / 1024, 2).ToString & " KB/s").ToString
            ElseIf Conversioncmbbox.Text = "MegaBytes" Then
                AdapterGridView.Rows(index).Cells(1).Value = (Math.Round(upload / 1024 / 1024, 2).ToString & " MB/s").ToString
                AdapterGridView.Rows(index).Cells(2).Value = (Math.Round(download / 1024 / 1024, 2).ToString & " MB/s").ToString
            End If
            If index = AdapterGridView.CurrentCell.RowIndex Then
                If running = True Then
                    If webservercmdbox.Text = "Bytes" Then
                        DataDownload += Math.Round(download).ToString + "|"
                    ElseIf webservercmdbox.Text = "KiloBytes" Then
                        DataDownload += Math.Round(download / 1024).ToString + "|"
                    ElseIf webservercmdbox.Text = "MegaBytes" Then
                        DataDownload += Math.Round(download / 1024 / 1024).ToString + "|"
                    End If
                End If

                If Conversioncmbbox.Text = "Bytes" Then
                    'AddGraphPlot(Math.Round(upload, 2))
                    AddGraphPlot(Math.Round(download), Math.Round(upload))
                ElseIf Conversioncmbbox.Text = "KiloBytes" Then
                    'AddGraphPlot(Math.Round(upload / 1024, 2))
                    AddGraphPlot(Math.Round(download / 1024), Math.Round(upload / 1024))
                ElseIf Conversioncmbbox.Text = "MegaBytes" Then
                    'AddGraphPlot(Math.Round(upload / 1024 / 1024, 2))
                    AddGraphPlot(Math.Round(download / 1024 / 1024), Math.Round(upload / 1024 / 1024))
                End If
            End If

            If logpoints = True Then
                Dim DownloadDataToInsert As String = String.Empty
                Dim testinfo As Integer = 0

                For Each datapoint As String In DataDownload.Split("|")
                    testinfo += 1
                    If Not datapoint = "" Then
                        DownloadDataToInsert += "{ X: """", Y: " + datapoint + " }," + vbNewLine
                    End If
                Next

                DataDownload = ""
                DownloadDataToInsert += "//DATAEND"
                Dim filecontents As List(Of String) = File.ReadAllLines(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Web_Files", "main.html")).ToList
                Dim datatowrite As String = ""
                Dim ct As Integer = 0
                Dim datastart, dataend As Integer
                Using writer As StreamWriter = New StreamWriter(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Web_Files", "main.html"))
                    For Each str As String In filecontents
                        ct += 1
                        If str.Contains("//DATASTART") Then
                            datastart = ct
                        ElseIf str.Contains("//DATAEND") Then
                            dataend = ct
                            Exit For
                        End If
                    Next
                    If dataend - datastart >= Maxplotpointsnumeric.Value Then
                        For start As Integer = datastart To datastart + 19
                            filecontents.RemoveAt(start)
                        Next

                    End If

                    For Each str As String In filecontents
                        datatowrite += str + vbNewLine
                    Next
                    datatowrite = datatowrite.Replace("//DATAEND", DownloadDataToInsert)
                    writer.Write(datatowrite)
                End Using
            End If

        End If
    End Sub

    Private Delegate Sub AddItemDelegate(ByVal text As String)
    Private Sub AddItem(ByVal text As String)
        If Me.InvokeRequired Then
            Me.Invoke(New AddItemDelegate(AddressOf AddItem), text)
        Else
            UpdateStripStatus.Text = "Added: " + text
            AdapterGridView.Rows.Add(text)
        End If
    End Sub
    Private Delegate Sub AddGraphPlotDelegate(ByVal Point As Integer, ByVal UploadPoint As Integer)
    Private Sub AddGraphPlot(ByVal Point As Integer, ByVal UploadPoint As Integer)
        If Me.InvokeRequired Then
            Me.Invoke(New AddGraphPlotDelegate(AddressOf AddGraphPlot), Point, UploadPoint)
        Else
            SpeedGraphUpload.AddValue(UploadPoint)
            SpeedGraph.AddValue(Point)
        End If
    End Sub

    Private Sub Main_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Environment.Exit(0)
    End Sub

    Private Sub Conversioncmbbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Conversioncmbbox.SelectedIndexChanged
        SpeedGraphUpload.Clear()
        SpeedGraph.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GraphResetbtn.Click
        SpeedGraphUpload.Clear()
        SpeedGraph.Clear()
    End Sub

    Private Sub AdapterGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles AdapterGridView.RowEnter
        SpeedGraphUpload.Clear()
        SpeedGraph.Clear()
    End Sub
    Dim running As Boolean = False
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles LaunchServerbtn.Click

        If running = True Then
            httpservermain.Stop()
            running = False
            UpdateStripStatus.Text = "Webserver stopped"
            LaunchServerbtn.Text = "Launch Webserver"
        Else
            Try
                If My.Computer.FileSystem.DirectoryExists(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Web_Files")) = False Then
                    My.Computer.FileSystem.CreateDirectory(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Web_Files"))
                End If

                If My.Computer.FileSystem.FileExists(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Web_Files", "main.html")) Then
                    My.Computer.FileSystem.DeleteFile(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Web_Files", "main.html"))
                    Using writer As StreamWriter = New StreamWriter(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Web_Files", "main.html"))
                        Dim docinfo As String = My.Resources.WebServercontents
                        docinfo = docinfo.Replace("//WIDTH//", Graphwidthnumeric.Value)
                        docinfo = docinfo.Replace("//HEIGHT//", GraphHeightnumeric.Value)
                        docinfo = docinfo.Replace("//YINTERVAL//", YIntervalnumeric.Value)
                        writer.Write(docinfo)
                    End Using
                Else
                    Using writer As StreamWriter = New StreamWriter(System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Web_Files", "main.html"))
                        Dim docinfo As String = My.Resources.WebServercontents
                        docinfo = docinfo.Replace("//WIDTH//", Graphwidthnumeric.Value)
                        docinfo = docinfo.Replace("//HEIGHT//", GraphHeightnumeric.Value)
                        docinfo = docinfo.Replace("//YINTERVAL//", YIntervalnumeric.Value)
                        writer.Write(docinfo)
                    End Using
                End If
                Dim hostName As String = Dns.GetHostName()
                Dim serverIP As IPAddress = Dns.Resolve(hostName).AddressList(0)
                httpservermain.ServerPort = webserverportnumeric.Value
                httpservermain.Start()
                running = True
                UpdateStripStatus.Text = "Webserver started at: " & serverIP.ToString() & ":" & webserverportnumeric.Value.ToString
                LaunchServerbtn.Text = "Stop Webserver"
            Catch ex As Exception
                MessageBox.Show(ex.StackTrace.ToString())
            End Try
        End If

    End Sub

    Private Sub httpservermain_ProcessRequest(sender As Object, e As SimpleHttpServer.ProcessRequestEventArgs) Handles httpservermain.ProcessRequest
        If e.Response.Request.Method = SimpleHttpServer.HttpMethod.GET.ToString Then
            Dim filePath As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Web_Files", e.Response.Request.FileName)
            If System.IO.File.Exists(filePath) Then
                e.Response.Content = System.IO.File.ReadAllBytes(filePath)
                e.Response.Headers(SimpleHttpServer.HttpResponse.ResponseHeader.Content_Type) = SimpleHttpServer.MimeTypes.TextMimeTypes.html
                e.Response.Headers(SimpleHttpServer.HttpResponse.ResponseHeader.Content_Encoding) = SimpleHttpServer.ContentCompressionEncoding.identity
            Else
                e.Response.Status = Net.HttpStatusCode.NotFound
            End If
        Else
            e.Response.Status = Net.HttpStatusCode.MethodNotAllowed
        End If
    End Sub
End Class




