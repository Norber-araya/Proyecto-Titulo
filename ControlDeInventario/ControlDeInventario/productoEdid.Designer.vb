<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productoEdid
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
        Dim Cod_productoLabel As System.Windows.Forms.Label
        Dim ProductoLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ControlinventarioDataSet = New ControlDeInventario.ControlinventarioDataSet()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New ControlDeInventario.ControlinventarioDataSetTableAdapters.productoTableAdapter()
        Me.TableAdapterManager = New ControlDeInventario.ControlinventarioDataSetTableAdapters.TableAdapterManager()
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cod_productoTextBox = New System.Windows.Forms.TextBox()
        Me.ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Cod_productoLabel = New System.Windows.Forms.Label()
        ProductoLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_productoLabel
        '
        Cod_productoLabel.AutoSize = True
        Cod_productoLabel.Location = New System.Drawing.Point(529, 68)
        Cod_productoLabel.Name = "Cod_productoLabel"
        Cod_productoLabel.Size = New System.Drawing.Size(87, 13)
        Cod_productoLabel.TabIndex = 4
        Cod_productoLabel.Text = "codigo producto:"
        '
        'ProductoLabel
        '
        ProductoLabel.AutoSize = True
        ProductoLabel.Location = New System.Drawing.Point(529, 94)
        ProductoLabel.Name = "ProductoLabel"
        ProductoLabel.Size = New System.Drawing.Size(52, 13)
        ProductoLabel.TabIndex = 6
        ProductoLabel.Text = "producto:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(529, 120)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(51, 13)
        CantidadLabel.TabIndex = 8
        CantidadLabel.Text = "cantidad:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(529, 146)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(39, 13)
        PrecioLabel.TabIndex = 10
        PrecioLabel.Text = "precio:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(212, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(163, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar:"
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
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.detalle_facTableAdapter = Nothing
        Me.TableAdapterManager.detalle_proveedorTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Nothing
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
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(52, 65)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.ReadOnly = True
        Me.ProductoDataGridView.Size = New System.Drawing.Size(441, 220)
        Me.ProductoDataGridView.TabIndex = 3
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "producto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "producto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn4.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Cod_productoTextBox
        '
        Me.Cod_productoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "cod_producto", True))
        Me.Cod_productoTextBox.Location = New System.Drawing.Point(622, 65)
        Me.Cod_productoTextBox.Name = "Cod_productoTextBox"
        Me.Cod_productoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cod_productoTextBox.TabIndex = 5
        '
        'ProductoTextBox
        '
        Me.ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "producto", True))
        Me.ProductoTextBox.Location = New System.Drawing.Point(622, 91)
        Me.ProductoTextBox.Name = "ProductoTextBox"
        Me.ProductoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProductoTextBox.TabIndex = 7
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(622, 117)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CantidadTextBox.TabIndex = 9
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(622, 143)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioTextBox.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(224, 301)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Seleccionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 346)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(622, 188)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Guardar cambios"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'productoEdid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 390)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Cod_productoLabel)
        Me.Controls.Add(Me.Cod_productoTextBox)
        Me.Controls.Add(ProductoLabel)
        Me.Controls.Add(Me.ProductoTextBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(Me.ProductoDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "productoEdid"
        Me.Text = "productoEdid"
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ControlinventarioDataSet As ControlinventarioDataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As ControlinventarioDataSetTableAdapters.productoTableAdapter
    Friend WithEvents TableAdapterManager As ControlinventarioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Cod_productoTextBox As TextBox
    Friend WithEvents ProductoTextBox As TextBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
