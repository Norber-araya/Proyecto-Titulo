﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Navegacion
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
        Me.tipo = New System.Windows.Forms.Label()
        Me.rut = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tipo
        '
        Me.tipo.AutoSize = True
        Me.tipo.Location = New System.Drawing.Point(915, 100)
        Me.tipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(31, 17)
        Me.tipo.TabIndex = 57
        Me.tipo.Text = "tipo"
        '
        'rut
        '
        Me.rut.AutoSize = True
        Me.rut.Location = New System.Drawing.Point(915, 73)
        Me.rut.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.rut.Name = "rut"
        Me.rut.Size = New System.Drawing.Size(25, 17)
        Me.rut.TabIndex = 56
        Me.rut.Text = "rut"
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Location = New System.Drawing.Point(911, 46)
        Me.nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(56, 17)
        Me.nombre.TabIndex = 55
        Me.nombre.Text = "nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(716, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 17)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Bienvenido Usuario:"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(755, 266)
        Me.Button10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(123, 42)
        Me.Button10.TabIndex = 68
        Me.Button10.Text = "Factura salida"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(755, 326)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(123, 42)
        Me.Button9.TabIndex = 67
        Me.Button9.Text = "Buscar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "facturas "
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(376, 188)
        Me.Button8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(113, 50)
        Me.Button8.TabIndex = 66
        Me.Button8.Text = "Detalle Proveedor"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(563, 246)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(123, 50)
        Me.Button7.TabIndex = 65
        Me.Button7.Text = "Mermas"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(755, 389)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(123, 50)
        Me.Button6.TabIndex = 64
        Me.Button6.Text = "Reportes"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(755, 188)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(123, 50)
        Me.Button5.TabIndex = 63
        Me.Button5.Text = "Factura Entrada"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(563, 188)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 50)
        Me.Button4.TabIndex = 62
        Me.Button4.Text = "Bodega"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(189, 369)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 50)
        Me.Button3.TabIndex = 61
        Me.Button3.Text = "C.R.U.D   Usuarios"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(189, 274)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 50)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "C.R.U.D  Productos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(189, 188)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 50)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "C.R.U.D Proveedores"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(351, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 29)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Menu Principal"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(189, 447)
        Me.Button11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(123, 50)
        Me.Button11.TabIndex = 69
        Me.Button11.Text = "C.R.U.D   Cliente"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(456, 530)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(154, 36)
        Me.Button12.TabIndex = 70
        Me.Button12.Text = "Cerrar Sesion"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Navegacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 595)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tipo)
        Me.Controls.Add(Me.rut)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label3)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Navegacion"
        Me.Text = "Navegacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tipo As Label
    Friend WithEvents rut As Label
    Friend WithEvents nombre As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
End Class
