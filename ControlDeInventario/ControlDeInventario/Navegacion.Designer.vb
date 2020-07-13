<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Navegacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.permiso = New System.Windows.Forms.Label()
        Me.rut = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'permiso
        '
        Me.permiso.AutoSize = True
        Me.permiso.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.permiso.Location = New System.Drawing.Point(795, 76)
        Me.permiso.Name = "permiso"
        Me.permiso.Size = New System.Drawing.Size(30, 17)
        Me.permiso.TabIndex = 57
        Me.permiso.Text = "tipo"
        '
        'rut
        '
        Me.rut.AutoSize = True
        Me.rut.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rut.Location = New System.Drawing.Point(795, 59)
        Me.rut.Name = "rut"
        Me.rut.Size = New System.Drawing.Size(24, 17)
        Me.rut.TabIndex = 56
        Me.rut.Text = "rut"
        '
        'nombre
        '
        Me.nombre.AutoSize = True
        Me.nombre.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(795, 37)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(51, 17)
        Me.nombre.TabIndex = 55
        Me.nombre.Text = "nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(672, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Bienvenido Usuario:"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(461, 370)
        Me.Button8.Margin = New System.Windows.Forms.Padding(2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(85, 41)
        Me.Button8.TabIndex = 66
        Me.Button8.Text = "Detalle Proveedor"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(360, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 39)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Menu Principal"
        '
        'Button14
        '
        Me.Button14.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_datospersonales
        Me.Button14.FlatAppearance.BorderSize = 0
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Location = New System.Drawing.Point(2, 12)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(202, 93)
        Me.Button14.TabIndex = 73
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_boletas
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Location = New System.Drawing.Point(391, 444)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(203, 93)
        Me.Button13.TabIndex = 72
        Me.Button13.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ControlDeInventario.My.Resources.Resources.admin
        Me.PictureBox1.Location = New System.Drawing.Point(894, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'Button12
        '
        Me.Button12.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_cerrar_sesion
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(351, 542)
        Me.Button12.Margin = New System.Windows.Forms.Padding(2)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(195, 96)
        Me.Button12.TabIndex = 70
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_clientes
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(106, 444)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(199, 94)
        Me.Button11.TabIndex = 69
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Image = Global.ControlDeInventario.My.Resources.Resources.boton_facsalida
        Me.Button10.Location = New System.Drawing.Point(675, 239)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(219, 98)
        Me.Button10.TabIndex = 68
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_buscardoc
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(685, 345)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(200, 91)
        Me.Button9.TabIndex = 67
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_mermas
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(396, 237)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(198, 96)
        Me.Button7.TabIndex = 65
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Image = Global.ControlDeInventario.My.Resources.Resources.boton_reportes
        Me.Button6.Location = New System.Drawing.Point(685, 444)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(206, 96)
        Me.Button6.TabIndex = 64
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_facturaingre
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(697, 132)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(202, 95)
        Me.Button5.TabIndex = 63
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.Sin_título_3
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(393, 130)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(201, 98)
        Me.Button4.TabIndex = 62
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_usuario
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(106, 343)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(199, 95)
        Me.Button3.TabIndex = 61
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.productos_boton
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(106, 236)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 98)
        Me.Button2.TabIndex = 60
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_proveedor
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(106, 127)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 104)
        Me.Button1.TabIndex = 59
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Navegacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(999, 640)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.PictureBox1)
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
        Me.Controls.Add(Me.permiso)
        Me.Controls.Add(Me.rut)
        Me.Controls.Add(Me.nombre)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Navegacion"
        Me.Text = "Navegacion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents permiso As Label
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
End Class
