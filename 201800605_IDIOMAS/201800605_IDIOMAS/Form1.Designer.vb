<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.BCALCULAR = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TexNOMBRE = New System.Windows.Forms.TextBox()
        Me.TexCARNE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RadioButtonPORTUGUES = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFRANCES = New System.Windows.Forms.RadioButton()
        Me.RadioINGLES = New System.Windows.Forms.RadioButton()
        Me.TextBoxHORAS = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonCHEQUE = New System.Windows.Forms.RadioButton()
        Me.RadioButtonEFECTIVO = New System.Windows.Forms.RadioButton()
        Me.DataCALCULAR = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonSALIR = New System.Windows.Forms.Button()
        Me.RadioAMBOS = New System.Windows.Forms.RadioButton()
        Me.RadioSABADO = New System.Windows.Forms.RadioButton()
        Me.RadioVIERNES = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataCALCULAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTP1
        '
        Me.DTP1.Location = New System.Drawing.Point(0, 100)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(200, 20)
        Me.DTP1.TabIndex = 0
        '
        'BCALCULAR
        '
        Me.BCALCULAR.Location = New System.Drawing.Point(598, 154)
        Me.BCALCULAR.Name = "BCALCULAR"
        Me.BCALCULAR.Size = New System.Drawing.Size(75, 23)
        Me.BCALCULAR.TabIndex = 1
        Me.BCALCULAR.Text = "CALCULAR"
        Me.BCALCULAR.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TexNOMBRE)
        Me.GroupBox1.Controls.Add(Me.TexCARNE)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 111)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL ESTUDIANTE"
        '
        'TexNOMBRE
        '
        Me.TexNOMBRE.Location = New System.Drawing.Point(9, 77)
        Me.TexNOMBRE.Name = "TexNOMBRE"
        Me.TexNOMBRE.Size = New System.Drawing.Size(239, 20)
        Me.TexNOMBRE.TabIndex = 3
        '
        'TexCARNE
        '
        Me.TexCARNE.Location = New System.Drawing.Point(56, 30)
        Me.TexCARNE.Name = "TexCARNE"
        Me.TexCARNE.Size = New System.Drawing.Size(100, 20)
        Me.TexCARNE.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRE DEL ESTUDIANTE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CARNE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.RadioButtonPORTUGUES)
        Me.GroupBox2.Controls.Add(Me.RadioButtonFRANCES)
        Me.GroupBox2.Controls.Add(Me.RadioINGLES)
        Me.GroupBox2.Controls.Add(Me.TextBoxHORAS)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.DTP1)
        Me.GroupBox2.Location = New System.Drawing.Point(282, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 188)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CURSOS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(279, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Label7"
        '
        'RadioButtonPORTUGUES
        '
        Me.RadioButtonPORTUGUES.AutoSize = True
        Me.RadioButtonPORTUGUES.Location = New System.Drawing.Point(160, 43)
        Me.RadioButtonPORTUGUES.Name = "RadioButtonPORTUGUES"
        Me.RadioButtonPORTUGUES.Size = New System.Drawing.Size(93, 17)
        Me.RadioButtonPORTUGUES.TabIndex = 9
        Me.RadioButtonPORTUGUES.TabStop = True
        Me.RadioButtonPORTUGUES.Text = "PORTUGUES"
        Me.RadioButtonPORTUGUES.UseVisualStyleBackColor = True
        '
        'RadioButtonFRANCES
        '
        Me.RadioButtonFRANCES.AutoSize = True
        Me.RadioButtonFRANCES.Location = New System.Drawing.Point(79, 42)
        Me.RadioButtonFRANCES.Name = "RadioButtonFRANCES"
        Me.RadioButtonFRANCES.Size = New System.Drawing.Size(75, 17)
        Me.RadioButtonFRANCES.TabIndex = 8
        Me.RadioButtonFRANCES.TabStop = True
        Me.RadioButtonFRANCES.Text = "FRANCES"
        Me.RadioButtonFRANCES.UseVisualStyleBackColor = True
        '
        'RadioINGLES
        '
        Me.RadioINGLES.AutoSize = True
        Me.RadioINGLES.Location = New System.Drawing.Point(9, 43)
        Me.RadioINGLES.Name = "RadioINGLES"
        Me.RadioINGLES.Size = New System.Drawing.Size(64, 17)
        Me.RadioINGLES.TabIndex = 7
        Me.RadioINGLES.TabStop = True
        Me.RadioINGLES.Text = "INGLES"
        Me.RadioINGLES.UseVisualStyleBackColor = True
        '
        'TextBoxHORAS
        '
        Me.TextBoxHORAS.Location = New System.Drawing.Point(182, 152)
        Me.TextBoxHORAS.Name = "TextBoxHORAS"
        Me.TextBoxHORAS.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHORAS.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(179, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "HORAS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DIAS "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "FECHA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "IDIOMA"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButtonCHEQUE)
        Me.GroupBox3.Controls.Add(Me.RadioButtonEFECTIVO)
        Me.GroupBox3.Location = New System.Drawing.Point(598, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(113, 136)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "METODO DE PAGO"
        '
        'RadioButtonCHEQUE
        '
        Me.RadioButtonCHEQUE.AutoSize = True
        Me.RadioButtonCHEQUE.Location = New System.Drawing.Point(7, 66)
        Me.RadioButtonCHEQUE.Name = "RadioButtonCHEQUE"
        Me.RadioButtonCHEQUE.Size = New System.Drawing.Size(70, 17)
        Me.RadioButtonCHEQUE.TabIndex = 1
        Me.RadioButtonCHEQUE.TabStop = True
        Me.RadioButtonCHEQUE.Text = "CHEQUE"
        Me.RadioButtonCHEQUE.UseVisualStyleBackColor = True
        '
        'RadioButtonEFECTIVO
        '
        Me.RadioButtonEFECTIVO.AutoSize = True
        Me.RadioButtonEFECTIVO.Location = New System.Drawing.Point(7, 42)
        Me.RadioButtonEFECTIVO.Name = "RadioButtonEFECTIVO"
        Me.RadioButtonEFECTIVO.Size = New System.Drawing.Size(77, 17)
        Me.RadioButtonEFECTIVO.TabIndex = 0
        Me.RadioButtonEFECTIVO.TabStop = True
        Me.RadioButtonEFECTIVO.Text = "EFECTIVO"
        Me.RadioButtonEFECTIVO.UseVisualStyleBackColor = True
        '
        'DataCALCULAR
        '
        Me.DataCALCULAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataCALCULAR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.DataCALCULAR.Location = New System.Drawing.Point(33, 212)
        Me.DataCALCULAR.Name = "DataCALCULAR"
        Me.DataCALCULAR.Size = New System.Drawing.Size(699, 117)
        Me.DataCALCULAR.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "REGISTRO"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "CARNE"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "NOMBRE"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "IDIOMA"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "FECHA"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "DIAS"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "HORAS"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "METODO"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "PAGO PARCIAL"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "DESCUENTO"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "DESCUENTO 2"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "TOTAL"
        Me.Column12.Name = "Column12"
        '
        'ButtonSALIR
        '
        Me.ButtonSALIR.Location = New System.Drawing.Point(598, 183)
        Me.ButtonSALIR.Name = "ButtonSALIR"
        Me.ButtonSALIR.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSALIR.TabIndex = 5
        Me.ButtonSALIR.Text = "SALIR"
        Me.ButtonSALIR.UseVisualStyleBackColor = True
        '
        'RadioAMBOS
        '
        Me.RadioAMBOS.AutoSize = True
        Me.RadioAMBOS.Location = New System.Drawing.Point(363, 167)
        Me.RadioAMBOS.Name = "RadioAMBOS"
        Me.RadioAMBOS.Size = New System.Drawing.Size(63, 17)
        Me.RadioAMBOS.TabIndex = 12
        Me.RadioAMBOS.TabStop = True
        Me.RadioAMBOS.Text = "AMBOS"
        Me.RadioAMBOS.UseVisualStyleBackColor = True
        '
        'RadioSABADO
        '
        Me.RadioSABADO.AutoSize = True
        Me.RadioSABADO.Location = New System.Drawing.Point(282, 166)
        Me.RadioSABADO.Name = "RadioSABADO"
        Me.RadioSABADO.Size = New System.Drawing.Size(69, 17)
        Me.RadioSABADO.TabIndex = 11
        Me.RadioSABADO.TabStop = True
        Me.RadioSABADO.Text = "SABADO"
        Me.RadioSABADO.UseVisualStyleBackColor = True
        '
        'RadioVIERNES
        '
        Me.RadioVIERNES.AutoSize = True
        Me.RadioVIERNES.Location = New System.Drawing.Point(212, 167)
        Me.RadioVIERNES.Name = "RadioVIERNES"
        Me.RadioVIERNES.Size = New System.Drawing.Size(72, 17)
        Me.RadioVIERNES.TabIndex = 10
        Me.RadioVIERNES.TabStop = True
        Me.RadioVIERNES.Text = "VIERNES"
        Me.RadioVIERNES.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(679, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "LIMPIAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadioAMBOS)
        Me.Controls.Add(Me.ButtonSALIR)
        Me.Controls.Add(Me.RadioSABADO)
        Me.Controls.Add(Me.DataCALCULAR)
        Me.Controls.Add(Me.RadioVIERNES)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BCALCULAR)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataCALCULAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DTP1 As DateTimePicker
    Friend WithEvents BCALCULAR As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TexNOMBRE As TextBox
    Friend WithEvents TexCARNE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxHORAS As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioButtonCHEQUE As RadioButton
    Friend WithEvents RadioButtonEFECTIVO As RadioButton
    Friend WithEvents DataCALCULAR As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents ButtonSALIR As Button
    Friend WithEvents RadioButtonPORTUGUES As RadioButton
    Friend WithEvents RadioButtonFRANCES As RadioButton
    Friend WithEvents RadioINGLES As RadioButton
    Friend WithEvents RadioAMBOS As RadioButton
    Friend WithEvents RadioSABADO As RadioButton
    Friend WithEvents RadioVIERNES As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
