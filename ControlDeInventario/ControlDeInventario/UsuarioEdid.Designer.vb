﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UsuarioEdid
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
        Dim RutLabel1 As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim ContactoLabel1 As System.Windows.Forms.Label
        Dim GeneroLabel1 As System.Windows.Forms.Label
        Dim EmailLabel1 As System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.RutTextBox1 = New System.Windows.Forms.TextBox()
        Me.NombreTextBox1 = New System.Windows.Forms.TextBox()
        Me.ContactoTextBox1 = New System.Windows.Forms.TextBox()
        Me.GeneroTextBox1 = New System.Windows.Forms.TextBox()
        Me.EmailTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Busqueda = New System.Windows.Forms.TextBox()
        Me.ControlinventarioDataSet = New ControlDeInventario.ControlinventarioDataSet()
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
        Me.Button3 = New System.Windows.Forms.Button()
        RutLabel1 = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        ContactoLabel1 = New System.Windows.Forms.Label()
        GeneroLabel1 = New System.Windows.Forms.Label()
        EmailLabel1 = New System.Windows.Forms.Label()
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RutLabel1
        '
        RutLabel1.AutoSize = True
        RutLabel1.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RutLabel1.Location = New System.Drawing.Point(561, 93)
        RutLabel1.Name = "RutLabel1"
        RutLabel1.Size = New System.Drawing.Size(51, 17)
        RutLabel1.TabIndex = 23
        RutLabel1.Text = "Usuario"
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel1.Location = New System.Drawing.Point(561, 119)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(51, 17)
        NombreLabel1.TabIndex = 25
        NombreLabel1.Text = "Nombre"
        '
        'ContactoLabel1
        '
        ContactoLabel1.AutoSize = True
        ContactoLabel1.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactoLabel1.Location = New System.Drawing.Point(561, 142)
        ContactoLabel1.Name = "ContactoLabel1"
        ContactoLabel1.Size = New System.Drawing.Size(57, 17)
        ContactoLabel1.TabIndex = 27
        ContactoLabel1.Text = "Contacto"
        '
        'GeneroLabel1
        '
        GeneroLabel1.AutoSize = True
        GeneroLabel1.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GeneroLabel1.Location = New System.Drawing.Point(561, 168)
        GeneroLabel1.Name = "GeneroLabel1"
        GeneroLabel1.Size = New System.Drawing.Size(48, 17)
        GeneroLabel1.TabIndex = 29
        GeneroLabel1.Text = "Genero"
        '
        'EmailLabel1
        '
        EmailLabel1.AutoSize = True
        EmailLabel1.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel1.Location = New System.Drawing.Point(561, 194)
        EmailLabel1.Name = "EmailLabel1"
        EmailLabel1.Size = New System.Drawing.Size(38, 17)
        EmailLabel1.TabIndex = 31
        EmailLabel1.Text = "Email"
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_volver
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(-3, 362)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(195, 80)
        Me.Button6.TabIndex = 35
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.ControlDeInventario.My.Resources.Resources.boton_actualizar
        Me.Button5.Location = New System.Drawing.Point(536, 220)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(230, 90)
        Me.Button5.TabIndex = 34
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_seleccionar
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(245, 246)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(201, 91)
        Me.Button4.TabIndex = 33
        Me.Button4.UseVisualStyleBackColor = True
        '
        'RutTextBox1
        '
        Me.RutTextBox1.Location = New System.Drawing.Point(618, 90)
        Me.RutTextBox1.Name = "RutTextBox1"
        Me.RutTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.RutTextBox1.TabIndex = 24
        '
        'NombreTextBox1
        '
        Me.NombreTextBox1.Location = New System.Drawing.Point(618, 116)
        Me.NombreTextBox1.Name = "NombreTextBox1"
        Me.NombreTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox1.TabIndex = 26
        '
        'ContactoTextBox1
        '
        Me.ContactoTextBox1.Location = New System.Drawing.Point(618, 142)
        Me.ContactoTextBox1.Name = "ContactoTextBox1"
        Me.ContactoTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.ContactoTextBox1.TabIndex = 28
        '
        'GeneroTextBox1
        '
        Me.GeneroTextBox1.Location = New System.Drawing.Point(618, 168)
        Me.GeneroTextBox1.Name = "GeneroTextBox1"
        Me.GeneroTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.GeneroTextBox1.TabIndex = 30
        '
        'EmailTextBox1
        '
        Me.EmailTextBox1.Location = New System.Drawing.Point(618, 194)
        Me.EmailTextBox1.Name = "EmailTextBox1"
        Me.EmailTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox1.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(155, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Buscar"
        '
        'Busqueda
        '
        Me.Busqueda.Location = New System.Drawing.Point(228, 35)
        Me.Busqueda.Name = "Busqueda"
        Me.Busqueda.Size = New System.Drawing.Size(131, 20)
        Me.Busqueda.TabIndex = 21
        '
        'ControlinventarioDataSet
        '
        Me.ControlinventarioDataSet.DataSetName = "ControlinventarioDataSet"
        Me.ControlinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.tipousuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ControlDeInventario.ControlinventarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Me.UsuarioTableAdapter
        '
        'UsuarioDataGridView
        '
        Me.UsuarioDataGridView.AllowUserToAddRows = False
        Me.UsuarioDataGridView.AllowUserToDeleteRows = False
        Me.UsuarioDataGridView.AutoGenerateColumns = False
        Me.UsuarioDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.UsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuarioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.UsuarioDataGridView.DataSource = Me.UsuarioBindingSource
        Me.UsuarioDataGridView.Location = New System.Drawing.Point(17, 93)
        Me.UsuarioDataGridView.Name = "UsuarioDataGridView"
        Me.UsuarioDataGridView.RowHeadersVisible = False
        Me.UsuarioDataGridView.Size = New System.Drawing.Size(494, 151)
        Me.UsuarioDataGridView.TabIndex = 36
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "Eliminar"
        Me.eliminar.Name = "eliminar"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "rut"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Usuario"
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
        'Button3
        '
        Me.Button3.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_eliminar
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(11, 246)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 97)
        Me.Button3.TabIndex = 44
        Me.Button3.UseVisualStyleBackColor = True
        '
        'UsuarioEdid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(793, 442)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.UsuarioDataGridView)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(RutLabel1)
        Me.Controls.Add(Me.RutTextBox1)
        Me.Controls.Add(NombreLabel1)
        Me.Controls.Add(Me.NombreTextBox1)
        Me.Controls.Add(ContactoLabel1)
        Me.Controls.Add(Me.ContactoTextBox1)
        Me.Controls.Add(GeneroLabel1)
        Me.Controls.Add(Me.GeneroTextBox1)
        Me.Controls.Add(EmailLabel1)
        Me.Controls.Add(Me.EmailTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Busqueda)
        Me.Name = "UsuarioEdid"
        Me.Text = "UsuarioEdid"
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents RutTextBox1 As TextBox
    Friend WithEvents NombreTextBox1 As TextBox
    Friend WithEvents ContactoTextBox1 As TextBox
    Friend WithEvents GeneroTextBox1 As TextBox
    Friend WithEvents EmailTextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Busqueda As TextBox
    Friend WithEvents ControlinventarioDataSet As ControlinventarioDataSet
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As ControlinventarioDataSetTableAdapters.usuarioTableAdapter
    Friend WithEvents TableAdapterManager As ControlinventarioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsuarioDataGridView As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
