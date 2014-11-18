<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMaster
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoJuegoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NivelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComoJugarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pcolores = New System.Windows.Forms.GroupBox()
        Me.psecreta = New System.Windows.Forms.GroupBox()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.OpcionesToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(802, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoJuegoToolStripMenuItem, Me.NivelToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'NuevoJuegoToolStripMenuItem
        '
        Me.NuevoJuegoToolStripMenuItem.Name = "NuevoJuegoToolStripMenuItem"
        Me.NuevoJuegoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoJuegoToolStripMenuItem.Text = "&Nuevo juego"
        '
        'NivelToolStripMenuItem
        '
        Me.NivelToolStripMenuItem.Name = "NivelToolStripMenuItem"
        Me.NivelToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NivelToolStripMenuItem.Text = "&Nivel..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComoJugarToolStripMenuItem, Me.AcercadeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "A&yuda"
        '
        'ComoJugarToolStripMenuItem
        '
        Me.ComoJugarToolStripMenuItem.Name = "ComoJugarToolStripMenuItem"
        Me.ComoJugarToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ComoJugarToolStripMenuItem.Text = "&Como jugar..."
        '
        'AcercadeToolStripMenuItem
        '
        Me.AcercadeToolStripMenuItem.Name = "AcercadeToolStripMenuItem"
        Me.AcercadeToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.AcercadeToolStripMenuItem.Text = "Acerca &de"
        '
        'pcolores
        '
        Me.pcolores.Location = New System.Drawing.Point(515, 46)
        Me.pcolores.Name = "pcolores"
        Me.pcolores.Size = New System.Drawing.Size(263, 76)
        Me.pcolores.TabIndex = 1
        Me.pcolores.TabStop = False
        Me.pcolores.Text = "Colores Disponibles"
        '
        'psecreta
        '
        Me.psecreta.Location = New System.Drawing.Point(515, 134)
        Me.psecreta.Name = "psecreta"
        Me.psecreta.Size = New System.Drawing.Size(262, 78)
        Me.psecreta.TabIndex = 2
        Me.psecreta.TabStop = False
        Me.psecreta.Text = "Combinacion secreta"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.Enabled = False
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'FMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 418)
        Me.Controls.Add(Me.psecreta)
        Me.Controls.Add(Me.pcolores)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FMaster"
        Me.Text = "Master Mind"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoJuegoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComoJugarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NivelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pcolores As System.Windows.Forms.GroupBox
    Friend WithEvents psecreta As System.Windows.Forms.GroupBox
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
