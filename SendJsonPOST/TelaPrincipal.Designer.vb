<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaPrincipal
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
        Me.BTSend = New System.Windows.Forms.Button()
        Me.BTReceive = New System.Windows.Forms.Button()
        Me.TBMatricula = New System.Windows.Forms.TextBox()
        Me.TBNome = New System.Windows.Forms.TextBox()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.TBSaldo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTSend
        '
        Me.BTSend.Location = New System.Drawing.Point(80, 163)
        Me.BTSend.Name = "BTSend"
        Me.BTSend.Size = New System.Drawing.Size(75, 23)
        Me.BTSend.TabIndex = 0
        Me.BTSend.Text = "Send"
        Me.BTSend.UseVisualStyleBackColor = True
        '
        'BTReceive
        '
        Me.BTReceive.Location = New System.Drawing.Point(238, 163)
        Me.BTReceive.Name = "BTReceive"
        Me.BTReceive.Size = New System.Drawing.Size(75, 23)
        Me.BTReceive.TabIndex = 1
        Me.BTReceive.Text = "Receive"
        Me.BTReceive.UseVisualStyleBackColor = True
        '
        'TBMatricula
        '
        Me.TBMatricula.Location = New System.Drawing.Point(70, 45)
        Me.TBMatricula.Name = "TBMatricula"
        Me.TBMatricula.Size = New System.Drawing.Size(100, 20)
        Me.TBMatricula.TabIndex = 2
        '
        'TBNome
        '
        Me.TBNome.Location = New System.Drawing.Point(70, 71)
        Me.TBNome.Name = "TBNome"
        Me.TBNome.Size = New System.Drawing.Size(100, 20)
        Me.TBNome.TabIndex = 3
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(70, 97)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(100, 20)
        Me.TBEmail.TabIndex = 4
        '
        'TBSaldo
        '
        Me.TBSaldo.Location = New System.Drawing.Point(70, 123)
        Me.TBSaldo.Name = "TBSaldo"
        Me.TBSaldo.Size = New System.Drawing.Size(100, 20)
        Me.TBSaldo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Matricula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Saldo"
        '
        'TelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 199)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBSaldo)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.TBNome)
        Me.Controls.Add(Me.TBMatricula)
        Me.Controls.Add(Me.BTReceive)
        Me.Controls.Add(Me.BTSend)
        Me.Name = "TelaPrincipal"
        Me.Text = "SendReceive JSON API"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTSend As Button
    Friend WithEvents BTReceive As Button
    Friend WithEvents TBMatricula As TextBox
    Friend WithEvents TBNome As TextBox
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents TBSaldo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
