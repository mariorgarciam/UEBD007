Imports Syncfusion.Windows.Forms
Imports System.Data.SqlClient


Public Class frmSede
    Inherits MetroForm
    Dim TableSP As New DataTable
    Dim FlagIndex As Integer

    Private Sub LoadRecords()
        TableSP = GetRecords("SELECT * FROM SP ORDER BY SP")
        gridSede.DataSource = TableSP
        gridSede.Columns(0).Width = 50
        gridSede.Columns(0).HeaderText = "Codigo"
        gridSede.Columns(1).HeaderText = "Descripcion"
        FlagIndex = -1
    End Sub
End Class
