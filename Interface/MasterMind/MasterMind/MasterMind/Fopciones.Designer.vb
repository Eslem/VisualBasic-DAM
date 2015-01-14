<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fopciones
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
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.btnok = New System.Windows.Forms.Button()
        Me.btncalcelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnok
        '
        Me.btnok.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnok.Location = New System.Drawing.Point(28, 146)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(113, 31)
        Me.btnok.TabIndex = 0
        Me.btnok.Text = "Aceptar"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'btncalcelar
        '
        Me.btncalcelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btncalcelar.Location = New System.Drawing.Point(176, 145)
        Me.btncalcelar.Name = "btncalcelar"
        Me.btncalcelar.Size = New System.Drawing.Size(111, 31)
        Me.btncalcelar.TabIndex = 1
        Me.btncalcelar.Text = "Cancelar"
        Me.btncalcelar.UseVisualStyleBackColor = True
        '
        'Fopciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 227)
        Me.Controls.Add(Me.btncalcelar)
        Me.Controls.Add(Me.btnok)
        Me.Name = "Fopciones"
        Me.Text = "Opciones del juego"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents btnok As System.Windows.Forms.Button
    Friend WithEvents btncalcelar As System.Windows.Forms.Button
End Class
