<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usuario
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
        Me.components = New System.ComponentModel.Container()
        Dim RutLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ContactoLabel As System.Windows.Forms.Label
        Dim GeneroLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim Id_tipousuarioLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Me.confirmar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tipousuario = New System.Windows.Forms.ComboBox()
        Me.TipousuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ControlinventarioDataSet = New ControlDeInventario.ControlinventarioDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RutTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ContactoTextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.TipousuarioTableAdapter = New ControlDeInventario.ControlinventarioDataSetTableAdapters.tipousuarioTableAdapter()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New ControlDeInventario.ControlinventarioDataSetTableAdapters.usuarioTableAdapter()
        Me.TableAdapterManager = New ControlDeInventario.ControlinventarioDataSetTableAdapters.TableAdapterManager()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tipo1 = New System.Windows.Forms.Label()
        Me.GeneroBox1 = New System.Windows.Forms.ComboBox()
        RutLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ContactoLabel = New System.Windows.Forms.Label()
        GeneroLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        Id_tipousuarioLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.TipousuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RutLabel
        '
        RutLabel.AutoSize = True
        RutLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RutLabel.Location = New System.Drawing.Point(88, 70)
        RutLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        RutLabel.Name = "RutLabel"
        RutLabel.Size = New System.Drawing.Size(51, 17)
        RutLabel.TabIndex = 28
        RutLabel.Text = "Usuario"
        AddHandler RutLabel.Click, AddressOf Me.RutLabel_Click
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(87, 93)
        NombreLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(51, 17)
        NombreLabel.TabIndex = 30
        NombreLabel.Text = "Nombre"
        '
        'ContactoLabel
        '
        ContactoLabel.AutoSize = True
        ContactoLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactoLabel.Location = New System.Drawing.Point(88, 116)
        ContactoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ContactoLabel.Name = "ContactoLabel"
        ContactoLabel.Size = New System.Drawing.Size(57, 17)
        ContactoLabel.TabIndex = 32
        ContactoLabel.Text = "Contacto"
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GeneroLabel.Location = New System.Drawing.Point(87, 139)
        GeneroLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(48, 17)
        GeneroLabel.TabIndex = 34
        GeneroLabel.Text = "Genero"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContraseñaLabel.Location = New System.Drawing.Point(87, 214)
        ContraseñaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(72, 17)
        ContraseñaLabel.TabIndex = 36
        ContraseñaLabel.Text = "Contraseña"
        '
        'Id_tipousuarioLabel
        '
        Id_tipousuarioLabel.AutoSize = True
        Id_tipousuarioLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_tipousuarioLabel.Location = New System.Drawing.Point(87, 188)
        Id_tipousuarioLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Id_tipousuarioLabel.Name = "Id_tipousuarioLabel"
        Id_tipousuarioLabel.Size = New System.Drawing.Size(93, 17)
        Id_tipousuarioLabel.TabIndex = 38
        Id_tipousuarioLabel.Text = "Tipo de usuario"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(86, 163)
        EmailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(38, 17)
        EmailLabel.TabIndex = 39
        EmailLabel.Text = "Email"
        '
        'confirmar
        '
        Me.confirmar.Location = New System.Drawing.Point(217, 239)
        Me.confirmar.MaxLength = 16
        Me.confirmar.Name = "confirmar"
        Me.confirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmar.Size = New System.Drawing.Size(100, 20)
        Me.confirmar.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 17)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Confirmar contraseña"
        '
        'tipousuario
        '
        Me.tipousuario.DataSource = Me.TipousuarioBindingSource
        Me.tipousuario.DisplayMember = "permiso"
        Me.tipousuario.FormattingEnabled = True
        Me.tipousuario.Location = New System.Drawing.Point(217, 188)
        Me.tipousuario.Name = "tipousuario"
        Me.tipousuario.Size = New System.Drawing.Size(100, 21)
        Me.tipousuario.TabIndex = 45
        Me.tipousuario.ValueMember = "permiso"
        '
        'TipousuarioBindingSource
        '
        Me.TipousuarioBindingSource.DataMember = "tipousuario"
        Me.TipousuarioBindingSource.DataSource = Me.ControlinventarioDataSet
        '
        'ControlinventarioDataSet
        '
        Me.ControlinventarioDataSet.DataSetName = "ControlinventarioDataSet"
        Me.ControlinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 39)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Usuarios"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.ControlDeInventario.My.Resources.Resources.boton_registro
        Me.Button1.Location = New System.Drawing.Point(-2, 280)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(208, 94)
        Me.Button1.TabIndex = 41
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RutTextBox
        '
        Me.RutTextBox.Location = New System.Drawing.Point(217, 70)
        Me.RutTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.RutTextBox.Name = "RutTextBox"
        Me.RutTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RutTextBox.TabIndex = 29
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Location = New System.Drawing.Point(217, 93)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 31
        '
        'ContactoTextBox
        '
        Me.ContactoTextBox.Location = New System.Drawing.Point(217, 116)
        Me.ContactoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ContactoTextBox.Name = "ContactoTextBox"
        Me.ContactoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContactoTextBox.TabIndex = 33
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(217, 214)
        Me.ContraseñaTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ContraseñaTextBox.MaxLength = 16
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContraseñaTextBox.TabIndex = 37
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(217, 163)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 40
        '
        'TipousuarioTableAdapter
        '
        Me.TipousuarioTableAdapter.ClearBeforeFill = True
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "usuario"
        Me.UsuarioBindingSource.DataSource = Me.ControlinventarioDataSet
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.boletaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.detalle_boletaTableAdapter = Nothing
        Me.TableAdapterManager.detalle_fac_egresoTableAdapter = Nothing
        Me.TableAdapterManager.detalle_fac_ingresoTableAdapter = Nothing
        Me.TableAdapterManager.detalle_guiaTableAdapter = Nothing
        Me.TableAdapterManager.detalle_proveedorTableAdapter = Nothing
        Me.TableAdapterManager.factura_egresoTableAdapter = Nothing
        Me.TableAdapterManager.factura_ingresoTableAdapter = Nothing
        Me.TableAdapterManager.guia_despachoTableAdapter = Nothing
        Me.TableAdapterManager.mermasTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.registroTableAdapter = Nothing
        Me.TableAdapterManager.tipousuarioTableAdapter = Me.TipousuarioTableAdapter
        Me.TableAdapterManager.UpdateOrder = ControlDeInventario.ControlinventarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Me.UsuarioTableAdapter
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_menu
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(102, 370)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(200, 95)
        Me.Button4.TabIndex = 49
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_listarusuario
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(231, 279)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 95)
        Me.Button2.TabIndex = 42
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tipo1
        '
        Me.tipo1.AutoSize = True
        Me.tipo1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipousuarioBindingSource, "id_tipousuario", True))
        Me.tipo1.Location = New System.Drawing.Point(251, 191)
        Me.tipo1.Name = "tipo1"
        Me.tipo1.Size = New System.Drawing.Size(39, 13)
        Me.tipo1.TabIndex = 48
        Me.tipo1.Text = "Label3"
        '
        'GeneroBox1
        '
        Me.GeneroBox1.FormattingEnabled = True
        Me.GeneroBox1.Items.AddRange(New Object() {"Masculino", "Femenino", "otro"})
        Me.GeneroBox1.Location = New System.Drawing.Point(217, 139)
        Me.GeneroBox1.Name = "GeneroBox1"
        Me.GeneroBox1.Size = New System.Drawing.Size(100, 21)
        Me.GeneroBox1.TabIndex = 50
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(464, 469)
        Me.Controls.Add(Me.GeneroBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.tipo1)
        Me.Controls.Add(Me.confirmar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tipousuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(RutLabel)
        Me.Controls.Add(Me.RutTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ContactoLabel)
        Me.Controls.Add(Me.ContactoTextBox)
        Me.Controls.Add(GeneroLabel)
        Me.Controls.Add(ContraseñaLabel)
        Me.Controls.Add(Me.ContraseñaTextBox)
        Me.Controls.Add(Id_tipousuarioLabel)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Name = "Usuario"
        Me.Text = "Usuario"
        CType(Me.TipousuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents confirmar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tipousuario As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RutTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ContactoTextBox As TextBox
    Friend WithEvents ContraseñaTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents ControlinventarioDataSet As ControlinventarioDataSet
    Friend WithEvents TipousuarioBindingSource As BindingSource
    Friend WithEvents TipousuarioTableAdapter As ControlinventarioDataSetTableAdapters.tipousuarioTableAdapter
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As ControlinventarioDataSetTableAdapters.usuarioTableAdapter
    Friend WithEvents TableAdapterManager As ControlinventarioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents tipo1 As Label
    Friend WithEvents GeneroBox1 As ComboBox
End Class
