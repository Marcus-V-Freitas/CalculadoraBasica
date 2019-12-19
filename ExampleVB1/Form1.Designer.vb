<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnMul = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExp = New System.Windows.Forms.Button()
        Me.btnFac = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(379, 73)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(84, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Adição"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Entre com o 1 Numero"
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(66, 120)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber1.TabIndex = 2
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(66, 217)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Entre com o 2 Numero"
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(379, 214)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(84, 23)
        Me.btnDiv.TabIndex = 5
        Me.btnDiv.Text = "Divisão"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnMul
        '
        Me.btnMul.Location = New System.Drawing.Point(379, 167)
        Me.btnMul.Name = "btnMul"
        Me.btnMul.Size = New System.Drawing.Size(84, 23)
        Me.btnMul.TabIndex = 6
        Me.btnMul.Text = "Multiplicação"
        Me.btnMul.UseVisualStyleBackColor = True
        '
        'btnSub
        '
        Me.btnSub.Location = New System.Drawing.Point(379, 120)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(84, 23)
        Me.btnSub.TabIndex = 7
        Me.btnSub.Text = "Subtração"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(66, 308)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(100, 20)
        Me.txtResult.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Resultado"
        '
        'btnExp
        '
        Me.btnExp.Location = New System.Drawing.Point(379, 270)
        Me.btnExp.Name = "btnExp"
        Me.btnExp.Size = New System.Drawing.Size(84, 23)
        Me.btnExp.TabIndex = 10
        Me.btnExp.Text = "Exponencial"
        Me.btnExp.UseVisualStyleBackColor = True
        '
        'btnFac
        '
        Me.btnFac.Location = New System.Drawing.Point(379, 324)
        Me.btnFac.Name = "btnFac"
        Me.btnFac.Size = New System.Drawing.Size(84, 23)
        Me.btnFac.TabIndex = 11
        Me.btnFac.Text = "Fatorial"
        Me.btnFac.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 425)
        Me.Controls.Add(Me.btnFac)
        Me.Controls.Add(Me.btnExp)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btnMul)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumber1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumber1 As TextBox
    Friend WithEvents txtNumber2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnMul As Button
    Friend WithEvents btnSub As Button
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExp As Button
    Friend WithEvents btnFac As Button
End Class
