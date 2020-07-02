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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RutTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ContactoTextBox = New System.Windows.Forms.TextBox()
        Me.GeneroTextBox = New System.Windows.Forms.TextBox()
        Me.ContraseñaTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.TipousuarioTableAdapter = New ControlDeInventario.ControlinventarioDataSetTableAdapters.tipousuarioTableAdapter()
        Me.tipo1 = New System.Windows.Forms.Label()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New ControlDeInventario.ControlinventarioDataSetTableAdapters.usuarioTableAdapter()
        Me.TableAdapterManager = New ControlDeInventario.ControlinventarioDataSetTableAdapters.TableAdapterManager()
        Me.UsuarioDataGridView = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.UsuarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RutLabel
        '
        RutLabel.AutoSize = True
        RutLabel.Location = New System.Drawing.Point(65, 86)
        RutLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        RutLabel.Name = "RutLabel"
        RutLabel.Size = New System.Drawing.Size(22, 13)
        RutLabel.TabIndex = 28
        RutLabel.Text = "rut:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(65, 109)
        NombreLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 30
        NombreLabel.Text = "nombre:"
        '
        'ContactoLabel
        '
        ContactoLabel.AutoSize = True
        ContactoLabel.Location = New System.Drawing.Point(65, 132)
        ContactoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ContactoLabel.Name = "ContactoLabel"
        ContactoLabel.Size = New System.Drawing.Size(52, 13)
        ContactoLabel.TabIndex = 32
        ContactoLabel.Text = "contacto:"
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.Location = New System.Drawing.Point(65, 155)
        GeneroLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(43, 13)
        GeneroLabel.TabIndex = 34
        GeneroLabel.Text = "genero:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Location = New System.Drawing.Point(65, 230)
        ContraseñaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(63, 13)
        ContraseñaLabel.TabIndex = 36
        ContraseñaLabel.Text = "contraseña:"
        '
        'Id_tipousuarioLabel
        '
        Id_tipousuarioLabel.AutoSize = True
        Id_tipousuarioLabel.Location = New System.Drawing.Point(65, 204)
        Id_tipousuarioLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Id_tipousuarioLabel.Name = "Id_tipousuarioLabel"
        Id_tipousuarioLabel.Size = New System.Drawing.Size(72, 13)
        Id_tipousuarioLabel.TabIndex = 38
        Id_tipousuarioLabel.Text = "id tipousuario:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(65, 179)
        EmailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 39
        EmailLabel.Text = "email:"
        '
        'confirmar
        '
        Me.confirmar.Location = New System.Drawing.Point(142, 255)
        Me.confirmar.MaxLength = 16
        Me.confirmar.Name = "confirmar"
        Me.confirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmar.Size = New System.Drawing.Size(76, 20)
        Me.confirmar.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "confirmar contraseña:"
        '
        'tipousuario
        '
        Me.tipousuario.DataSource = Me.TipousuarioBindingSource
        Me.tipousuario.DisplayMember = "permiso"
        Me.tipousuario.FormattingEnabled = True
        Me.tipousuario.Location = New System.Drawing.Point(142, 204)
        Me.tipousuario.Name = "tipousuario"
        Me.tipousuario.Size = New System.Drawing.Size(76, 21)
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 24)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "C.R.U.D Usuarios"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(102, 361)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 31)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(154, 318)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 31)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Editar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(57, 318)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 31)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Crear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RutTextBox
        '
        Me.RutTextBox.Location = New System.Drawing.Point(142, 86)
        Me.RutTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.RutTextBox.Name = "RutTextBox"
        Me.RutTextBox.Size = New System.Drawing.Size(76, 20)
        Me.RutTextBox.TabIndex = 29
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Location = New System.Drawing.Point(142, 109)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(76, 20)
        Me.NombreTextBox.TabIndex = 31
        '
        'ContactoTextBox
        '
        Me.ContactoTextBox.Location = New System.Drawing.Point(142, 132)
        Me.ContactoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ContactoTextBox.Name = "ContactoTextBox"
        Me.ContactoTextBox.Size = New System.Drawing.Size(76, 20)
        Me.ContactoTextBox.TabIndex = 33
        '
        'GeneroTextBox
        '
        Me.GeneroTextBox.Location = New System.Drawing.Point(142, 155)
        Me.GeneroTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.GeneroTextBox.Name = "GeneroTextBox"
        Me.GeneroTextBox.Size = New System.Drawing.Size(76, 20)
        Me.GeneroTextBox.TabIndex = 35
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(142, 230)
        Me.ContraseñaTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ContraseñaTextBox.MaxLength = 16
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(76, 20)
        Me.ContraseñaTextBox.TabIndex = 37
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(142, 179)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(76, 20)
        Me.EmailTextBox.TabIndex = 40
        '
        'TipousuarioTableAdapter
        '
        Me.TipousuarioTableAdapter.ClearBeforeFill = True
        '
        'tipo1
        '
        Me.tipo1.AutoSize = True
        Me.tipo1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TipousuarioBindingSource, "id_tipousuario", True))
        Me.tipo1.Location = New System.Drawing.Point(404, 186)
        Me.tipo1.Name = "tipo1"
        Me.tipo1.Size = New System.Drawing.Size(39, 13)
        Me.tipo1.TabIndex = 48
        Me.tipo1.Text = "Label3"
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
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.detalle_facTableAdapter = Nothing
        Me.TableAdapterManager.detalle_proveedorTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Nothing
        Me.TableAdapterManager.mermasTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.registroTableAdapter = Nothing
        Me.TableAdapterManager.tipousuarioTableAdapter = Me.TipousuarioTableAdapter
        Me.TableAdapterManager.UpdateOrder = ControlDeInventario.ControlinventarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Me.UsuarioTableAdapter
        '
        'UsuarioDataGridView
        '
        Me.UsuarioDataGridView.AllowUserToAddRows = False
        Me.UsuarioDataGridView.AllowUserToDeleteRows = False
        Me.UsuarioDataGridView.AutoGenerateColumns = False
        Me.UsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.UsuarioDataGridView.DataSource = Me.UsuarioBindingSource
        Me.UsuarioDataGridView.Location = New System.Drawing.Point(266, 64)
        Me.UsuarioDataGridView.Name = "UsuarioDataGridView"
        Me.UsuarioDataGridView.RowHeadersVisible = False
        Me.UsuarioDataGridView.Size = New System.Drawing.Size(503, 220)
        Me.UsuarioDataGridView.TabIndex = 48
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "eliminar"
        Me.eliminar.Name = "eliminar"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "rut"
        Me.DataGridViewTextBoxColumn1.HeaderText = "rut"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "contacto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "contacto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "genero"
        Me.DataGridViewTextBoxColumn4.HeaderText = "genero"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "contraseña"
        Me.DataGridViewTextBoxColumn5.HeaderText = "contraseña"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "id_tipousuario"
        Me.DataGridViewTextBoxColumn6.HeaderText = "id_tipousuario"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn7.HeaderText = "email"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 546)
        Me.Controls.Add(Me.UsuarioDataGridView)
        Me.Controls.Add(Me.tipo1)
        Me.Controls.Add(Me.confirmar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tipousuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(RutLabel)
        Me.Controls.Add(Me.RutTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ContactoLabel)
        Me.Controls.Add(Me.ContactoTextBox)
        Me.Controls.Add(GeneroLabel)
        Me.Controls.Add(Me.GeneroTextBox)
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
        CType(Me.UsuarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents confirmar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tipousuario As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents RutTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ContactoTextBox As TextBox
    Friend WithEvents GeneroTextBox As TextBox
    Friend WithEvents ContraseñaTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents ControlinventarioDataSet As ControlinventarioDataSet
    Friend WithEvents TipousuarioBindingSource As BindingSource
    Friend WithEvents TipousuarioTableAdapter As ControlinventarioDataSetTableAdapters.tipousuarioTableAdapter
    Friend WithEvents tipo1 As Label
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As ControlinventarioDataSetTableAdapters.usuarioTableAdapter
    Friend WithEvents TableAdapterManager As ControlinventarioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuarioDataGridView As DataGridView
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
