<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mermas
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
        Dim NombreLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mermas))
        Me.ControlinventarioDataSet = New ControlDeInventario.ControlinventarioDataSet()
        Me.MermasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New ControlDeInventario.ControlinventarioDataSetTableAdapters.TableAdapterManager()
        Me.MermasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MermasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Cod_productoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New ControlDeInventario.ControlinventarioDataSetTableAdapters.productoTableAdapter()
        Me.MermasTableAdapter = New ControlDeInventario.ControlinventarioDataSetTableAdapters.mermasTableAdapter()
        Me.MermasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Cod_productoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MermasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MermasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MermasBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MermasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cod_productoLabel
        '
        Cod_productoLabel.AutoSize = True
        Cod_productoLabel.Location = New System.Drawing.Point(19, 85)
        Cod_productoLabel.Name = "Cod_productoLabel"
        Cod_productoLabel.Size = New System.Drawing.Size(73, 13)
        Cod_productoLabel.TabIndex = 4
        Cod_productoLabel.Text = "cod producto:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(19, 111)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(45, 13)
        NombreLabel.TabIndex = 6
        NombreLabel.Text = "nombre:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(19, 137)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(51, 13)
        CantidadLabel.TabIndex = 8
        CantidadLabel.Text = "cantidad:"
        '
        'ControlinventarioDataSet
        '
        Me.ControlinventarioDataSet.DataSetName = "ControlinventarioDataSet"
        Me.ControlinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MermasBindingSource
        '
        Me.MermasBindingSource.DataMember = "mermas"
        Me.MermasBindingSource.DataSource = Me.ControlinventarioDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.detalle_facTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Nothing
        Me.TableAdapterManager.mermasTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.registroTableAdapter = Nothing
        Me.TableAdapterManager.tipousuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ControlDeInventario.ControlinventarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        '
        'MermasBindingNavigator
        '
        Me.MermasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MermasBindingNavigator.BindingSource = Me.MermasBindingSource
        Me.MermasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MermasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MermasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MermasBindingNavigatorSaveItem})
        Me.MermasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MermasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MermasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MermasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MermasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MermasBindingNavigator.Name = "MermasBindingNavigator"
        Me.MermasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MermasBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.MermasBindingNavigator.TabIndex = 0
        Me.MermasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MermasBindingNavigatorSaveItem
        '
        Me.MermasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MermasBindingNavigatorSaveItem.Image = CType(resources.GetObject("MermasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MermasBindingNavigatorSaveItem.Name = "MermasBindingNavigatorSaveItem"
        Me.MermasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MermasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Cod_productoTextBox
        '
        Me.Cod_productoTextBox.Location = New System.Drawing.Point(98, 82)
        Me.Cod_productoTextBox.Name = "Cod_productoTextBox"
        Me.Cod_productoTextBox.Size = New System.Drawing.Size(92, 20)
        Me.Cod_productoTextBox.TabIndex = 5
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Location = New System.Drawing.Point(98, 108)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(92, 20)
        Me.NombreTextBox.TabIndex = 7
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.Location = New System.Drawing.Point(98, 134)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(92, 20)
        Me.CantidadTextBox.TabIndex = 9
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(655, 28)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(104, 20)
        Me.FechaDateTimePicker.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(196, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.ProductoDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(244, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(416, 319)
        Me.Panel1.TabIndex = 14
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(162, 277)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Seleccionar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(151, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AllowUserToAddRows = False
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(35, 62)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.Size = New System.Drawing.Size(344, 193)
        Me.ProductoDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "cod_producto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "cod_producto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "producto"
        Me.DataGridViewTextBoxColumn7.HeaderText = "producto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn8.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn9.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
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
        'MermasTableAdapter
        '
        Me.MermasTableAdapter.ClearBeforeFill = True
        '
        'MermasDataGridView
        '
        Me.MermasDataGridView.AllowUserToAddRows = False
        Me.MermasDataGridView.AllowUserToDeleteRows = False
        Me.MermasDataGridView.AutoGenerateColumns = False
        Me.MermasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MermasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.MermasDataGridView.DataSource = Me.MermasBindingSource
        Me.MermasDataGridView.Location = New System.Drawing.Point(244, 76)
        Me.MermasDataGridView.Name = "MermasDataGridView"
        Me.MermasDataGridView.ReadOnly = True
        Me.MermasDataGridView.Size = New System.Drawing.Size(504, 158)
        Me.MermasDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_mermas"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_mermas"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "cod_producto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "cod_producto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn5.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Label2"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(136, 211)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "eliminar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(38, 420)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Menu"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'mermas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 471)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Cod_productoLabel)
        Me.Controls.Add(Me.Cod_productoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.MermasBindingNavigator)
        Me.Controls.Add(Me.MermasDataGridView)
        Me.Name = "mermas"
        Me.Text = "mermas"
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MermasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MermasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MermasBindingNavigator.ResumeLayout(False)
        Me.MermasBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MermasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ControlinventarioDataSet As ControlinventarioDataSet
    Friend WithEvents MermasBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As ControlinventarioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MermasBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents MermasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Cod_productoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As ControlinventarioDataSetTableAdapters.productoTableAdapter
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ProductoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents MermasTableAdapter As ControlinventarioDataSetTableAdapters.mermasTableAdapter
    Friend WithEvents MermasDataGridView As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
