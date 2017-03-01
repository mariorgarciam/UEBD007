<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiPrincipal
    Inherits Syncfusion.Windows.Forms.Tools.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Office2013ColorTable1 As Syncfusion.Windows.Forms.Tools.Office2013ColorTable = New Syncfusion.Windows.Forms.Tools.Office2013ColorTable()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiPrincipal))
        Me.rcaMenuPrincipal = New Syncfusion.Windows.Forms.Tools.RibbonControlAdv()
        Me.ToolStripTabItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.ToolStripTabItem2 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.ToolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.tsbSucursal = New System.Windows.Forms.ToolStripButton()
        CType(Me.rcaMenuPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rcaMenuPrincipal.SuspendLayout()
        Me.ToolStripTabItem1.Panel.SuspendLayout()
        Me.ToolStripEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rcaMenuPrincipal
        '
        Me.rcaMenuPrincipal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.rcaMenuPrincipal.Header.AddMainItem(ToolStripTabItem1)
        Me.rcaMenuPrincipal.Header.AddMainItem(ToolStripTabItem2)
        Me.rcaMenuPrincipal.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro
        Me.rcaMenuPrincipal.Location = New System.Drawing.Point(1, 0)
        Me.rcaMenuPrincipal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rcaMenuPrincipal.MenuButtonFont = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.rcaMenuPrincipal.MenuButtonText = ""
        Me.rcaMenuPrincipal.MenuButtonWidth = 56
        Me.rcaMenuPrincipal.MenuColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.rcaMenuPrincipal.MinimumSize = New System.Drawing.Size(0, 72)
        Me.rcaMenuPrincipal.Name = "rcaMenuPrincipal"
        Office2013ColorTable1.BackStageCaptionColor = System.Drawing.Color.White
        Office2013ColorTable1.ButtonBackgroundPressed = System.Drawing.Color.Empty
        Office2013ColorTable1.ButtonBackgroundSelected = System.Drawing.Color.Empty
        Office2013ColorTable1.CaptionBackColor = System.Drawing.Color.White
        Office2013ColorTable1.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Office2013ColorTable1.CheckedTabColor = System.Drawing.Color.White
        Office2013ColorTable1.CheckedTabForeColor = System.Drawing.Color.Empty
        Office2013ColorTable1.CloseButtonColor = System.Drawing.Color.Empty
        Office2013ColorTable1.ContextMenuBackColor = System.Drawing.Color.Empty
        Office2013ColorTable1.ContextMenuItemSelected = System.Drawing.Color.Empty
        Office2013ColorTable1.HeaderColor = System.Drawing.Color.White
        Office2013ColorTable1.HoverTabForeColor = System.Drawing.Color.Empty
        Office2013ColorTable1.LauncherBackColorSelected = System.Drawing.Color.Empty
        Office2013ColorTable1.LauncherColorNormal = System.Drawing.Color.Empty
        Office2013ColorTable1.LauncherColorSelected = System.Drawing.Color.Empty
        Office2013ColorTable1.MaximizeButtonColor = System.Drawing.Color.Empty
        Office2013ColorTable1.MinimizeButtonColor = System.Drawing.Color.Empty
        Office2013ColorTable1.PanelBackColor = System.Drawing.Color.White
        Office2013ColorTable1.RestoreButtonColor = System.Drawing.Color.Empty
        Office2013ColorTable1.RibbonPanelBorderColor = System.Drawing.Color.Empty
        Office2013ColorTable1.SelectedTabBorderColor = System.Drawing.Color.White
        Office2013ColorTable1.SelectedTabColor = System.Drawing.Color.White
        Office2013ColorTable1.SplitButtonBackgroundPressed = System.Drawing.Color.Empty
        Office2013ColorTable1.SplitButtonBackgroundSelected = System.Drawing.Color.Empty
        Office2013ColorTable1.SystemButtonBackground = System.Drawing.Color.Empty
        Office2013ColorTable1.TabBackColor = System.Drawing.Color.White
        Office2013ColorTable1.TabForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Office2013ColorTable1.TitleColor = System.Drawing.Color.Empty
        Office2013ColorTable1.ToolStripBackColor = System.Drawing.Color.White
        Office2013ColorTable1.ToolStripBorderColor = System.Drawing.Color.White
        Office2013ColorTable1.ToolStripItemForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Office2013ColorTable1.ToolStripSpliterColor = System.Drawing.Color.LightGray
        Office2013ColorTable1.UpDownButtonBackColor = System.Drawing.Color.Empty
        Me.rcaMenuPrincipal.Office2013ColorTable = Office2013ColorTable1
        Me.rcaMenuPrincipal.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed
        '
        'rcaMenuPrincipal.OfficeMenu
        '
        Me.rcaMenuPrincipal.OfficeMenu.Name = "OfficeMenu"
        Me.rcaMenuPrincipal.OfficeMenu.ShowItemToolTips = True
        Me.rcaMenuPrincipal.OfficeMenu.Size = New System.Drawing.Size(12, 65)
        Me.rcaMenuPrincipal.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rcaMenuPrincipal.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None
        Me.rcaMenuPrincipal.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.TouchStyle
        Me.rcaMenuPrincipal.SelectedTab = Me.ToolStripTabItem1
        Me.rcaMenuPrincipal.ShowRibbonDisplayOptionButton = True
        Me.rcaMenuPrincipal.Size = New System.Drawing.Size(974, 186)
        Me.rcaMenuPrincipal.SystemText.QuickAccessDialogDropDownName = "Start menu"
        Me.rcaMenuPrincipal.SystemText.RenameDisplayLabelText = "&Display Name:"
        Me.rcaMenuPrincipal.TabIndex = 0
        Me.rcaMenuPrincipal.Text = "RibbonControlAdv1"
        Me.rcaMenuPrincipal.TitleColor = System.Drawing.Color.White
        '
        'ToolStripTabItem1
        '
        Me.ToolStripTabItem1.Name = "ToolStripTabItem1"
        '
        'rcaMenuPrincipal.RibbonPanel1
        '
        Me.ToolStripTabItem1.Panel.Controls.Add(Me.ToolStripEx1)
        Me.ToolStripTabItem1.Panel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.ToolStripTabItem1.Panel.Name = "RibbonPanel1"
        Me.ToolStripTabItem1.Panel.Padding = New System.Windows.Forms.Padding(0, 2, 52, 0)
        Me.ToolStripTabItem1.Panel.ScrollPosition = 0
        Me.ToolStripTabItem1.Panel.TabIndex = 2
        Me.ToolStripTabItem1.Panel.Text = "ToolStripTabItem1"
        Me.ToolStripTabItem1.Position = 0
        Me.ToolStripTabItem1.Size = New System.Drawing.Size(118, 29)
        Me.ToolStripTabItem1.Tag = "1"
        Me.ToolStripTabItem1.Text = "ToolStripTabItem1"
        '
        'ToolStripTabItem2
        '
        Me.ToolStripTabItem2.Name = "ToolStripTabItem2"
        '
        'rcaMenuPrincipal.RibbonPanel2
        '
        Me.ToolStripTabItem2.Panel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.ToolStripTabItem2.Panel.Name = "RibbonPanel2"
        Me.ToolStripTabItem2.Panel.Padding = New System.Windows.Forms.Padding(0, 2, 52, 0)
        Me.ToolStripTabItem2.Panel.ScrollPosition = 0
        Me.ToolStripTabItem2.Panel.TabIndex = 3
        Me.ToolStripTabItem2.Panel.Text = "ToolStripTabItem2"
        Me.ToolStripTabItem2.Position = 1
        Me.ToolStripTabItem2.Size = New System.Drawing.Size(118, 29)
        Me.ToolStripTabItem2.Tag = "2"
        Me.ToolStripTabItem2.Text = "ToolStripTabItem2"
        '
        'ToolStripEx1
        '
        Me.ToolStripEx1.AutoSize = False
        Me.ToolStripEx1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripEx1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripEx1.Image = Nothing
        Me.ToolStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSucursal})
        Me.ToolStripEx1.Location = New System.Drawing.Point(0, 2)
        Me.ToolStripEx1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ToolStripEx1.Name = "ToolStripEx1"
        Me.ToolStripEx1.Office12Mode = False
        Me.ToolStripEx1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStripEx1.Size = New System.Drawing.Size(150, 130)
        Me.ToolStripEx1.TabIndex = 0
        '
        'tsbSucursal
        '
        Me.tsbSucursal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSucursal.Image = CType(resources.GetObject("tsbSucursal.Image"), System.Drawing.Image)
        Me.tsbSucursal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSucursal.Name = "tsbSucursal"
        Me.tsbSucursal.Size = New System.Drawing.Size(23, 109)
        Me.tsbSucursal.Text = "ToolStripButton1"
        '
        'mdiPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 600)
        Me.Controls.Add(Me.rcaMenuPrincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "mdiPrincipal"
        Me.Padding = New System.Windows.Forms.Padding(2, 0, 2, 2)
        Me.ShowIcon = False
        Me.Text = "Sistema de Registro Académico"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.rcaMenuPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rcaMenuPrincipal.ResumeLayout(False)
        Me.rcaMenuPrincipal.PerformLayout()
        Me.ToolStripTabItem1.Panel.ResumeLayout(False)
        Me.ToolStripEx1.ResumeLayout(False)
        Me.ToolStripEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rcaMenuPrincipal As Syncfusion.Windows.Forms.Tools.RibbonControlAdv
    Friend WithEvents ToolStripTabItem1 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
    Friend WithEvents ToolStripEx1 As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents tsbSucursal As ToolStripButton
    Friend WithEvents ToolStripTabItem2 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
End Class
