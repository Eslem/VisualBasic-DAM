<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fconexion
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnInsercion = New System.Windows.Forms.Button()
        Me.BtnConsultaEsc = New System.Windows.Forms.Button()
        Me.ListaAlumnos = New System.Windows.Forms.ListBox()
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.BtnConsultaDesc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Conexion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnInsercion
        '
        Me.BtnInsercion.Location = New System.Drawing.Point(36, 94)
        Me.BtnInsercion.Name = "BtnInsercion"
        Me.BtnInsercion.Size = New System.Drawing.Size(92, 45)
        Me.BtnInsercion.TabIndex = 0
        Me.BtnInsercion.Text = "Insercion"
        Me.BtnInsercion.UseVisualStyleBackColor = True
        '
        'BtnConsultaEsc
        '
        Me.BtnConsultaEsc.Location = New System.Drawing.Point(36, 163)
        Me.BtnConsultaEsc.Name = "BtnConsultaEsc"
        Me.BtnConsultaEsc.Size = New System.Drawing.Size(91, 43)
        Me.BtnConsultaEsc.TabIndex = 1
        Me.BtnConsultaEsc.Text = "ConsultaEscalar"
        Me.BtnConsultaEsc.UseVisualStyleBackColor = True
        '
        'ListaAlumnos
        '
        Me.ListaAlumnos.FormattingEnabled = True
        Me.ListaAlumnos.Location = New System.Drawing.Point(159, 208)
        Me.ListaAlumnos.Name = "ListaAlumnos"
        Me.ListaAlumnos.Size = New System.Drawing.Size(143, 134)
        Me.ListaAlumnos.TabIndex = 2
        '
        'btnConsulta
        '
        Me.btnConsulta.Location = New System.Drawing.Point(36, 229)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(91, 46)
        Me.btnConsulta.TabIndex = 3
        Me.btnConsulta.Text = "Consulta"
        Me.btnConsulta.UseVisualStyleBackColor = True
        '
        'BtnConsultaDesc
        '
        Me.BtnConsultaDesc.Location = New System.Drawing.Point(36, 299)
        Me.BtnConsultaDesc.Name = "BtnConsultaDesc"
        Me.BtnConsultaDesc.Size = New System.Drawing.Size(91, 43)
        Me.BtnConsultaDesc.TabIndex = 4
        Me.BtnConsultaDesc.Text = "Consulta Desconectado"
        Me.BtnConsultaDesc.UseVisualStyleBackColor = True
        '
        'Fconexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 354)
        Me.Controls.Add(Me.BtnConsultaDesc)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.ListaAlumnos)
        Me.Controls.Add(Me.BtnConsultaEsc)
        Me.Controls.Add(Me.BtnInsercion)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Fconexion"
        Me.Text = "Ejemplo de conexión y acceso a BD"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnInsercion As System.Windows.Forms.Button
    Friend WithEvents BtnConsultaEsc As System.Windows.Forms.Button
    Friend WithEvents ListaAlumnos As System.Windows.Forms.ListBox
    Friend WithEvents btnConsulta As System.Windows.Forms.Button
    Friend WithEvents BtnConsultaDesc As System.Windows.Forms.Button

End Class
