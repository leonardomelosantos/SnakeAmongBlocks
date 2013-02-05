Option Strict Off
Option Explicit On
Friend Class frmOpcoes
	Inherits System.Windows.Forms.Form
	
    Private Sub cmdOk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.Click
        'Verificando se o usuário escolheu a mesma cor para mais de um objeto de tela
        If picCorCobra.BackColor = picCorObjetivo.BackColor Then
            Call MessageBox.Show("A cor da serpente e do objetivo são iguais.", "Cores dos objetos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If picCorCobra.BackColor = picCorObstaculos.BackColor Then
            Call MessageBox.Show("As cores da serpente e dos obstáculos são iguais.", "Cores dos objetos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If picCorObjetivo.BackColor = picCorObstaculos.BackColor Then
            Call MessageBox.Show("As cores do objetivo e dos obstáculos são iguais.", "Cores dos objetos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'Verificando se tem algum campo com dado inválido
        If txtChances.ForeColor = Color.Red Then
            txtChances.Focus()
            Exit Sub
        End If
        If txtObstaculosASeremSomados.ForeColor = Color.Red Then
            txtObstaculosASeremSomados.Focus()
            Exit Sub
        End If
        If txtPontosASeremSomados.ForeColor = Color.Red Then
            txtPontosASeremSomados.Focus()
            Exit Sub
        End If
        If txtVelocidadeASerAumentada.ForeColor = Color.Red Then
            txtVelocidadeASerAumentada.Focus()
            Exit Sub
        End If
        If txtVelocidadeInicial.ForeColor = Color.Red Then
            txtVelocidadeInicial.Focus()
            Exit Sub
        End If

        frmSnake.VelocidadeInicial = CShort(txtVelocidadeInicial.Text)
        frmSnake.TempoASerReduzido = CShort(txtVelocidadeASerAumentada.Text)
        frmSnake.IntObstaculosASeremSomados = CShort(txtObstaculosASeremSomados.Text)
        frmSnake.PontosASeremSomados = CShort(txtPontosASeremSomados.Text)
        frmSnake.Chances = CShort(txtChances.Text)
        frmSnake.shpQuadro(0).BackColor = picCorCobra.BackColor
        frmSnake.shpObjetivo(0).BackColor = picCorObjetivo.BackColor
        frmSnake.shpObst(0).BackColor = picCorObstaculos.BackColor
        Me.Close()
    End Sub
	
	Private Sub frmOpcoes_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        txtVelocidadeInicial.Text = CStr(250)
		txtVelocidadeASerAumentada.Text = CStr(2)
		txtObstaculosASeremSomados.Text = CStr(5)
		txtPontosASeremSomados.Text = CStr(5)
		txtChances.Text = CStr(5)
        picCorCobra.BackColor = frmSnake.shpQuadro(0).BackColor
        picCorObjetivo.BackColor = frmSnake.shpObjetivo(0).BackColor
        picCorObstaculos.BackColor = frmSnake.shpObst(0).BackColor
		
		frmSnake.VelocidadeInicial = CShort(txtVelocidadeInicial.Text)
		frmSnake.TempoASerReduzido = CShort(txtVelocidadeASerAumentada.Text)
		frmSnake.IntObstaculosASeremSomados = CShort(txtObstaculosASeremSomados.Text)
		frmSnake.PontosASeremSomados = CShort(txtPontosASeremSomados.Text)
		frmSnake.Chances = CShort(txtChances.Text)
        frmSnake.shpQuadro(0).BackColor = picCorCobra.BackColor
        frmSnake.shpObjetivo(0).BackColor = picCorObjetivo.BackColor
        frmSnake.shpObst(0).BackColor = picCorObstaculos.BackColor
    End Sub
	
	Private Sub picCorCobra_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles picCorCobra.Click
		cmmCorColor.Color = picCorCobra.BackColor
		cmmCorColor.ShowDialog()
		picCorCobra.BackColor = cmmCorColor.Color
	End Sub
	
	Private Sub picCorObjetivo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles picCorObjetivo.Click
		cmmCorColor.Color = picCorObjetivo.BackColor
		cmmCorColor.ShowDialog()
		picCorObjetivo.BackColor = cmmCorColor.Color
	End Sub
	
	Private Sub picCorObstaculos_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles picCorObstaculos.Click
		cmmCorColor.Color = picCorObstaculos.BackColor
		cmmCorColor.ShowDialog()
		picCorObstaculos.BackColor = cmmCorColor.Color
	End Sub
	
	Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
        Application.Exit()
    End Sub

    Private Sub txtVelocidadeInicial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVelocidadeInicial.TextChanged
        Dim menorIntervalo As Integer = 50
        Dim maiorIntervalo As Integer = 1000
        If Not IsNumeric(txtVelocidadeInicial.Text) Then
            txtVelocidadeInicial.ForeColor = Color.Red
        Else
            txtVelocidadeInicial.Text = Val(txtVelocidadeInicial.Text)
            If CDbl(txtVelocidadeInicial.Text) >= menorIntervalo And _
            CDbl(txtVelocidadeInicial.Text) <= maiorIntervalo Then
                txtVelocidadeInicial.ForeColor = Color.Black
            Else
                txtVelocidadeInicial.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub txtVelocidadeASerAumentada_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVelocidadeASerAumentada.TextChanged
        Dim menorIntervalo As Integer = 0
        Dim maiorIntervalo As Integer = 100
        If Not IsNumeric(txtVelocidadeASerAumentada.Text) Then
            txtVelocidadeASerAumentada.ForeColor = Color.Red
        Else
            txtVelocidadeASerAumentada.Text = Val(txtVelocidadeASerAumentada.Text)
            If CDbl(txtVelocidadeASerAumentada.Text) >= menorIntervalo And _
            CDbl(txtVelocidadeASerAumentada.Text) <= maiorIntervalo Then
                txtVelocidadeASerAumentada.ForeColor = Color.Black
            Else
                txtVelocidadeASerAumentada.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub txtObstaculosASeremSomados_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObstaculosASeremSomados.TextChanged
        Dim menorIntervalo As Integer = 5
        Dim maiorIntervalo As Integer = 15
        If Not IsNumeric(txtObstaculosASeremSomados.Text) Then
            txtObstaculosASeremSomados.ForeColor = Color.Red
        Else
            txtObstaculosASeremSomados.Text = Val(txtObstaculosASeremSomados.Text)
            If CDbl(txtObstaculosASeremSomados.Text) >= menorIntervalo And _
            CDbl(txtObstaculosASeremSomados.Text) <= maiorIntervalo Then
                txtObstaculosASeremSomados.ForeColor = Color.Black
            Else
                txtObstaculosASeremSomados.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub txtPontosASeremSomados_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPontosASeremSomados.TextChanged
        Dim menorIntervalo As Integer = 5
        Dim maiorIntervalo As Integer = 500
        If Not IsNumeric(txtPontosASeremSomados.Text) Then
            txtPontosASeremSomados.ForeColor = Color.Red
        Else
            txtPontosASeremSomados.Text = Val(txtPontosASeremSomados.Text)
            If CDbl(txtPontosASeremSomados.Text) >= menorIntervalo And _
            CDbl(txtPontosASeremSomados.Text) <= maiorIntervalo Then
                txtPontosASeremSomados.ForeColor = Color.Black
            Else
                txtPontosASeremSomados.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub txtChances_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtChances.TextChanged
        Dim menorIntervalo As Integer = 1
        Dim maiorIntervalo As Integer = 50
        If Not IsNumeric(txtChances.Text) Then
            txtChances.ForeColor = Color.Red
        Else
            txtChances.Text = Val(txtChances.Text)
            If CDbl(txtChances.Text) >= menorIntervalo And _
            CDbl(txtChances.Text) <= maiorIntervalo Then
                txtChances.ForeColor = Color.Black
            Else
                txtChances.ForeColor = Color.Red
            End If
        End If
    End Sub
End Class