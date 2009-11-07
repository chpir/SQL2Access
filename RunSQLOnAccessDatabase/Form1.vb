Imports System.Data.OleDb

Public Class Form1

    Private Sub goButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles goButton.Click
        If System.IO.File.Exists(sqlFile.Text) = True Then
            goButton.Enabled = False
            goButton.Text = "Running..."
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = countLines(sqlFile.Text)
            ProgressBar1.Value = 0

            uO(ProgressBar1.Maximum.ToString + " total queries to run...")

            Dim objReader As New System.IO.StreamReader(sqlFile.Text)
            Do While objReader.Peek() <> -1
                Dim txt As String = objReader.ReadLine()
                runSql(dbFile.Text, dbPw.Text, txt)
                If (ProgressBar1.Value Mod 10) = 0 Then
                    uO(ProgressBar1.Value.ToString + " queries ran...")
                End If
                ProgressBar1.Value = ProgressBar1.Value + 1
            Loop
            goButton.Enabled = True
            goButton.Text = "Go!"
        Else
            MsgBox("SQL file does not exist")
        End If
    End Sub


    Public Function runSql(ByVal db As String, ByVal pw As String, ByVal sql As String) As Boolean
        Dim oConnect As String
        Dim ret As Boolean = True
        oConnect = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & db & ";Jet OLEDB:database Password=" + pw

        Dim conn As New OleDbConnection(oConnect)
        Dim cmd1 As New OleDbCommand()

        Try
            Dim query As String = sql
            conn.Open()
            cmd1.Connection = conn
            cmd1.CommandText = query
            cmd1.ExecuteNonQuery()
            conn.Close()
        Catch ex As OleDb.OleDbException
            uO(ex.Message & vbCrLf & ex.StackTrace)
            ret = False
        Catch ex As Exception
            uO(ex.Message & vbCrLf & ex.StackTrace)
            ret = False
        Finally
            'Dispose the connector objects
            If Not (conn Is Nothing) Then conn.Dispose()
            conn = Nothing
        End Try

        Return ret
    End Function


    Public Function uO(ByVal msg As String) As Boolean
        output.AppendText(msg + vbCrLf)
    End Function


    Public Shared Function countLines(ByVal filename As String) As Integer
        Dim fs As IO.FileStream
        Dim sr As IO.StreamReader
        Dim Result As Integer

        fs = New IO.FileStream( _
        filename, IO.FileMode.Open, _
        IO.FileAccess.Read, IO.FileShare.Read _
        )

        sr = New IO.StreamReader(fs)

        Do
            If sr.ReadLine Is Nothing Then Exit Do
            Result += 1
        Loop

        Return Result
    End Function
End Class
