Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Public Class mdiPrincipal
    Inherits RibbonForm
    Dim Estilo As New TouchStyleColorTable()

    Private Sub Estilo_Citrus_Flowers()
        Estilo.ToolstripSelectedTabItemBorder = ColorTranslator.FromHtml("#00923F")
        'Color tab no seleccionado
        Estilo.ToolstripTabItemForeColor = Color.White
        Estilo.ToolstripActiveTabItemForeColor = Color.Black
        'Color letra hover tab
        Estilo.HoverTabForeColor = ColorTranslator.FromHtml("#006060")

        Estilo.ToolStripSpliterColor = Color.White
        Estilo.MenuButtonArrowColor = Color.White
        Estilo.DropDownTextForeColor = Color.Black
        'Menu opciones config
        Estilo.DropDownMenuItemBackground = ColorTranslator.FromHtml("#00923F")
        Estilo.DropDownSelectedTextForeColor = Color.White
        Estilo.DropDownBodyColor = Color.White
        Estilo.ImageMargin = Color.White
        Estilo.DropDownTitleBackground = Color.LightGray
        Estilo.ButtonPressedColor = ColorTranslator.FromHtml("#92c0e0")
        Estilo.ButtonHoverColor = ColorTranslator.FromHtml("#cde6f7")
        Estilo.ButtonCheckedColor = ColorTranslator.FromHtml("#00923F")

        'Color del menu ribbon
        Estilo.HeaderColor = ColorTranslator.FromHtml("#00923F")
        Estilo.BackStageButtonColor = ColorTranslator.FromHtml("#00923F")
        Estilo.BackStageTabColor = ColorTranslator.FromHtml("#00923F")
        Estilo.ToolStripBorderColor = ColorTranslator.FromHtml("#00923F")
        Estilo.ToolstripTabItemBorder = ColorTranslator.FromHtml("#00923F")
        Estilo.BottomToolStripBackColor = ColorTranslator.FromHtml("#00923F")
        Me.rcaMenuPrincipal.MenuColor = ColorTranslator.FromHtml("#00923F")

        'Color flecha izquierda
        Estilo.BackStageNavigationButtonBackColor = ColorTranslator.FromHtml("#00923F")
        Estilo.MenuButtonHoverArrowColor = ColorTranslator.FromHtml("#E6E6E6")
        Estilo.BackStageButtonHoverColor = ColorTranslator.FromHtml("#E6E6E6")
        Estilo.BackStageTabHoverColor = ColorTranslator.FromHtml("#E6E6E6")
        'Color de fondo min y max en backstage
        Estilo.BackStageSysytemButtonBackground = ColorTranslator.FromHtml("#00923F")
        Estilo.BackStageButtonHoverColor = ColorTranslator.FromHtml("#009090")

        rcaMenuPrincipal.ApplyTouchStyleColorTable(Estilo)

        'ribbAdmin.RibbonHeaderImage = RibbonHeaderImage.Floweral
        rcaMenuPrincipal.RibbonHeaderImage = RibbonHeaderImage.None
    End Sub

    Private Sub Propiedades()
        'Hacer grande los elementos del ribbon
        Me.rcaMenuPrincipal.RibbonTouchModeEnabled = True
        'Activar customize
        Me.rcaMenuPrincipal.QuickPanelVisible = False
    End Sub

    Private Sub mdiPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Propiedades()
        Estilo_Citrus_Flowers()
        'IniciarFormulario(frmIniciarSesion, Me, TipoFormulario.Dialogo)
    End Sub

    Private Sub tsbSucursal_Click(sender As Object, e As EventArgs) Handles tsbSucursal.Click
        IniciarFormulario(frmSede, Me, TipoFormulario.Hijo)
    End Sub
End Class


