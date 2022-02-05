<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblPrincipal = New System.Windows.Forms.Label()
        Me.BtnAcao = New System.Windows.Forms.Button()
        Me.LblSaldo = New System.Windows.Forms.Label()
        Me.LblIncremento = New System.Windows.Forms.Label()
        Me.TxbSaldo = New System.Windows.Forms.TextBox()
        Me.TxbIncremento = New System.Windows.Forms.TextBox()
        Me.BtnAcao2 = New System.Windows.Forms.Button()
        Me.BtnValRef = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblPrincipal
        '
        Me.LblPrincipal.AutoSize = True
        Me.LblPrincipal.Location = New System.Drawing.Point(13, 13)
        Me.LblPrincipal.Name = "LblPrincipal"
        Me.LblPrincipal.Size = New System.Drawing.Size(39, 13)
        Me.LblPrincipal.TabIndex = 0
        Me.LblPrincipal.Text = "Label1"
        '
        'BtnAcao
        '
        Me.BtnAcao.Location = New System.Drawing.Point(12, 29)
        Me.BtnAcao.Name = "BtnAcao"
        Me.BtnAcao.Size = New System.Drawing.Size(143, 29)
        Me.BtnAcao.TabIndex = 1
        Me.BtnAcao.Text = "Button1"
        Me.BtnAcao.UseVisualStyleBackColor = True
        '
        'LblSaldo
        '
        Me.LblSaldo.AutoSize = True
        Me.LblSaldo.Location = New System.Drawing.Point(12, 65)
        Me.LblSaldo.Name = "LblSaldo"
        Me.LblSaldo.Size = New System.Drawing.Size(34, 13)
        Me.LblSaldo.TabIndex = 2
        Me.LblSaldo.Text = "Saldo"
        '
        'LblIncremento
        '
        Me.LblIncremento.AutoSize = True
        Me.LblIncremento.Location = New System.Drawing.Point(135, 65)
        Me.LblIncremento.Name = "LblIncremento"
        Me.LblIncremento.Size = New System.Drawing.Size(60, 13)
        Me.LblIncremento.TabIndex = 3
        Me.LblIncremento.Text = "Incremento"
        '
        'TxbSaldo
        '
        Me.TxbSaldo.Location = New System.Drawing.Point(12, 82)
        Me.TxbSaldo.Name = "TxbSaldo"
        Me.TxbSaldo.Size = New System.Drawing.Size(100, 20)
        Me.TxbSaldo.TabIndex = 4
        '
        'TxbIncremento
        '
        Me.TxbIncremento.Location = New System.Drawing.Point(138, 82)
        Me.TxbIncremento.Name = "TxbIncremento"
        Me.TxbIncremento.Size = New System.Drawing.Size(100, 20)
        Me.TxbIncremento.TabIndex = 5
        '
        'BtnAcao2
        '
        Me.BtnAcao2.Location = New System.Drawing.Point(12, 122)
        Me.BtnAcao2.Name = "BtnAcao2"
        Me.BtnAcao2.Size = New System.Drawing.Size(143, 29)
        Me.BtnAcao2.TabIndex = 6
        Me.BtnAcao2.Text = "Button1"
        Me.BtnAcao2.UseVisualStyleBackColor = True
        '
        'BtnValRef
        '
        Me.BtnValRef.Location = New System.Drawing.Point(12, 180)
        Me.BtnValRef.Name = "BtnValRef"
        Me.BtnValRef.Size = New System.Drawing.Size(143, 29)
        Me.BtnValRef.TabIndex = 7
        Me.BtnValRef.Text = "Button1"
        Me.BtnValRef.UseVisualStyleBackColor = True
        '
        'FrmPrincipal1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 327)
        Me.Controls.Add(Me.BtnValRef)
        Me.Controls.Add(Me.BtnAcao2)
        Me.Controls.Add(Me.TxbIncremento)
        Me.Controls.Add(Me.TxbSaldo)
        Me.Controls.Add(Me.LblIncremento)
        Me.Controls.Add(Me.LblSaldo)
        Me.Controls.Add(Me.BtnAcao)
        Me.Controls.Add(Me.LblPrincipal)
        Me.Name = "FrmPrincipal1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblPrincipal As Label
    Friend WithEvents BtnAcao As Button
    Friend WithEvents LblSaldo As Label
    Friend WithEvents LblIncremento As Label
    Friend WithEvents TxbSaldo As TextBox
    Friend WithEvents TxbIncremento As TextBox
    Friend WithEvents BtnAcao2 As Button
    Friend WithEvents BtnValRef As Button
End Class
