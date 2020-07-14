<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class elegir_producto
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
        Me.components = New System.ComponentModel.Container()
        Me.ControlinventarioDataSet = New ControlDeInventario.ControlinventarioDataSet()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New ControlDeInventario.ControlinventarioDataSetTableAdapters.productoTableAdapter()
        Me.TableAdapterManager = New ControlDeInventario.ControlinventarioDataSetTableAdapters.TableAdapterManager()
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ControlinventarioDataSet
        '
        Me.ControlinventarioDataSet.DataSetName = "ControlinventarioDataSet"
        Me.ControlinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.ControlinventarioDataSet
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.productoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.registroTableAdapter = Nothing
        Me.TableAdapterManager.tipousuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ControlDeInventario.ControlinventarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AllowUserToAddRows = False
        Me.ProductoDataGridView.AllowUserToDeleteRows = False
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(41, 87)
        Me.ProductoDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.ReadOnly = True
        Me.ProductoDataGridView.RowHeadersVisible = False
        Me.ProductoDataGridView.Size = New System.Drawing.Size(587, 271)
        Me.ProductoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "cod_producto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "cod_producto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn3.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "tipo_producto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "tipo_producto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_seleccionar
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(209, 366)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(268, 119)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 427)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Buscar:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(267, 37)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(173, 22)
        Me.TextBox1.TabIndex = 5
        '
        'elegir_producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(644, 507)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProductoDataGridView)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "elegir_producto"
        Me.Text = "elegir_producto"
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ControlinventarioDataSet As ControlinventarioDataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As ControlinventarioDataSetTableAdapters.productoTableAdapter
    Friend WithEvents TableAdapterManager As ControlinventarioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
