<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.goButton = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.dbFile = New System.Windows.Forms.TextBox
        Me.output = New System.Windows.Forms.TextBox
        Me.dbPw = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.sqlFile = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'goButton
        '
        Me.goButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.goButton.Location = New System.Drawing.Point(149, 84)
        Me.goButton.Name = "goButton"
        Me.goButton.Size = New System.Drawing.Size(100, 23)
        Me.goButton.TabIndex = 5
        Me.goButton.Text = "Go!"
        Me.goButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Access database filename"
        '
        'dbFile
        '
        Me.dbFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbFile.Location = New System.Drawing.Point(149, 6)
        Me.dbFile.Name = "dbFile"
        Me.dbFile.Size = New System.Drawing.Size(100, 20)
        Me.dbFile.TabIndex = 2
        '
        'output
        '
        Me.output.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.output.Location = New System.Drawing.Point(9, 114)
        Me.output.Multiline = True
        Me.output.Name = "output"
        Me.output.ReadOnly = True
        Me.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.output.Size = New System.Drawing.Size(240, 155)
        Me.output.TabIndex = 0
        '
        'dbPw
        '
        Me.dbPw.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbPw.Location = New System.Drawing.Point(149, 32)
        Me.dbPw.Name = "dbPw"
        Me.dbPw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.dbPw.Size = New System.Drawing.Size(100, 20)
        Me.dbPw.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Access database password"
        '
        'sqlFile
        '
        Me.sqlFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sqlFile.Location = New System.Drawing.Point(149, 58)
        Me.sqlFile.Name = "sqlFile"
        Me.sqlFile.Size = New System.Drawing.Size(100, 20)
        Me.sqlFile.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "SQL filename"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(9, 275)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(240, 23)
        Me.ProgressBar1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 310)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.sqlFile)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dbPw)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.dbFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.goButton)
        Me.Name = "Form1"
        Me.Text = "SQL -> Access"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents goButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dbFile As System.Windows.Forms.TextBox
    Friend WithEvents output As System.Windows.Forms.TextBox
    Friend WithEvents dbPw As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents sqlFile As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar

End Class
