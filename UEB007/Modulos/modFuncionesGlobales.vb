Imports System.Data.SqlClient
'jimmy
'lauren
Module modFuncionesGlobales
    Public CnxStr As String = "Data Source = DESKTOP-K9BF7IE\BINARYLEMON; Persist Security Info = False; Initial Catalog = unn; User ID = sa; Password = binarylemon;"
    Public CNX As SqlConnection = New SqlConnection(CnxStr)
    Public Query As String
    Public Function GetRecords(ByVal Query As String) As DataTable
        Dim CMD As SqlCommand = New SqlCommand(Query, CNX)
        Dim DA As SqlDataAdapter = New SqlDataAdapter(CMD)

        Dim DTtmp As New DataTable

        Try
            CNX.Open()
            DA.Fill(DTtmp)
            GetRecords = DTtmp.Copy
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GetRecords = Nothing
            Exit Function

        Finally
            CNX.Close()
            CMD.Dispose() : CMD = Nothing
            DA.Dispose() : DA = Nothing
            DTtmp.Clear() : DTtmp.Dispose() : DTtmp = Nothing
        End Try
    End Function

    Public Sub ExecuteQuery(ByVal Query As String)
        Dim CMD As New SqlCommand(Query, CNX)
        Try
            CNX.Open()
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CNX.Close()
            CMD.Dispose() : CMD = Nothing
        End Try
    End Sub
    Public Function FindRecord(ByRef Table As DataTable, ByVal Value As String) As Integer
        FindRecord = -1
        If Table.Rows.Count > 0 Then
            For I As Integer = 0 To Table.Rows.Count - 1
                If Value = Table.Columns.Item(0).Table.Rows.Item(I).Item(0).ToString Then
                    FindRecord = I
                End If
            Next I
        End If
        Return FindRecord
    End Function

    Public Enum TipoFormulario
        Normal  ' Formularios independientes
        Hijo    ' Formularios hijos contenidos en un MDI (padre)
        Dialogo ' Cuadros de diálogo (confirmaciones, información, etc)
    End Enum

    Public Sub IniciarFormulario(ByVal Frm As Form, ByRef Contenedor As Form, ByVal Optional Tipo As TipoFormulario = TipoFormulario.Dialogo)
        Try
            'Verificando si el formulario está cerrado
            Dim Cerrado As Boolean = True
            For Each F As Form In Contenedor.MdiChildren
                If F.Name = Frm.Name Then
                    Cerrado = False
                End If
            Next
            'Si está cerrado, iniciamos una nueva instancia
            If Cerrado Then
                Frm.StartPosition = FormStartPosition.CenterParent
                Select Case Tipo
                    Case TipoFormulario.Normal
                        Frm.Show()
                    Case TipoFormulario.Hijo
                        Frm.MdiParent = Contenedor
                        Frm.Show()
                    Case TipoFormulario.Dialogo
                        Frm.ShowDialog()
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function EnLetras(numero As String) As String
        Dim b, paso As Integer
        Dim expresion, entero, deci, flag As String

        flag = "N"
        For paso = 1 To Len(numero)
            If Mid(numero, paso, 1) = "." Then
                flag = "S"
            Else
                If flag = "N" Then
                    entero = entero + Mid(numero, paso, 1) 'Extae la parte entera del numero
                Else
                    deci = deci + Mid(numero, paso, 1) 'Extrae la parte decimal del numero
                End If
            End If
        Next paso

        If Len(deci) = 1 Then
            deci = deci & "0"
        End If

        flag = "N"
        If Val(numero) >= -999999999 And Val(numero) <= 999999999 Then 'si el numero esta dentro de 0 a 999.999.999
            For paso = Len(entero) To 1 Step -1
                b = Len(entero) - (paso - 1)
                Select Case paso
                    Case 3, 6, 9
                        Select Case Mid(entero, b, 1)
                            Case "1"
                                If Mid(entero, b + 1, 1) = "0" And Mid(entero, b + 2, 1) = "0" Then
                                    expresion = expresion & "cien "
                                Else
                                    expresion = expresion & "ciento "
                                End If
                            Case "2"
                                expresion = expresion & "doscientos "
                            Case "3"
                                expresion = expresion & "trescientos "
                            Case "4"
                                expresion = expresion & "cuatrocientos "
                            Case "5"
                                expresion = expresion & "quinientos "
                            Case "6"
                                expresion = expresion & "seiscientos "
                            Case "7"
                                expresion = expresion & "setecientos "
                            Case "8"
                                expresion = expresion & "ochocientos "
                            Case "9"
                                expresion = expresion & "novecientos "
                        End Select

                    Case 2, 5, 8
                        Select Case Mid(entero, b, 1)
                            Case "1"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    flag = "S"
                                    expresion = expresion & "diez "
                                End If
                                If Mid(entero, b + 1, 1) = "1" Then
                                    flag = "S"
                                    expresion = expresion & "once "
                                End If
                                If Mid(entero, b + 1, 1) = "2" Then
                                    flag = "S"
                                    expresion = expresion & "doce "
                                End If
                                If Mid(entero, b + 1, 1) = "3" Then
                                    flag = "S"
                                    expresion = expresion & "trece "
                                End If
                                If Mid(entero, b + 1, 1) = "4" Then
                                    flag = "S"
                                    expresion = expresion & "catorce "
                                End If
                                If Mid(entero, b + 1, 1) = "5" Then
                                    flag = "S"
                                    expresion = expresion & "quince "
                                End If
                                If Mid(entero, b + 1, 1) > "5" Then
                                    flag = "N"
                                    expresion = expresion & "dieci"
                                End If

                            Case "2"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "veinte "
                                    flag = "S"
                                Else
                                    expresion = expresion & "veinti"
                                    flag = "N"
                                End If

                            Case "3"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "treinta "
                                    flag = "S"
                                Else
                                    expresion = expresion & "treinta y "
                                    flag = "N"
                                End If

                            Case "4"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "cuarenta "
                                    flag = "S"
                                Else
                                    expresion = expresion & "cuarenta y "
                                    flag = "N"
                                End If

                            Case "5"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "cincuenta "
                                    flag = "S"
                                Else
                                    expresion = expresion & "cincuenta y "
                                    flag = "N"
                                End If

                            Case "6"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "sesenta "
                                    flag = "S"
                                Else
                                    expresion = expresion & "sesenta y "
                                    flag = "N"
                                End If

                            Case "7"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "setenta "
                                    flag = "S"
                                Else
                                    expresion = expresion & "setenta y "
                                    flag = "N"
                                End If

                            Case "8"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "ochenta "
                                    flag = "S"
                                Else
                                    expresion = expresion & "ochenta y "
                                    flag = "N"
                                End If

                            Case "9"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "noventa "
                                    flag = "S"
                                Else
                                    expresion = expresion & "noventa y "
                                    flag = "N"
                                End If
                        End Select

                    Case 1, 4, 7
                        Select Case Mid(entero, b, 1)
                            Case "1"
                                If flag = "N" Then
                                    If paso = 1 Then
                                        expresion = expresion & "uno "
                                    Else
                                        expresion = expresion & "un "
                                    End If
                                End If
                            Case "2"
                                If flag = "N" Then
                                    expresion = expresion & "dos "
                                End If
                            Case "3"
                                If flag = "N" Then
                                    expresion = expresion & "tres "
                                End If
                            Case "4"
                                If flag = "N" Then
                                    expresion = expresion & "cuatro "
                                End If
                            Case "5"
                                If flag = "N" Then
                                    expresion = expresion & "cinco "
                                End If
                            Case "6"
                                If flag = "N" Then
                                    expresion = expresion & "seis "
                                End If
                            Case "7"
                                If flag = "N" Then
                                    expresion = expresion & "siete "
                                End If
                            Case "8"
                                If flag = "N" Then
                                    expresion = expresion & "ocho "
                                End If
                            Case "9"
                                If flag = "N" Then
                                    expresion = expresion & "nueve "
                                End If
                        End Select
                End Select
                If paso = 4 Then
                    If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or
                      (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And
                       Len(entero) <= 6) Then
                        expresion = expresion & "mil "
                    End If
                End If
                If paso = 7 Then
                    If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then
                        expresion = expresion & "millón "
                    Else
                        expresion = expresion & "millones "
                    End If
                End If
            Next paso

            If deci <> "" Then
                If Mid(entero, 1, 1) = "-" Then 'si el numero es negativo
                    EnLetras = "menos " & expresion & "con " & deci ' & "/100"
                Else
                    EnLetras = expresion & "con " & deci ' & "/100"
                End If
            Else
                If Mid(entero, 1, 1) = "-" Then 'si el numero es negativo
                    EnLetras = "menos " & expresion
                Else
                    EnLetras = expresion
                End If
            End If
        Else 'si el numero a convertir esta fuera del rango superior e inferior
            EnLetras = ""
        End If
    End Function
End Module
