<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtParticipants = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "# of &entrants:"
        '
        'txtParticipants
        '
        Me.txtParticipants.Location = New System.Drawing.Point(12, 25)
        Me.txtParticipants.Name = "txtParticipants"
        Me.txtParticipants.Size = New System.Drawing.Size(100, 20)
        Me.txtParticipants.TabIndex = 1
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(12, 84)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.Text = " "
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 111)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(100, 23)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 138)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Amount Owed:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(124, 173)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtParticipants)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "Seminar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtParticipants As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label3 As Label
End Class
