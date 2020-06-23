<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Verfactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Verfactura))
        Dim N_facturaLabel As System.Windows.Forms.Label
        Dim Rut_provLabel As System.Windows.Forms.Label
        Dim Nombre_provLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ComunaLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim FonoLabel As System.Windows.Forms.Label
        Dim Rut_clienteLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim ObservacionLabel As System.Windows.Forms.Label
        Dim Valor_netoLabel As System.Windows.Forms.Label
        Dim IvaLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Me.GestiondeinventarioDataSet = New Gestion_de_inventario.gestiondeinventarioDataSet()
        Me.Detalle_facBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Detalle_facTableAdapter = New Gestion_de_inventario.gestiondeinventarioDataSetTableAdapters.detalle_facTableAdapter()
        Me.TableAdapterManager = New Gestion_de_inventario.gestiondeinventarioDataSetTableAdapters.TableAdapterManager()
        Me.Detalle_facBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Detalle_facBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Detalle_facDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaTableAdapter = New Gestion_de_inventario.gestiondeinventarioDataSetTableAdapters.facturaTableAdapter()
        Me.N_facturaTextBox = New System.Windows.Forms.TextBox()
        Me.Rut_provTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_provTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.ComunaTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.FonoTextBox = New System.Windows.Forms.TextBox()
        Me.Rut_clienteTextBox = New System.Windows.Forms.TextBox()
        Me.FechaTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionTextBox = New System.Windows.Forms.TextBox()
        Me.Valor_netoTextBox = New System.Windows.Forms.TextBox()
        Me.IvaTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        N_facturaLabel = New System.Windows.Forms.Label()
        Rut_provLabel = New System.Windows.Forms.Label()
        Nombre_provLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ComunaLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        FonoLabel = New System.Windows.Forms.Label()
        Rut_clienteLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        ObservacionLabel = New System.Windows.Forms.Label()
        Valor_netoLabel = New System.Windows.Forms.Label()
        IvaLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CType(Me.GestiondeinventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalle_facBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalle_facBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Detalle_facBindingNavigator.SuspendLayout()
        CType(Me.Detalle_facDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GestiondeinventarioDataSet
        '
        Me.GestiondeinventarioDataSet.DataSetName = "gestiondeinventarioDataSet"
        Me.GestiondeinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Detalle_facBindingSource
        '
        Me.Detalle_facBindingSource.DataMember = "detalle_fac"
        Me.Detalle_facBindingSource.DataSource = Me.GestiondeinventarioDataSet
        '
        'Detalle_facTableAdapter
        '
        Me.Detalle_facTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.detalle_facTableAdapter = Me.Detalle_facTableAdapter
        Me.TableAdapterManager.facturaTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.registroTableAdapter = Nothing
        Me.TableAdapterManager.tipousuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gestion_de_inventario.gestiondeinventarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        '
        'Detalle_facBindingNavigator
        '
        Me.Detalle_facBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Detalle_facBindingNavigator.BindingSource = Me.Detalle_facBindingSource
        Me.Detalle_facBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Detalle_facBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Detalle_facBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Detalle_facBindingNavigatorSaveItem})
        Me.Detalle_facBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Detalle_facBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Detalle_facBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Detalle_facBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Detalle_facBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Detalle_facBindingNavigator.Name = "Detalle_facBindingNavigator"
        Me.Detalle_facBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Detalle_facBindingNavigator.Size = New System.Drawing.Size(824, 25)
        Me.Detalle_facBindingNavigator.TabIndex = 0
        Me.Detalle_facBindingNavigator.Text = "BindingNavigator1"
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
        'Detalle_facBindingNavigatorSaveItem
        '
        Me.Detalle_facBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Detalle_facBindingNavigatorSaveItem.Image = CType(resources.GetObject("Detalle_facBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Detalle_facBindingNavigatorSaveItem.Name = "Detalle_facBindingNavigatorSaveItem"
        Me.Detalle_facBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Detalle_facBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Detalle_facDataGridView
        '
        Me.Detalle_facDataGridView.AutoGenerateColumns = False
        Me.Detalle_facDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Detalle_facDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Detalle_facDataGridView.DataSource = Me.Detalle_facBindingSource
        Me.Detalle_facDataGridView.Location = New System.Drawing.Point(100, 206)
        Me.Detalle_facDataGridView.Name = "Detalle_facDataGridView"
        Me.Detalle_facDataGridView.Size = New System.Drawing.Size(645, 196)
        Me.Detalle_facDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "n_factura"
        Me.DataGridViewTextBoxColumn1.HeaderText = "n_factura"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "cod_producto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "cod_producto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "precio_unitario"
        Me.DataGridViewTextBoxColumn5.HeaderText = "precio_unitario"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "total"
        Me.DataGridViewTextBoxColumn6.HeaderText = "total"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "factura"
        Me.FacturaBindingSource.DataSource = Me.GestiondeinventarioDataSet
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'N_facturaLabel
        '
        N_facturaLabel.AutoSize = True
        N_facturaLabel.Location = New System.Drawing.Point(615, 51)
        N_facturaLabel.Name = "N_facturaLabel"
        N_facturaLabel.Size = New System.Drawing.Size(58, 13)
        N_facturaLabel.TabIndex = 2
        N_facturaLabel.Text = "N° factura:"
        AddHandler N_facturaLabel.Click, AddressOf Me.N_facturaLabel_Click
        '
        'N_facturaTextBox
        '
        Me.N_facturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "n_factura", True))
        Me.N_facturaTextBox.Location = New System.Drawing.Point(690, 48)
        Me.N_facturaTextBox.Name = "N_facturaTextBox"
        Me.N_facturaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.N_facturaTextBox.TabIndex = 3
        '
        'Rut_provLabel
        '
        Rut_provLabel.AutoSize = True
        Rut_provLabel.Location = New System.Drawing.Point(615, 25)
        Rut_provLabel.Name = "Rut_provLabel"
        Rut_provLabel.Size = New System.Drawing.Size(36, 13)
        Rut_provLabel.TabIndex = 4
        Rut_provLabel.Text = "R.U.T"
        AddHandler Rut_provLabel.Click, AddressOf Me.Rut_provLabel_Click
        '
        'Rut_provTextBox
        '
        Me.Rut_provTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "rut_prov", True))
        Me.Rut_provTextBox.Location = New System.Drawing.Point(690, 22)
        Me.Rut_provTextBox.Name = "Rut_provTextBox"
        Me.Rut_provTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Rut_provTextBox.TabIndex = 5
        '
        'Nombre_provLabel
        '
        Nombre_provLabel.AutoSize = True
        Nombre_provLabel.Location = New System.Drawing.Point(25, 69)
        Nombre_provLabel.Name = "Nombre_provLabel"
        Nombre_provLabel.Size = New System.Drawing.Size(47, 13)
        Nombre_provLabel.TabIndex = 6
        Nombre_provLabel.Text = "Nombre:"
        AddHandler Nombre_provLabel.Click, AddressOf Me.Nombre_provLabel_Click
        '
        'Nombre_provTextBox
        '
        Me.Nombre_provTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "nombre_prov", True))
        Me.Nombre_provTextBox.Location = New System.Drawing.Point(100, 66)
        Me.Nombre_provTextBox.Name = "Nombre_provTextBox"
        Me.Nombre_provTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_provTextBox.TabIndex = 7
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(25, 121)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(53, 13)
        DireccionLabel.TabIndex = 8
        DireccionLabel.Text = "direccion:"
        AddHandler DireccionLabel.Click, AddressOf Me.DireccionLabel_Click
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(100, 118)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 9
        '
        'ComunaLabel
        '
        ComunaLabel.AutoSize = True
        ComunaLabel.Location = New System.Drawing.Point(234, 121)
        ComunaLabel.Name = "ComunaLabel"
        ComunaLabel.Size = New System.Drawing.Size(48, 13)
        ComunaLabel.TabIndex = 10
        ComunaLabel.Text = "comuna:"
        AddHandler ComunaLabel.Click, AddressOf Me.ComunaLabel_Click
        '
        'ComunaTextBox
        '
        Me.ComunaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "comuna", True))
        Me.ComunaTextBox.Location = New System.Drawing.Point(288, 118)
        Me.ComunaTextBox.Name = "ComunaTextBox"
        Me.ComunaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ComunaTextBox.TabIndex = 11
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(421, 121)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(42, 13)
        CiudadLabel.TabIndex = 12
        CiudadLabel.Text = "ciudad:"
        AddHandler CiudadLabel.Click, AddressOf Me.CiudadLabel_Click
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "ciudad", True))
        Me.CiudadTextBox.Location = New System.Drawing.Point(469, 118)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CiudadTextBox.TabIndex = 13
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(25, 173)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 14
        EmailLabel.Text = "email:"
        AddHandler EmailLabel.Click, AddressOf Me.EmailLabel_Click
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(100, 170)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 15
        '
        'FonoLabel
        '
        FonoLabel.AutoSize = True
        FonoLabel.Location = New System.Drawing.Point(25, 147)
        FonoLabel.Name = "FonoLabel"
        FonoLabel.Size = New System.Drawing.Size(31, 13)
        FonoLabel.TabIndex = 16
        FonoLabel.Text = "fono:"
        AddHandler FonoLabel.Click, AddressOf Me.FonoLabel_Click
        '
        'FonoTextBox
        '
        Me.FonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "fono", True))
        Me.FonoTextBox.Location = New System.Drawing.Point(100, 144)
        Me.FonoTextBox.Name = "FonoTextBox"
        Me.FonoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FonoTextBox.TabIndex = 17
        '
        'Rut_clienteLabel
        '
        Rut_clienteLabel.AutoSize = True
        Rut_clienteLabel.Location = New System.Drawing.Point(25, 92)
        Rut_clienteLabel.Name = "Rut_clienteLabel"
        Rut_clienteLabel.Size = New System.Drawing.Size(36, 13)
        Rut_clienteLabel.TabIndex = 18
        Rut_clienteLabel.Text = "R.U.T"
        AddHandler Rut_clienteLabel.Click, AddressOf Me.Rut_clienteLabel_Click
        '
        'Rut_clienteTextBox
        '
        Me.Rut_clienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "rut_cliente", True))
        Me.Rut_clienteTextBox.Location = New System.Drawing.Point(100, 92)
        Me.Rut_clienteTextBox.Name = "Rut_clienteTextBox"
        Me.Rut_clienteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Rut_clienteTextBox.TabIndex = 19
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(605, 87)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(79, 13)
        FechaLabel.TabIndex = 20
        FechaLabel.Text = "Fecha Emision:"
        AddHandler FechaLabel.Click, AddressOf Me.FechaLabel_Click
        '
        'FechaTextBox
        '
        Me.FechaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "fecha", True))
        Me.FechaTextBox.Location = New System.Drawing.Point(690, 84)
        Me.FechaTextBox.Name = "FechaTextBox"
        Me.FechaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FechaTextBox.TabIndex = 21
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.Location = New System.Drawing.Point(213, 169)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(68, 13)
        ObservacionLabel.TabIndex = 22
        ObservacionLabel.Text = "observacion:"
        AddHandler ObservacionLabel.Click, AddressOf Me.ObservacionLabel_Click
        '
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "observacion", True))
        Me.ObservacionTextBox.Location = New System.Drawing.Point(288, 166)
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ObservacionTextBox.TabIndex = 23
        '
        'Valor_netoLabel
        '
        Valor_netoLabel.AutoSize = True
        Valor_netoLabel.Location = New System.Drawing.Point(570, 418)
        Valor_netoLabel.Name = "Valor_netoLabel"
        Valor_netoLabel.Size = New System.Drawing.Size(57, 13)
        Valor_netoLabel.TabIndex = 24
        Valor_netoLabel.Text = "valor neto:"
        '
        'Valor_netoTextBox
        '
        Me.Valor_netoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "valor_neto", True))
        Me.Valor_netoTextBox.Location = New System.Drawing.Point(645, 415)
        Me.Valor_netoTextBox.Name = "Valor_netoTextBox"
        Me.Valor_netoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Valor_netoTextBox.TabIndex = 25
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Location = New System.Drawing.Point(570, 444)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(24, 13)
        IvaLabel.TabIndex = 26
        IvaLabel.Text = "iva:"
        '
        'IvaTextBox
        '
        Me.IvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "iva", True))
        Me.IvaTextBox.Location = New System.Drawing.Point(645, 441)
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IvaTextBox.TabIndex = 27
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(570, 470)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(30, 13)
        TotalLabel.TabIndex = 28
        TotalLabel.Text = "total:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(645, 467)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(125, 470)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Verfactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 508)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(N_facturaLabel)
        Me.Controls.Add(Me.N_facturaTextBox)
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
        Me.Controls.Add(Rut_clienteLabel)
        Me.Controls.Add(Me.Rut_clienteTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaTextBox)
        Me.Controls.Add(ObservacionLabel)
        Me.Controls.Add(Me.ObservacionTextBox)
        Me.Controls.Add(Valor_netoLabel)
        Me.Controls.Add(Me.Valor_netoTextBox)
        Me.Controls.Add(IvaLabel)
        Me.Controls.Add(Me.IvaTextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.Detalle_facDataGridView)
        Me.Controls.Add(Me.Detalle_facBindingNavigator)
        Me.Name = "Verfactura"
        Me.Text = "Verfactura"
        CType(Me.GestiondeinventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalle_facBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalle_facBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Detalle_facBindingNavigator.ResumeLayout(False)
        Me.Detalle_facBindingNavigator.PerformLayout()
        CType(Me.Detalle_facDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GestiondeinventarioDataSet As gestiondeinventarioDataSet
    Friend WithEvents Detalle_facBindingSource As BindingSource
    Friend WithEvents Detalle_facTableAdapter As gestiondeinventarioDataSetTableAdapters.detalle_facTableAdapter
    Friend WithEvents TableAdapterManager As gestiondeinventarioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Detalle_facBindingNavigator As BindingNavigator
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
    Friend WithEvents Detalle_facBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Detalle_facDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents FacturaTableAdapter As gestiondeinventarioDataSetTableAdapters.facturaTableAdapter
    Friend WithEvents N_facturaTextBox As TextBox
    Friend WithEvents Rut_provTextBox As TextBox
    Friend WithEvents Nombre_provTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents ComunaTextBox As TextBox
    Friend WithEvents CiudadTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents FonoTextBox As TextBox
    Friend WithEvents Rut_clienteTextBox As TextBox
    Friend WithEvents FechaTextBox As TextBox
    Friend WithEvents ObservacionTextBox As TextBox
    Friend WithEvents Valor_netoTextBox As TextBox
    Friend WithEvents IvaTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
