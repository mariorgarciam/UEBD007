<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Docentes
    Inherits Syncfusion.Windows.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.pnlDocentes = New System.Windows.Forms.Panel()
        Me.gridDocente = New System.Windows.Forms.DataGridView()
        CType(Me.gridDocente, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'pnlDocentes
        '
        Me.pnlDocentes.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlDocentes.Location = New System.Drawing.Point(540, 65)
        Me.pnlDocentes.Name = "pnlDocentes"
        Me.pnlDocentes.Size = New System.Drawing.Size(200, 368)
        Me.pnlDocentes.TabIndex = 1
        '
        'gridDocente
        '
        Me.gridDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDocente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDocente.Location = New System.Drawing.Point(0, 65)
        Me.gridDocente.Name = "gridDocente"
        Me.gridDocente.Size = New System.Drawing.Size(540, 368)
        Me.gridDocente.TabIndex = 2
        '
        'frm_Docentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 433)
        Me.Controls.Add(Me.gridDocente)
        Me.Controls.Add(Me.pnlDocentes)
        Me.Controls.Add(Me.pnlMenu)
        Me.Name = "frm_Docentes"
        Me.ShowIcon = False
        Me.Text = "Administrar Docentes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridDocente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenu As Panel
    Friend WithEvents pnlDocentes As Panel
    Friend WithEvents gridDocente As DataGridView
End Class
