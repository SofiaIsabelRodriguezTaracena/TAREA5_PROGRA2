Public Class Form1
    Dim totalparcial = 0
    Dim ddescuento1 = 0
    Dim ddescuento2 = 0
    Dim Totalfinal = 0

    Private Sub BCALCULAR_Click(sender As Object, e As EventArgs) Handles BCALCULAR.Click

        If TexCARNE.Text = "" Then
            MsgBox("ERROR CARNE")
            Exit Sub
        End If


        If TexNOMBRE.Text = "" Then
            MsgBox("ERROR NOMBRE")
            Exit Sub
        End If




        If TextBoxHORAS.Text = "" Then
            MsgBox("ERROR HORAS")
            Exit Sub
        End If




        If indice < 8 Then

            matriz(0, indice) = TexCARNE.Text
            matriz(1, indice) = TexNOMBRE.Text
            If RadioINGLES.Checked Then
                matriz(2, indice) = RadioINGLES.Text
            ElseIf RadioButtonFRANCES.Checked Then
                matriz(2, indice) = RadioButtonFRANCES.Text
            ElseIf RadioButtonPORTUGUES.Checked Then
                matriz(2, indice) = RadioButtonPORTUGUES.Text
            End If
            matriz(3, indice) = DTP1.Value

            If RadioVIERNES.Checked Then
                matriz(4, indice) = RadioVIERNES.Text
            ElseIf RadioSABADO.Checked Then
                matriz(4, indice) = RadioSABADO.Text
            ElseIf RadioAMBOS.Checked Then
                matriz(4, indice) = RadioAMBOS.Text
            End If
            matriz(5, indice) = TextBoxHORAS.Text

            If RadioButtonCHEQUE.Checked Then
                matriz(6, indice) = RadioButtonCHEQUE.Text
            ElseIf RadioButtonEFECTIVO.Checked Then
                matriz(6, indice) = RadioButtonEFECTIVO.Text

            End If



            If RadioINGLES.Checked Then
                totalparcial = Str(CalcularPAGOPARCIAL(INGLES, TextBoxHORAS.Text))
            ElseIf RadioButtonFRANCES.Checked Then
                totalparcial = Str(CalcularPAGOPARCIAL(FRANCES, TextBoxHORAS.Text))
            ElseIf RadioButtonPORTUGUES.Checked Then
                totalparcial = Str(CalcularPAGOPARCIAL(PORTUGUES, TextBoxHORAS.Text))
            End If


            If RadioINGLES.Checked And RadioButtonCHEQUE.Checked Then
                ddescuento1 = Str(CalcularDESCUENTO(INGLES, CHEQUE))

            ElseIf RadioButtonFRANCES.Checked And RadioButtonCHEQUE.Checked Then
                ddescuento1 = Str(CalcularPAGOPARCIAL(FRANCES, TextBoxHORAS.Text))

            ElseIf RadioButtonPORTUGUES.Checked And RadioButtonCHEQUE.Checked Then
                ddescuento1 = Str(CalcularPAGOPARCIAL(PORTUGUES, TextBoxHORAS.Text))
            End If

            If RadioINGLES.Checked And RadioButtonEFECTIVO.Checked Then
                ddescuento1 = Str(CalcularDESCUENTO(INGLES, EFECTIVO))

            ElseIf RadioButtonFRANCES.Checked And RadioButtonEFECTIVO.Checked Then
                ddescuento1 = Str(CalcularPAGOPARCIAL(FRANCES, TextBoxHORAS.Text))

            ElseIf RadioButtonPORTUGUES.Checked And RadioButtonEFECTIVO.Checked Then
                ddescuento1 = Str(CalcularPAGOPARCIAL(PORTUGUES, TextBoxHORAS.Text))
            End If


            If RadioINGLES.Checked And RadioAMBOS.Checked Then
                ddescuento2 = Str(CalcularDESCUENTO2(INGLES))
            ElseIf RadioButtonFRANCES.Checked And RadioAMBOS.Checked Then
                ddescuento2 = Str(CalcularDESCUENTO2(FRANCES))
            ElseIf RadioButtonPORTUGUES.Checked And RadioAMBOS.Checked Then
                ddescuento2 = Str(CalcularDESCUENTO2(PORTUGUES))
            End If


            Totalfinal = Str(CalcularTOTAL())



            matriz(7, indice) = totalparcial.ToString
            matriz(8, indice) = ddescuento1.ToString
            matriz(9, indice) = ddescuento2.ToString
            matriz(10, indice) = Totalfinal.ToString


            DataCALCULAR.Rows.Add(indice + 1, matriz(0, indice), matriz(1, indice), matriz(2, indice), matriz(3, indice), matriz(4, indice), matriz(5, indice), matriz(6, indice), matriz(7, indice), matriz(8, indice), matriz(9, indice), matriz(10, indice))
            indice = indice + 1






        Else
            MessageBox.Show("YA ES EL LIMITE")
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Limpiar()
    End Sub

    Private Sub ButtonSALIR_Click(sender As Object, e As EventArgs) Handles ButtonSALIR.Click

        If MsgBox("¿DESEA SALIR?", vbYesNo) = vbYes Then
            End
        End If
    End Sub







End Class
