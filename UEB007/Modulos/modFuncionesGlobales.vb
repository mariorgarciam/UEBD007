Imports System.Data.SqlClient
Module modFuncionesGlobales
    Public CnxStr As String = "Data Source = DESKTOP-K9BF7IE\BINARYLEMON; Persist Security Info = False; Initial Catalog = silais; User ID = sa; Password = binarylemon;"
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

    Private Sub mensaje()
        MsgBox("mensaje")
    End Sub

    Private Sub msj()
        MsgBox("mensaje")
    End Sub
End Module
