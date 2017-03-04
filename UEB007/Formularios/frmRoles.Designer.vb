<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoles
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
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.pnlRoles = New System.Windows.Forms.Panel()
        Me.gridRoles = New System.Windows.Forms.DataGridView()
        CType(Me.gridRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenu
        '
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(740, 65)
        Me.pnlMenu.TabIndex = 0
        '
        'pnlRoles
        '
        Me.pnlRoles.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRoles.Location = New System.Drawing.Point(540, 65)
        Me.pnlRoles.Name = "pnlRoles"
        Me.pnlRoles.Size = New System.Drawing.Size(200, 368)
        Me.pnlRoles.TabIndex = 1
        '
        'gridRoles
        '
        Me.gridRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridRoles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridRoles.Location = New System.Drawing.Point(0, 65)
        Me.gridRoles.Name = "gridRoles"
        Me.gridRoles.Size = New System.Drawing.Size(540, 368)
        Me.gridRoles.TabIndex = 2
        '
        'frmRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 433)
        Me.Controls.Add(Me.gridRoles)
        Me.Controls.Add(Me.pnlRoles)
        Me.Controls.Add(Me.pnlMenu)
        Me.Name = "frmRoles"
        Me.ShowIcon = False
        Me.Text = "Administrar Roles"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents pnlRoles As Panel
    Friend WithEvents gridRoles As DataGridView
End Class
