<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTiposU
    Inherits Syncfusion.Windows.Forms.MetroForm

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
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.PnlTiposU = New System.Windows.Forms.Panel()
        Me.gridTiposU = New System.Windows.Forms.DataGridView()
        CType(Me.gridTiposU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlMenu
        '
        Me.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(740, 65)
        Me.PnlMenu.TabIndex = 0
        '
        'PnlTiposU
        '
        Me.PnlTiposU.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlTiposU.Location = New System.Drawing.Point(540, 65)
        Me.PnlTiposU.Name = "PnlTiposU"
        Me.PnlTiposU.Size = New System.Drawing.Size(200, 368)
        Me.PnlTiposU.TabIndex = 1
        '
        'gridTiposU
        '
        Me.gridTiposU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridTiposU.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridTiposU.Location = New System.Drawing.Point(0, 65)
        Me.gridTiposU.Name = "gridTiposU"
        Me.gridTiposU.Size = New System.Drawing.Size(540, 368)
        Me.gridTiposU.TabIndex = 2
        '
        'frmTiposU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 433)
        Me.Controls.Add(Me.gridTiposU)
        Me.Controls.Add(Me.PnlTiposU)
        Me.Controls.Add(Me.PnlMenu)
        Me.Name = "frmTiposU"
        Me.ShowIcon = False
        Me.Text = "Administrar Tipos de Usuarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridTiposU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlMenu As Panel
    Friend WithEvents PnlTiposU As Panel
    Friend WithEvents gridTiposU As DataGridView
End Class
