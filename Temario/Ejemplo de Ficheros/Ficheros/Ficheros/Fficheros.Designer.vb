<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fficheros
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
        Me.lista = New System.Windows.Forms.ListBox()
        Me.Bcargar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TLineas = New System.Windows.Forms.TextBox()
        Me.Etexto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Fdirectorios = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lista
        '
        Me.lista.FormattingEnabled = True
        Me.lista.Location = New System.Drawing.Point(33, 48)
        Me.lista.Name = "lista"
        Me.lista.Size = New System.Drawing.Size(340, 199)
        Me.lista.TabIndex = 0
        '
        'Bcargar
        '
        Me.Bcargar.Location = New System.Drawing.Point(33, 9)
        Me.Bcargar.Name = "Bcargar"
        Me.Bcargar.Size = New System.Drawing.Size(119, 33)
        Me.Bcargar.TabIndex = 1
        Me.Bcargar.Text = "Cargar fichero"
        Me.Bcargar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Número de líneas:"
        '
        'TLineas
        '
        Me.TLineas.Location = New System.Drawing.Point(277, 12)
        Me.TLineas.MaxLength = 5
        Me.TLineas.Name = "TLineas"
        Me.TLineas.Size = New System.Drawing.Size(53, 20)
        Me.TLineas.TabIndex = 3
        '
        'Etexto
        '
        Me.Etexto.Location = New System.Drawing.Point(479, 22)
        Me.Etexto.MaxLength = 5
        Me.Etexto.Name = "Etexto"
        Me.Etexto.Size = New System.Drawing.Size(319, 20)
        Me.Etexto.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(391, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Texto a escribir:"
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(479, 48)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(119, 33)
        Me.BGuardar.TabIndex = 6
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(679, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cerrar Fichero"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Fdirectorios
        '
        Me.Fdirectorios.Location = New System.Drawing.Point(33, 253)
        Me.Fdirectorios.Name = "Fdirectorios"
        Me.Fdirectorios.Size = New System.Drawing.Size(92, 34)
        Me.Fdirectorios.TabIndex = 8
        Me.Fdirectorios.Text = "Directorios"
        Me.Fdirectorios.UseVisualStyleBackColor = True
        '
        'Fficheros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 300)
        Me.Controls.Add(Me.Fdirectorios)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.Etexto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TLineas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bcargar)
        Me.Controls.Add(Me.lista)
        Me.Name = "Fficheros"
        Me.Text = "Ejemplo de uso de ficheros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lista As System.Windows.Forms.ListBox
    Friend WithEvents Bcargar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TLineas As System.Windows.Forms.TextBox
    Friend WithEvents Etexto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BGuardar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Fdirectorios As System.Windows.Forms.Button

End Class
