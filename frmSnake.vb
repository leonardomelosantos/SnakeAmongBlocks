Option Strict Off
Option Explicit On
Friend Class frmSnake
	Inherits System.Windows.Forms.Form
	Public Fato As String
	Public vetorObstaculo As Short
	Public vetorObstaculoOculto As Short
	Public vetorTamanhoObstaculo As Short
	Public vetorExisteObstaculo As Short
	Public vetorTempoFim As Short
	Public NumeroDeObstaculos As Short
	Public VelocidadeInicial As Short
	Public Pontos As Short
	Public Chances As Short
	Public PontosASeremSomados As Short
	Public TempoASerReduzido As Short
	Public IntObstaculosASeremSomados As Short
	Public TempX As Short
	Public TempY As Short
	Public Verificacao As String
	
	Private Sub frmSnake_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'Me.Text = My.Application.Info.Title
		'UPGRADE_WARNING: Lower bound of collection stsBarra.Panels has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
        'stsBarra.Items.Item(1).Text = ".:." & Space(1) & My.Application.Info.Title & Space(1) & ".:."
		Pontos = 0
		
		VB6.ShowForm(frmOpcoes, VB6.FormShowConstants.Modal, Me)
		
		lblFim.Visible = False
		'UPGRADE_WARNING: Timer property tmrSnake.Interval cannot have a value of 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="169ECF4A-1968-402D-B243-16603CC08604"'
		tmrSnake.Interval = VelocidadeInicial
		lblPontos.Text = Pontos & " Pontos"
		lblChances.Text = "Chance(s): " & Chances
		
		Call sbDesMontaCobra()
		Call sbMontaObstaculos(True)
		Call sbReMontaObjetivo()
		
		shpQuadro(0).Width = 10
		shpQuadro(0).Height = 10
		shpQuadro(0).Left = Int(Int(Rnd() * 40) * 10)
		shpQuadro(0).Top = Int(Int(Rnd() * 40) * 10)
	End Sub
	
	Private Sub tmrSnake_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrSnake.Tick
		If Fato = "UP" Then
			If (shpQuadro(0).Top >= shpQuadro(0).Height) Then
				Verificacao = fcVerificaSeExisteObtaculo(shpQuadro(0).Left, shpQuadro(0).Top - shpQuadro(0).Width)
				If Verificacao = "O" Or Verificacao = "N" Then
					Call sbMovimenta(Fato)
					If Verificacao = "O" Then
						Call sbMontaObstaculos()
						Call sbReMontaObjetivo()
					End If
				End If
			Else
				Call sbChocou()
			End If
		ElseIf Fato = "DO" Then 
			If (shpQuadro(0).Top <= (Area.Height - (2 * shpQuadro(0).Height))) Then
				Verificacao = fcVerificaSeExisteObtaculo(shpQuadro(0).Left, shpQuadro(0).Top + shpQuadro(0).Height)
				If Verificacao = "O" Or Verificacao = "N" Then
					Call sbMovimenta(Fato)
					If Verificacao = "O" Then
						Call sbMontaObstaculos()
						Call sbReMontaObjetivo()
					End If
				End If
			Else
				Call sbChocou()
			End If
		ElseIf Fato = "LE" Then 
			If (shpQuadro(0).Left >= shpQuadro(0).Width) Then
				Verificacao = fcVerificaSeExisteObtaculo(shpQuadro(0).Left - shpQuadro(0).Height, shpQuadro(0).Top)
				If Verificacao = "O" Or Verificacao = "N" Then
					Call sbMovimenta(Fato)
					If Verificacao = "O" Then
						Call sbMontaObstaculos()
						Call sbReMontaObjetivo()
					End If
				End If
			Else
				Call sbChocou()
			End If
		ElseIf Fato = "RI" Then 
			If (shpQuadro(0).Left <= (Area.Width - (2 * shpQuadro(0).Width))) Then
				Verificacao = fcVerificaSeExisteObtaculo(shpQuadro(0).Left + shpQuadro(0).Width, shpQuadro(0).Top)
				If Verificacao = "O" Or Verificacao = "N" Then
					Call sbMovimenta(Fato)
					If Verificacao = "O" Then
						Call sbMontaObstaculos()
						Call sbReMontaObjetivo()
					End If
				End If
			Else
				Call sbChocou()
			End If
		End If
	End Sub
	
	Private Sub sbMovimenta(ByVal parStrFato As String)
		Dim intVetor As Short
		
		For intVetor = shpQuadro.UBound To 0 Step -1
			If intVetor = 0 Then
				If parStrFato = "UP" Then
					shpQuadro(0).Top = shpQuadro(0).Top - shpQuadro(0).Height
				ElseIf parStrFato = "DO" Then 
					shpQuadro(0).Top = shpQuadro(0).Top + shpQuadro(0).Height
				ElseIf parStrFato = "LE" Then 
					shpQuadro(0).Left = shpQuadro(0).Left - shpQuadro(0).Width
				ElseIf parStrFato = "RI" Then 
					shpQuadro(0).Left = shpQuadro(0).Left + shpQuadro(0).Width
				End If
			Else
				shpQuadro(intVetor).Top = shpQuadro(intVetor - 1).Top
				shpQuadro(intVetor).Left = shpQuadro(intVetor - 1).Left
			End If
		Next 
	End Sub
	
	Private Function fcVerificaSeExisteObtaculo(ByVal parX As Short, ByVal parY As Short) As String
		For vetorExisteObstaculo = 0 To shpObst.UBound
			If shpObjetivo(0).Left = parX And shpObjetivo(0).Top = parY Then
				fcVerificaSeExisteObtaculo = "O" 'Objetivo
				shpQuadro.Load(shpQuadro.UBound + 1)
				shpQuadro(shpQuadro.UBound).Visible = True
				Pontos = Pontos + PontosASeremSomados
				lblPontos.Text = Pontos & " Pontos"
				'UPGRADE_WARNING: Timer property tmrSnake.Interval cannot have a value of 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="169ECF4A-1968-402D-B243-16603CC08604"'
				If tmrSnake.Interval > TempoASerReduzido Then tmrSnake.Interval = tmrSnake.Interval - TempoASerReduzido
				Exit For
			ElseIf shpObst(vetorExisteObstaculo).Left = parX And shpObst(vetorExisteObstaculo).Top = parY Then 
				fcVerificaSeExisteObtaculo = "C" 'Chocou
				Call sbChocou()
				Exit For
			Else
				fcVerificaSeExisteObtaculo = "N" 'Nada anormal
			End If
		Next 
	End Function
	
	Private Sub sbReMontaObjetivo()
		Dim intVetorObstaculos As Short
		Dim intVetorQuadrosCobra As Short
		Dim blnNaoEncontrouQuadroDaCobraNemObstaculos As Boolean
		
		blnNaoEncontrouQuadroDaCobraNemObstaculos = False
		Do While blnNaoEncontrouQuadroDaCobraNemObstaculos = False
			Randomize()
			TempX = Int(Rnd() * 40) * 10
			Randomize()
			TempY = Int(Rnd() * 40) * 10
			For intVetorObstaculos = 0 To shpObst.UBound
				For intVetorQuadrosCobra = 0 To shpQuadro.UBound
					If (TempX <> shpQuadro(intVetorQuadrosCobra).Left And TempY <> shpQuadro(intVetorQuadrosCobra).Top) And (TempX <> shpObst(intVetorObstaculos).Left And TempY <> shpObst(intVetorObstaculos).Top) Then
						blnNaoEncontrouQuadroDaCobraNemObstaculos = True
					Else
						blnNaoEncontrouQuadroDaCobraNemObstaculos = False
						Exit For
						Exit For
					End If
				Next 
			Next 
		Loop 
		shpObjetivo(0).Top = TempY
		shpObjetivo(0).Left = TempX
	End Sub
	
	Private Sub sbMontaObstaculos(Optional ByVal ParBlnInicioDoJogo As Boolean = False)
		Dim intVetorObstaculos As Short
		Dim intVetorQuadrosCobra As Short
		Dim blnEncontrouQuadroDaCobra As Boolean
		
		If ParBlnInicioDoJogo = True Then
			For intVetorObstaculos = 1 To shpObst.UBound
				shpObst(intVetorObstaculos).Visible = False
				shpObst.Unload(intVetorObstaculos)
			Next 
		Else
			For intVetorObstaculos = (shpObst.UBound + 1) To (shpObst.UBound + IntObstaculosASeremSomados)
				shpObst.Load(intVetorObstaculos)
				shpObst(intVetorObstaculos).Visible = True
			Next 
		End If
		
		For intVetorObstaculos = 0 To shpObst.UBound
			blnEncontrouQuadroDaCobra = True
			Do While blnEncontrouQuadroDaCobra = True
				Randomize()
				TempX = Int(Rnd() * 40) * 10
				TempY = Int(Rnd() * 40) * 10
				For intVetorQuadrosCobra = 0 To shpQuadro.UBound
					If TempX = shpQuadro(intVetorQuadrosCobra).Left And TempY = shpQuadro(intVetorQuadrosCobra).Top Then
						blnEncontrouQuadroDaCobra = True
						Exit For
					Else
						blnEncontrouQuadroDaCobra = False
					End If
				Next 
			Loop 
			shpObst(intVetorObstaculos).Top = TempY
			shpObst(intVetorObstaculos).Left = TempX
		Next 
	End Sub
	
	Private Sub sbDesMontaCobra()
		Dim intVetorQuadrosCobra As Short
		
		If shpQuadro.UBound > 0 Then
			For intVetorQuadrosCobra = 1 To shpQuadro.UBound
				shpQuadro.Unload(intVetorQuadrosCobra)
			Next 
		End If
	End Sub
	
	Private Sub sbChocou()
		Me.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 100)
		Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 100)
		Me.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) - 100)
		Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) - 100)
		Me.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) - 100)
		Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) + 100)
		Me.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Top) + 100)
		Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) - 100)
		Beep()
		Fato = ""
		Chances = Chances - 1
		lblChances.Text = "Chance(s): " & Chances
		If Chances = 0 Then
			Fato = "FIM"
			lblFim.Visible = True
		End If
	End Sub
	
	Private Sub frmSnake_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		If Chances > 0 Then
			If KeyCode = System.Windows.Forms.Keys.Up Then
				Fato = "UP"
			ElseIf KeyCode = System.Windows.Forms.Keys.Right Then 
				Fato = "RI"
			ElseIf KeyCode = System.Windows.Forms.Keys.Left Then 
				Fato = "LE"
			ElseIf KeyCode = System.Windows.Forms.Keys.Down Then 
				Fato = "DO"
			End If
		End If
		If KeyCode = System.Windows.Forms.Keys.F2 Or (KeyCode = System.Windows.Forms.Keys.F2 And Fato = "FIM") Then
			Fato = ""
			Call frmSnake_Load(Me, New System.EventArgs())
		End If
		If KeyCode = 27 Then
			Me.Close()
		End If
	End Sub

End Class