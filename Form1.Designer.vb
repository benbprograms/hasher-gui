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
        Me.hash = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.input = New System.Windows.Forms.TextBox()
        Me.output = New System.Windows.Forms.Label()
        Me.wait = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'hash
        '
        Me.hash.Location = New System.Drawing.Point(216, 89)
        Me.hash.Name = "hash"
        Me.hash.Size = New System.Drawing.Size(56, 53)
        Me.hash.TabIndex = 0
        Me.hash.Text = "hash"
        Me.hash.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "input"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "output"
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(59, 39)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(213, 20)
        Me.input.TabIndex = 3
        '
        'output
        '
        Me.output.AutoSize = True
        Me.output.Location = New System.Drawing.Point(58, 66)
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(0, 13)
        Me.output.TabIndex = 4
        '
        'wait
        '
        Me.wait.Location = New System.Drawing.Point(16, 148)
        Me.wait.Name = "wait"
        Me.wait.Size = New System.Drawing.Size(256, 19)
        Me.wait.TabIndex = 5
        Me.wait.UseWaitCursor = True
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 179)
        Me.Controls.Add(Me.wait)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hash)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hash As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents input As System.Windows.Forms.TextBox
    Friend WithEvents output As System.Windows.Forms.Label
    Friend WithEvents wait As System.Windows.Forms.ProgressBar

End Class
