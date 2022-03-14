Module Module1
    Public matriz(10, 7)

    Public indice = 0

    Public Const EFECTIVO = 0.02
    Public Const CHEQUE = 0.015
    Public Const DOSDIAS = 0.05

    Dim totalparcial = 0
    Dim TOTAL = 0
    Dim totalDESCUENTO = 0
    Dim totaldescuento2 = 0

    Public Const INGLES = 150
    Public Const FRANCES = 125
    Public Const PORTUGUES = 80



    Function CalcularPAGOPARCIAL(idioma As Double, hora As Double) As Double

        totalparcial = (idioma * hora)

        Return Math.Round(totalparcial, 2)
    End Function

    Function CalcularDESCUENTO(idioma As Double, pago As Double) As Double

        totalDESCUENTO = (idioma * pago)

        Return Math.Round(totalDESCUENTO, 2)
    End Function

    Function CalcularDESCUENTO2(idioma As Double) As Double

        totaldescuento2 = (idioma * 0.05)

        Return Math.Round(totaldescuento2, 2)
    End Function

    Function CalcularTOTAL() As Double

        TOTAL = (totalparcial - totalDESCUENTO - totaldescuento2)

        Return Math.Round(TOTAL, 2)
    End Function



    Sub Limpiar()
        Form1.TexCARNE.Clear()
        Form1.TexNOMBRE.Clear()
        Form1.TextBoxHORAS.Clear()

        Form1.RadioINGLES.Checked = False
        Form1.RadioButtonFRANCES.Checked = False
        Form1.RadioButtonPORTUGUES.Checked = False

        Form1.RadioVIERNES.Checked = False
        Form1.RadioSABADO.Checked = False
        Form1.RadioAMBOS.Checked = False
        Form1.RadioButtonEFECTIVO.Checked = False
        Form1.RadioButtonCHEQUE.Checked = False



    End Sub

End Module
