<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proveedor
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
        Dim Rut_provLabel As System.Windows.Forms.Label
        Dim Nombre_provLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ComunaLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim FonoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(proveedor))
        Me.Rut_provTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_provTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.ComunaTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.FonoTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ControlinventarioDataSet = New ControlDeInventario.ControlinventarioDataSet()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New ControlDeInventario.ControlinventarioDataSetTableAdapters.TableAdapterManager()
        Me.ProveedorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ProveedorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProveedorTableAdapter = New ControlDeInventario.ControlinventarioDataSetTableAdapters.proveedorTableAdapter()
        Me.ProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Rut_provLabel = New System.Windows.Forms.Label()
        Nombre_provLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ComunaLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        FonoLabel = New System.Windows.Forms.Label()
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProveedorBindingNavigator.SuspendLayout()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Rut_provLabel
        '
        Rut_provLabel.AutoSize = True
        Rut_provLabel.Location = New System.Drawing.Point(50, 80)
        Rut_provLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Rut_provLabel.Name = "Rut_provLabel"
        Rut_provLabel.Size = New System.Drawing.Size(46, 13)
        Rut_provLabel.TabIndex = 16
        Rut_provLabel.Text = "rut prov:"
        '
        'Nombre_provLabel
        '
        Nombre_provLabel.AutoSize = True
        Nombre_provLabel.Location = New System.Drawing.Point(50, 103)
        Nombre_provLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Nombre_provLabel.Name = "Nombre_provLabel"
        Nombre_provLabel.Size = New System.Drawing.Size(69, 13)
        Nombre_provLabel.TabIndex = 18
        Nombre_provLabel.Text = "nombre prov:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(50, 126)
        DireccionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(53, 13)
        DireccionLabel.TabIndex = 20
        DireccionLabel.Text = "direccion:"
        '
        'ComunaLabel
        '
        ComunaLabel.AutoSize = True
        ComunaLabel.Location = New System.Drawing.Point(50, 149)
        ComunaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ComunaLabel.Name = "ComunaLabel"
        ComunaLabel.Size = New System.Drawing.Size(48, 13)
        ComunaLabel.TabIndex = 22
        ComunaLabel.Text = "comuna:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(50, 171)
        CiudadLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(42, 13)
        CiudadLabel.TabIndex = 24
        CiudadLabel.Text = "ciudad:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(50, 194)
        EmailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 26
        EmailLabel.Text = "email:"
        '
        'FonoLabel
        '
        FonoLabel.AutoSize = True
        FonoLabel.Location = New System.Drawing.Point(50, 217)
        FonoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FonoLabel.Name = "FonoLabel"
        FonoLabel.Size = New System.Drawing.Size(31, 13)
        FonoLabel.TabIndex = 28
        FonoLabel.Text = "fono:"
        '
        'Rut_provTextBox
        '
        Me.Rut_provTextBox.Location = New System.Drawing.Point(124, 78)
        Me.Rut_provTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Rut_provTextBox.Name = "Rut_provTextBox"
        Me.Rut_provTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Rut_provTextBox.TabIndex = 17
        '
        'Nombre_provTextBox
        '
        Me.Nombre_provTextBox.Location = New System.Drawing.Point(124, 101)
        Me.Nombre_provTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Nombre_provTextBox.Name = "Nombre_provTextBox"
        Me.Nombre_provTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Nombre_provTextBox.TabIndex = 19
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.Location = New System.Drawing.Point(124, 124)
        Me.DireccionTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(76, 20)
        Me.DireccionTextBox.TabIndex = 21
        '
        'ComunaTextBox
        '
        Me.ComunaTextBox.Location = New System.Drawing.Point(124, 146)
        Me.ComunaTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ComunaTextBox.Name = "ComunaTextBox"
        Me.ComunaTextBox.Size = New System.Drawing.Size(76, 20)
        Me.ComunaTextBox.TabIndex = 23
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.Location = New System.Drawing.Point(124, 169)
        Me.CiudadTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(76, 20)
        Me.CiudadTextBox.TabIndex = 25
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(124, 192)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(76, 20)
        Me.EmailTextBox.TabIndex = 27
        '
        'FonoTextBox
        '
        Me.FonoTextBox.Location = New System.Drawing.Point(124, 214)
        Me.FonoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FonoTextBox.Name = "FonoTextBox"
        Me.FonoTextBox.Size = New System.Drawing.Size(76, 20)
        Me.FonoTextBox.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(334, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 24)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Proveedor"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(60, 365)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "Menu"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(159, 328)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 27)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(159, 286)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 27)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Editar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(53, 286)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 27)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Crear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ControlinventarioDataSet
        '
        Me.ControlinventarioDataSet.DataSetName = "ControlinventarioDataSet"
        Me.ControlinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "proveedor"
        Me.ProveedorBindingSource.DataSource = Me.ControlinventarioDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.detalle_facTableAdapter = Nothing
        Me.TableAdapterManager.detalle_proveedorTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Nothing
        Me.TableAdapterManager.mermasTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.registroTableAdapter = Nothing
        Me.TableAdapterManager.tipousuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ControlDeInventario.ControlinventarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        '
        'ProveedorBindingNavigator
        '
        Me.ProveedorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProveedorBindingNavigator.BindingSource = Me.ProveedorBindingSource
        Me.ProveedorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProveedorBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProveedorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProveedorBindingNavigatorSaveItem})
        Me.ProveedorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProveedorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProveedorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProveedorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProveedorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProveedorBindingNavigator.Name = "ProveedorBindingNavigator"
        Me.ProveedorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProveedorBindingNavigator.Size = New System.Drawing.Size(892, 25)
        Me.ProveedorBindingNavigator.TabIndex = 35
        Me.ProveedorBindingNavigator.Text = "BindingNavigator1"
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
        'ProveedorBindingNavigatorSaveItem
        '
        Me.ProveedorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProveedorBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProveedorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProveedorBindingNavigatorSaveItem.Name = "ProveedorBindingNavigatorSaveItem"
        Me.ProveedorBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProveedorBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'ProveedorDataGridView
        '
        Me.ProveedorDataGridView.AllowUserToAddRows = False
        Me.ProveedorDataGridView.AllowUserToDeleteRows = False
        Me.ProveedorDataGridView.AutoGenerateColumns = False
        Me.ProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eliminar, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ProveedorDataGridView.DataSource = Me.ProveedorBindingSource
        Me.ProveedorDataGridView.Location = New System.Drawing.Point(308, 80)
        Me.ProveedorDataGridView.Name = "ProveedorDataGridView"
        Me.ProveedorDataGridView.RowHeadersVisible = False
        Me.ProveedorDataGridView.Size = New System.Drawing.Size(475, 220)
        Me.ProveedorDataGridView.TabIndex = 35
        '
        'eliminar
        '
        Me.eliminar.HeaderText = "eliminar"
        Me.eliminar.Name = "eliminar"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "rut_prov"
        Me.DataGridViewTextBoxColumn1.HeaderText = "rut_prov"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre_prov"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre_prov"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "comuna"
        Me.DataGridViewTextBoxColumn4.HeaderText = "comuna"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ciudad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ciudad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn6.HeaderText = "email"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "fono"
        Me.DataGridViewTextBoxColumn7.HeaderText = "fono"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 450)
        Me.Controls.Add(Me.ProveedorDataGridView)
        Me.Controls.Add(Me.ProveedorBindingNavigator)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Rut_provLabel)
        Me.Controls.Add(Me.Rut_provTextBox)
        Me.Controls.Add(Nombre_provLabel)
        Me.Controls.Add(Me.Nombre_provTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(ComunaLabel)
        Me.Controls.Add(Me.ComunaTextBox)
        Me.Controls.Add(CiudadLabel)
        Me.Controls.Add(Me.CiudadTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(FonoLabel)
        Me.Controls.Add(Me.FonoTextBox)
        Me.Name = "proveedor"
        Me.Text = "proveedor"
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProveedorBindingNavigator.ResumeLayout(False)
        Me.ProveedorBindingNavigator.PerformLayout()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Rut_provTextBox As TextBox
    Friend WithEvents Nombre_provTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents ComunaTextBox As TextBox
    Friend WithEvents CiudadTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents FonoTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ControlinventarioDataSet As ControlinventarioDataSet
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As ControlinventarioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProveedorBindingNavigator As BindingNavigator
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
    Friend WithEvents ProveedorBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProveedorTableAdapter As ControlinventarioDataSetTableAdapters.proveedorTableAdapter
    Friend WithEvents ProveedorDataGridView As DataGridView
    Friend WithEvents eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
