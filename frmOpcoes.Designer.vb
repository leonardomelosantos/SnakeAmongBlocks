<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmOpcoes
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public cmmCorColor As System.Windows.Forms.ColorDialog
	Public WithEvents cmdCancelar As System.Windows.Forms.Button
	Public WithEvents cmdOk As System.Windows.Forms.Button
	Public WithEvents picCorObstaculos As System.Windows.Forms.PictureBox
	Public WithEvents picCorObjetivo As System.Windows.Forms.PictureBox
	Public WithEvents picCorCobra As System.Windows.Forms.PictureBox
	Public WithEvents txtVelocidadeASerAumentada As System.Windows.Forms.TextBox
	Public WithEvents txtObstaculosASeremSomados As System.Windows.Forms.TextBox
	Public WithEvents txtVelocidadeInicial As System.Windows.Forms.TextBox
	Public WithEvents txtChances As System.Windows.Forms.TextBox
	Public WithEvents txtPontosASeremSomados As System.Windows.Forms.TextBox
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpcoes))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.picCorObstaculos = New System.Windows.Forms.PictureBox
        Me.picCorObjetivo = New System.Windows.Forms.PictureBox
        Me.picCorCobra = New System.Windows.Forms.PictureBox
        Me.cmmCorColor = New System.Windows.Forms.ColorDialog
        Me.cmdCancelar = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.txtVelocidadeASerAumentada = New System.Windows.Forms.TextBox
        Me.txtObstaculosASeremSomados = New System.Windows.Forms.TextBox
        Me.txtVelocidadeInicial = New System.Windows.Forms.TextBox
        Me.txtChances = New System.Windows.Forms.TextBox
        Me.txtPontosASeremSomados = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        CType(Me.picCorObstaculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCorObjetivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCorCobra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'picCorObstaculos
        '
        Me.picCorObstaculos.BackColor = System.Drawing.Color.Black
        Me.picCorObstaculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCorObstaculos.Cursor = System.Windows.Forms.Cursors.Default
        Me.picCorObstaculos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picCorObstaculos.Location = New System.Drawing.Point(184, 166)
        Me.picCorObstaculos.Name = "picCorObstaculos"
        Me.picCorObstaculos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picCorObstaculos.Size = New System.Drawing.Size(24, 24)
        Me.picCorObstaculos.TabIndex = 20
        Me.picCorObstaculos.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picCorObstaculos, "Clique aqui para modificar a cor dos obstáculos")
        '
        'picCorObjetivo
        '
        Me.picCorObjetivo.BackColor = System.Drawing.Color.Red
        Me.picCorObjetivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCorObjetivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.picCorObjetivo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picCorObjetivo.Location = New System.Drawing.Point(128, 166)
        Me.picCorObjetivo.Name = "picCorObjetivo"
        Me.picCorObjetivo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picCorObjetivo.Size = New System.Drawing.Size(24, 24)
        Me.picCorObjetivo.TabIndex = 19
        Me.picCorObjetivo.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picCorObjetivo, "Clique aqui para modificar a cor do objetivo da serpente")
        '
        'picCorCobra
        '
        Me.picCorCobra.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.picCorCobra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picCorCobra.Cursor = System.Windows.Forms.Cursors.Default
        Me.picCorCobra.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picCorCobra.Location = New System.Drawing.Point(70, 166)
        Me.picCorCobra.Name = "picCorCobra"
        Me.picCorCobra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picCorCobra.Size = New System.Drawing.Size(24, 24)
        Me.picCorCobra.TabIndex = 18
        Me.picCorCobra.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picCorCobra, "Clique aqui para modificar a cor da serpente")
        '
        'cmdCancelar
        '
        Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancelar.Location = New System.Drawing.Point(202, 245)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 25)
        Me.cmdCancelar.TabIndex = 6
        Me.cmdCancelar.Text = "&Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOk.Location = New System.Drawing.Point(113, 244)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOk.Size = New System.Drawing.Size(75, 25)
        Me.cmdOk.TabIndex = 5
        Me.cmdOk.Text = "&OK"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.Label14)
        Me.Frame2.Controls.Add(Me.Label13)
        Me.Frame2.Controls.Add(Me.Label12)
        Me.Frame2.Controls.Add(Me.Label11)
        Me.Frame2.Controls.Add(Me.Label10)
        Me.Frame2.Controls.Add(Me.picCorObstaculos)
        Me.Frame2.Controls.Add(Me.picCorObjetivo)
        Me.Frame2.Controls.Add(Me.picCorCobra)
        Me.Frame2.Controls.Add(Me.txtVelocidadeASerAumentada)
        Me.Frame2.Controls.Add(Me.txtObstaculosASeremSomados)
        Me.Frame2.Controls.Add(Me.txtVelocidadeInicial)
        Me.Frame2.Controls.Add(Me.txtChances)
        Me.Frame2.Controls.Add(Me.txtPontosASeremSomados)
        Me.Frame2.Controls.Add(Me.Label9)
        Me.Frame2.Controls.Add(Me.Label8)
        Me.Frame2.Controls.Add(Me.Label7)
        Me.Frame2.Controls.Add(Me.Label6)
        Me.Frame2.Controls.Add(Me.Label5)
        Me.Frame2.Controls.Add(Me.Label4)
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(12, 12)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(357, 226)
        Me.Frame2.TabIndex = 1
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Opções"
        '
        'txtVelocidadeASerAumentada
        '
        Me.txtVelocidadeASerAumentada.AcceptsReturn = True
        Me.txtVelocidadeASerAumentada.BackColor = System.Drawing.SystemColors.Window
        Me.txtVelocidadeASerAumentada.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVelocidadeASerAumentada.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVelocidadeASerAumentada.Location = New System.Drawing.Point(251, 49)
        Me.txtVelocidadeASerAumentada.MaxLength = 0
        Me.txtVelocidadeASerAumentada.Name = "txtVelocidadeASerAumentada"
        Me.txtVelocidadeASerAumentada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVelocidadeASerAumentada.Size = New System.Drawing.Size(39, 20)
        Me.txtVelocidadeASerAumentada.TabIndex = 1
        Me.txtVelocidadeASerAumentada.Text = "6"
        '
        'txtObstaculosASeremSomados
        '
        Me.txtObstaculosASeremSomados.AcceptsReturn = True
        Me.txtObstaculosASeremSomados.BackColor = System.Drawing.SystemColors.Window
        Me.txtObstaculosASeremSomados.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtObstaculosASeremSomados.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtObstaculosASeremSomados.Location = New System.Drawing.Point(251, 75)
        Me.txtObstaculosASeremSomados.MaxLength = 0
        Me.txtObstaculosASeremSomados.Name = "txtObstaculosASeremSomados"
        Me.txtObstaculosASeremSomados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtObstaculosASeremSomados.Size = New System.Drawing.Size(39, 20)
        Me.txtObstaculosASeremSomados.TabIndex = 2
        Me.txtObstaculosASeremSomados.Text = "5"
        '
        'txtVelocidadeInicial
        '
        Me.txtVelocidadeInicial.AcceptsReturn = True
        Me.txtVelocidadeInicial.BackColor = System.Drawing.SystemColors.Window
        Me.txtVelocidadeInicial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVelocidadeInicial.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVelocidadeInicial.Location = New System.Drawing.Point(251, 21)
        Me.txtVelocidadeInicial.MaxLength = 0
        Me.txtVelocidadeInicial.Name = "txtVelocidadeInicial"
        Me.txtVelocidadeInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVelocidadeInicial.Size = New System.Drawing.Size(39, 20)
        Me.txtVelocidadeInicial.TabIndex = 0
        Me.txtVelocidadeInicial.Text = "200"
        '
        'txtChances
        '
        Me.txtChances.AcceptsReturn = True
        Me.txtChances.BackColor = System.Drawing.SystemColors.Window
        Me.txtChances.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChances.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtChances.Location = New System.Drawing.Point(251, 131)
        Me.txtChances.MaxLength = 0
        Me.txtChances.Name = "txtChances"
        Me.txtChances.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtChances.Size = New System.Drawing.Size(39, 20)
        Me.txtChances.TabIndex = 4
        Me.txtChances.Text = "5"
        '
        'txtPontosASeremSomados
        '
        Me.txtPontosASeremSomados.AcceptsReturn = True
        Me.txtPontosASeremSomados.BackColor = System.Drawing.SystemColors.Window
        Me.txtPontosASeremSomados.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPontosASeremSomados.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPontosASeremSomados.Location = New System.Drawing.Point(251, 103)
        Me.txtPontosASeremSomados.MaxLength = 0
        Me.txtPontosASeremSomados.Name = "txtPontosASeremSomados"
        Me.txtPontosASeremSomados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPontosASeremSomados.Size = New System.Drawing.Size(39, 20)
        Me.txtPontosASeremSomados.TabIndex = 3
        Me.txtPontosASeremSomados.Text = "5"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(119, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Objetivo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(56, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Serpente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(168, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Obstáculos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(12, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Cores:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(12, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(106, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Número de chances:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(12, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(128, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Pontos a serem somados:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(164, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Obstáculos a serem aumentados:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(214, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Velocidade a ser aumentada: (milisegundos)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(161, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Velocidade inicial: (milisegundos)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(293, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "(50 a 1000)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(293, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "(0 a 100)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(293, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "(5 a 15)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(293, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "(5 a 500)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(293, 134)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "(1 a 50)"
        '
        'frmOpcoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(386, 282)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.Frame2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOpcoes"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Snake among blocks - Configurações"
        CType(Me.picCorObstaculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCorObjetivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCorCobra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
#End Region 
End Class