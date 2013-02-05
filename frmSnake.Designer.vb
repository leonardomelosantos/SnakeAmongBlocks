<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSnake
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
	Public WithEvents tmrSnake As System.Windows.Forms.Timer
	Public WithEvents _shpQuadro_0 As System.Windows.Forms.Label
	Public WithEvents lblFim As System.Windows.Forms.Label
	Public WithEvents _shpObst_0 As System.Windows.Forms.Label
	Public WithEvents _shpObjetivo_0 As System.Windows.Forms.Label
	Public WithEvents Area As System.Windows.Forms.Panel
	Public WithEvents _stsBarra_Panel1 As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents stsBarra As System.Windows.Forms.StatusStrip
	Public WithEvents lblChances As System.Windows.Forms.Label
	Public WithEvents lblPontos As System.Windows.Forms.Label
	Public WithEvents shpObjetivo As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents shpObst As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents shpQuadro As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSnake))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrSnake = New System.Windows.Forms.Timer(Me.components)
        Me.Area = New System.Windows.Forms.Panel
        Me._shpQuadro_0 = New System.Windows.Forms.Label
        Me.lblFim = New System.Windows.Forms.Label
        Me._shpObst_0 = New System.Windows.Forms.Label
        Me._shpObjetivo_0 = New System.Windows.Forms.Label
        Me.stsBarra = New System.Windows.Forms.StatusStrip
        Me._stsBarra_Panel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblChances = New System.Windows.Forms.Label
        Me.lblPontos = New System.Windows.Forms.Label
        Me.shpObjetivo = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.shpObst = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.shpQuadro = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Area.SuspendLayout()
        Me.stsBarra.SuspendLayout()
        CType(Me.shpObjetivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shpObst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shpQuadro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrSnake
        '
        Me.tmrSnake.Enabled = True
        Me.tmrSnake.Interval = 200
        '
        'Area
        '
        Me.Area.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Area.Controls.Add(Me._shpQuadro_0)
        Me.Area.Controls.Add(Me.lblFim)
        Me.Area.Controls.Add(Me._shpObst_0)
        Me.Area.Controls.Add(Me._shpObjetivo_0)
        Me.Area.Cursor = System.Windows.Forms.Cursors.Default
        Me.Area.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Area.Location = New System.Drawing.Point(2, 42)
        Me.Area.Name = "Area"
        Me.Area.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Area.Size = New System.Drawing.Size(400, 400)
        Me.Area.TabIndex = 0
        Me.Area.TabStop = True
        '
        '_shpQuadro_0
        '
        Me._shpQuadro_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.shpQuadro.SetIndex(Me._shpQuadro_0, CType(0, Short))
        Me._shpQuadro_0.Location = New System.Drawing.Point(59, 24)
        Me._shpQuadro_0.Name = "_shpQuadro_0"
        Me._shpQuadro_0.Size = New System.Drawing.Size(10, 10)
        Me._shpQuadro_0.TabIndex = 0
        '
        'lblFim
        '
        Me.lblFim.BackColor = System.Drawing.Color.Transparent
        Me.lblFim.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFim.Font = New System.Drawing.Font("Arial Black", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFim.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFim.Location = New System.Drawing.Point(44, 114)
        Me.lblFim.Name = "lblFim"
        Me.lblFim.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFim.Size = New System.Drawing.Size(315, 194)
        Me.lblFim.TabIndex = 3
        Me.lblFim.Text = "Fim de jogo"
        Me.lblFim.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblFim.Visible = False
        '
        '_shpObst_0
        '
        Me._shpObst_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.shpObst.SetIndex(Me._shpObst_0, CType(0, Short))
        Me._shpObst_0.Location = New System.Drawing.Point(20, 24)
        Me._shpObst_0.Name = "_shpObst_0"
        Me._shpObst_0.Size = New System.Drawing.Size(10, 10)
        Me._shpObst_0.TabIndex = 4
        '
        '_shpObjetivo_0
        '
        Me._shpObjetivo_0.BackColor = System.Drawing.Color.Red
        Me.shpObjetivo.SetIndex(Me._shpObjetivo_0, CType(0, Short))
        Me._shpObjetivo_0.Location = New System.Drawing.Point(98, 24)
        Me._shpObjetivo_0.Name = "_shpObjetivo_0"
        Me._shpObjetivo_0.Size = New System.Drawing.Size(10, 10)
        Me._shpObjetivo_0.TabIndex = 5
        '
        'stsBarra
        '
        Me.stsBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._stsBarra_Panel1})
        Me.stsBarra.Location = New System.Drawing.Point(0, 443)
        Me.stsBarra.Name = "stsBarra"
        Me.stsBarra.Size = New System.Drawing.Size(404, 23)
        Me.stsBarra.TabIndex = 4
        '
        '_stsBarra_Panel1
        '
        Me._stsBarra_Panel1.AutoSize = False
        Me._stsBarra_Panel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me._stsBarra_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust
        Me._stsBarra_Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me._stsBarra_Panel1.Name = "_stsBarra_Panel1"
        Me._stsBarra_Panel1.Size = New System.Drawing.Size(350, 23)
        Me._stsBarra_Panel1.Text = "Leonardo Melo Santos (http://www.leonardomelosantos.com.br)"
        Me._stsBarra_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblChances
        '
        Me.lblChances.AutoSize = True
        Me.lblChances.BackColor = System.Drawing.SystemColors.Control
        Me.lblChances.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblChances.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChances.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblChances.Location = New System.Drawing.Point(12, 9)
        Me.lblChances.Name = "lblChances"
        Me.lblChances.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChances.Size = New System.Drawing.Size(99, 24)
        Me.lblChances.TabIndex = 2
        Me.lblChances.Text = "Chance(s):"
        '
        'lblPontos
        '
        Me.lblPontos.AutoSize = True
        Me.lblPontos.BackColor = System.Drawing.SystemColors.Control
        Me.lblPontos.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPontos.Font = New System.Drawing.Font("Trebuchet MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPontos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPontos.Location = New System.Drawing.Point(309, 9)
        Me.lblPontos.Name = "lblPontos"
        Me.lblPontos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPontos.Size = New System.Drawing.Size(83, 24)
        Me.lblPontos.TabIndex = 1
        Me.lblPontos.Text = "0 Pontos"
        Me.lblPontos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmSnake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(404, 466)
        Me.Controls.Add(Me.Area)
        Me.Controls.Add(Me.stsBarra)
        Me.Controls.Add(Me.lblChances)
        Me.Controls.Add(Me.lblPontos)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSnake"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Snake among blocks 2.0"
        Me.Area.ResumeLayout(False)
        Me.stsBarra.ResumeLayout(False)
        Me.stsBarra.PerformLayout()
        CType(Me.shpObjetivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shpObst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shpQuadro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class