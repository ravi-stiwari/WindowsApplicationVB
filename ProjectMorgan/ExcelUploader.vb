
Imports System.Data.OleDb
Imports Microsoft.Office.Interop

Public Class ExcelUploader

    Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click
        Dim folderDlg As New FolderBrowserDialog
        folderDlg.Description = "Select the folder which contains data excel files..."
        folderDlg.ShowNewFolderButton = True
        If (folderDlg.ShowDialog() = DialogResult.OK) Then
            ListBox1.Text = folderDlg.SelectedPath
            filepathLbl.Text = folderDlg.SelectedPath
            Dim di As New IO.DirectoryInfo(folderDlg.SelectedPath)
            Dim myFileInfoArr As IO.FileInfo() = di.GetFiles()
            ListBox1.DataSource = myFileInfoArr
        End If
    End Sub

    Private Sub ImportBtn_Click(sender As Object, e As EventArgs) Handles ImportBtn.Click
        If filepathLbl.Text.Equals("filepathLbl") Then
            Return
        End If
        Dim Fldr() As String = IO.Directory.GetFiles(filepathLbl.Text & "\")
        Dim file As String
        Dim accessConn As OleDb.OleDbConnection = New OleDb.OleDbConnection With {
            .ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\keshav\Desktop\database\Database.mdb"
        }
        Try
            For Each file In Fldr
                accessConn.Open()
                Dim excelApp As New Excel.Application
                Dim excelWorkbooks = excelApp.Workbooks.Open(file)
                For Each xlWorkSheet In excelApp.Sheets
                    Try
                        Dim sheet As Excel.Worksheet = excelApp.Sheets(xlWorkSheet.Name)
                        Dim rowCount As Integer = sheet.UsedRange.Rows.Count
                        Dim columnCount As Integer = sheet.UsedRange.Columns.Count
                        Dim value_range As Excel.Range = sheet.UsedRange()
                        Dim array As Object = value_range.Value2
                        If array Is Nothing Then
                            Console.Out.WriteLine("Nothing in sheet " + xlWorkSheet.Name + " FileName: " + file)
                        Else
                            Dim headers As String = ""
                            Dim rowValues(rowCount, columnCount + 1) As String
                            Dim insertQuery As String = "insert into data("
                            For row = 1 To rowCount
                                Dim insertValues As String = " values("
                                For column = 1 To columnCount
                                    Dim seperator = ","
                                    If columnCount.Equals(column) Then
                                        seperator = ")"
                                    End If
                                    If row.Equals(1) Then
                                        headers += "[" + array(row, column) + "]" + seperator
                                    Else
                                        If array(row, column) IsNot Nothing Then
                                            insertValues += "'" + array(row, column).ToString + "'" + seperator
                                        End If
                                    End If
                                Next
                                If insertValues.Equals(" values(") Then
                                    Continue For
                                End If

                                Dim cmdStr As String = insertQuery + headers + insertValues
                                Using comd As New OleDb.OleDbCommand(cmdStr, accessConn)
                                    comd.ExecuteNonQuery()
                                End Using
                            Next
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.Message + xlWorkSheet.Name + file)
                        Console.Out.WriteLine(ex.StackTrace)
                    End Try
                Next
                accessConn.Close()
                excelApp.Workbooks.Close()
                excelApp = Nothing
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Console.Out.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Private Sub ViewDataBtn_Click(sender As Object, e As EventArgs) Handles ViewDataBtn.Click
        Me.DataTableAdapter.Fill(Me.DatabaseDataSet.data)
    End Sub
End Class