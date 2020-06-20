<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Factura
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
        Dim N_facturaLabel As System.Windows.Forms.Label
        Dim Nombre_provLabel As System.Windows.Forms.Label
        Dim Rut_clienteLabel As System.Windows.Forms.Label
        Dim ObservacionLabel As System.Windows.Forms.Label
        Dim Valor_netoLabel As System.Windows.Forms.Label
        Dim IvaLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim Rut_provLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ComunaLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim FonoLabel As System.Windows.Forms.Label
        Dim ProductoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Factura))
        Me.GestiondeinventarioDataSet = New Gestion_de_inventario.gestiondeinventarioDataSet()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaTableAdapter = New Gestion_de_inventario.gestiondeinventarioDataSetTableAdapters.facturaTableAdapter()
        Me.TableAdapterManager = New Gestion_de_inventario.gestiondeinventarioDataSetTableAdapters.TableAdapterManager()
        Me.FacturaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FacturaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FacturaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.N_facturaTextBox = New System.Windows.Forms.TextBox()
        Me.Rut_clienteTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProductoTableAdapter = New Gestion_de_inventario.gestiondeinventarioDataSetTableAdapters.productoTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New Gestion_de_inventario.gestiondeinventarioDataSetTableAdapters.proveedorTableAdapter()
        Me.Rut_provTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.ComunaTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.FonoTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.precio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.neto = New System.Windows.Forms.TextBox()
        Me.impuesto = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        N_facturaLabel = New System.Windows.Forms.Label()
        Nombre_provLabel = New System.Windows.Forms.Label()
        Rut_clienteLabel = New System.Windows.Forms.Label()
        ObservacionLabel = New System.Windows.Forms.Label()
        Valor_netoLabel = New System.Windows.Forms.Label()
        IvaLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        Rut_provLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ComunaLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        FonoLabel = New System.Windows.Forms.Label()
        ProductoLabel = New System.Windows.Forms.Label()
        CType(Me.GestiondeinventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacturaBindingNavigator.SuspendLayout()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'N_facturaLabel
        '
        N_facturaLabel.AutoSize = True
        N_facturaLabel.Location = New System.Drawing.Point(537, 37)
        N_facturaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        N_facturaLabel.Name = "N_facturaLabel"
        N_facturaLabel.Size = New System.Drawing.Size(52, 13)
        N_facturaLabel.TabIndex = 2
        N_facturaLabel.Text = "n factura:"
        AddHandler N_facturaLabel.Click, AddressOf Me.N_facturaLabel_Click
        '
        'Nombre_provLabel
        '
        Nombre_provLabel.AutoSize = True
        Nombre_provLabel.Location = New System.Drawing.Point(42, 35)
        Nombre_provLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Nombre_provLabel.Name = "Nombre_provLabel"
        Nombre_provLabel.Size = New System.Drawing.Size(69, 13)
        Nombre_provLabel.TabIndex = 6
        Nombre_provLabel.Text = "nombre prov:"
        '
        'Rut_clienteLabel
        '
        Rut_clienteLabel.AutoSize = True
        Rut_clienteLabel.Location = New System.Drawing.Point(42, 176)
        Rut_clienteLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Rut_clienteLabel.Name = "Rut_clienteLabel"
        Rut_clienteLabel.Size = New System.Drawing.Size(56, 13)
        Rut_clienteLabel.TabIndex = 18
        Rut_clienteLabel.Text = "rut cliente:"
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.Location = New System.Drawing.Point(42, 198)
        ObservacionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(68, 13)
        ObservacionLabel.TabIndex = 22
        ObservacionLabel.Text = "observacion:"
        '
        'Valor_netoLabel
        '
        Valor_netoLabel.AutoSize = True
        Valor_netoLabel.Location = New System.Drawing.Point(509, 485)
        Valor_netoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Valor_netoLabel.Name = "Valor_netoLabel"
        Valor_netoLabel.Size = New System.Drawing.Size(57, 13)
        Valor_netoLabel.TabIndex = 24
        Valor_netoLabel.Text = "valor neto:"
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Location = New System.Drawing.Point(509, 510)
        IvaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(24, 13)
        IvaLabel.TabIndex = 26
        IvaLabel.Text = "iva:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(509, 533)
        TotalLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(30, 13)
        TotalLabel.TabIndex = 28
        TotalLabel.Text = "total:"
        '
        'Rut_provLabel
        '
        Rut_provLabel.AutoSize = True
        Rut_provLabel.Location = New System.Drawing.Point(538, 12)
        Rut_provLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Rut_provLabel.Name = "Rut_provLabel"
        Rut_provLabel.Size = New System.Drawing.Size(46, 13)
        Rut_provLabel.TabIndex = 34
        Rut_provLabel.Text = "rut prov:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(42, 62)
        DireccionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(53, 13)
        DireccionLabel.TabIndex = 38
        DireccionLabel.Text = "direccion:"
        '
        'ComunaLabel
        '
        ComunaLabel.AutoSize = True
        ComunaLabel.Location = New System.Drawing.Point(42, 85)
        ComunaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ComunaLabel.Name = "ComunaLabel"
        ComunaLabel.Size = New System.Drawing.Size(48, 13)
        ComunaLabel.TabIndex = 40
        ComunaLabel.Text = "comuna:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(42, 107)
        CiudadLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(42, 13)
        CiudadLabel.TabIndex = 42
        CiudadLabel.Text = "ciudad:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(42, 130)
        EmailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 44
        EmailLabel.Text = "email:"
        '
        'FonoLabel
        '
        FonoLabel.AutoSize = True
        FonoLabel.Location = New System.Drawing.Point(42, 153)
        FonoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FonoLabel.Name = "FonoLabel"
        FonoLabel.Size = New System.Drawing.Size(31, 13)
        FonoLabel.TabIndex = 46
        FonoLabel.Text = "fono:"
        '
        'ProductoLabel
        '
        ProductoLabel.AutoSize = True
        ProductoLabel.Location = New System.Drawing.Point(34, 323)
        ProductoLabel.Name = "ProductoLabel"
        ProductoLabel.Size = New System.Drawing.Size(52, 13)
        ProductoLabel.TabIndex = 48
        ProductoLabel.Text = "producto:"
        AddHandler ProductoLabel.Click, AddressOf Me.ProductoLabel_Click
        '
        'GestiondeinventarioDataSet
        '
        Me.GestiondeinventarioDataSet.DataSetName = "gestiondeinventarioDataSet"
        Me.GestiondeinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Me.FacturaTableAdapter
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.registroTableAdapter = Nothing
        Me.TableAdapterManager.tipousuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gestion_de_inventario.gestiondeinventarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        '
        'FacturaBindingNavigator
        '
        Me.FacturaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FacturaBindingNavigator.BindingSource = Me.FacturaBindingSource
        Me.FacturaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FacturaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FacturaBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FacturaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FacturaBindingNavigatorSaveItem})
        Me.FacturaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FacturaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FacturaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FacturaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FacturaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FacturaBindingNavigator.Name = "FacturaBindingNavigator"
        Me.FacturaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FacturaBindingNavigator.Size = New System.Drawing.Size(716, 22)
        Me.FacturaBindingNavigator.TabIndex = 0
        Me.FacturaBindingNavigator.Text = "BindingNavigator1"
        Me.FacturaBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 19)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 22)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 22)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 22)
        '
        'FacturaBindingNavigatorSaveItem
        '
        Me.FacturaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FacturaBindingNavigatorSaveItem.Image = CType(resources.GetObject("FacturaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FacturaBindingNavigatorSaveItem.Name = "FacturaBindingNavigatorSaveItem"
        Me.FacturaBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 19)
        Me.FacturaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FacturaDataGridView
        '
        Me.FacturaDataGridView.AllowUserToAddRows = False
        Me.FacturaDataGridView.AllowUserToDeleteRows = False
        Me.FacturaDataGridView.AutoGenerateColumns = False
        Me.FacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.FacturaDataGridView.DataSource = Me.FacturaBindingSource
        Me.FacturaDataGridView.Location = New System.Drawing.Point(225, 59)
        Me.FacturaDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.FacturaDataGridView.Name = "FacturaDataGridView"
        Me.FacturaDataGridView.ReadOnly = True
        Me.FacturaDataGridView.RowHeadersVisible = False
        Me.FacturaDataGridView.RowTemplate.Height = 24
        Me.FacturaDataGridView.Size = New System.Drawing.Size(359, 140)
        Me.FacturaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "n_factura"
        Me.DataGridViewTextBoxColumn1.HeaderText = "n_factura"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "rut_prov"
        Me.DataGridViewTextBoxColumn2.HeaderText = "rut_prov"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombre_prov"
        Me.DataGridViewTextBoxColumn3.HeaderText = "nombre_prov"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "comuna"
        Me.DataGridViewTextBoxColumn5.HeaderText = "comuna"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ciudad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ciudad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn7.HeaderText = "email"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "fono"
        Me.DataGridViewTextBoxColumn8.HeaderText = "fono"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "rut_cliente"
        Me.DataGridViewTextBoxColumn9.HeaderText = "rut_cliente"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn10.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "observacion"
        Me.DataGridViewTextBoxColumn11.HeaderText = "observacion"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "valor_neto"
        Me.DataGridViewTextBoxColumn12.HeaderText = "valor_neto"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "iva"
        Me.DataGridViewTextBoxColumn13.HeaderText = "iva"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "total"
        Me.DataGridViewTextBoxColumn14.HeaderText = "total"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'N_facturaTextBox
        '
        Me.N_facturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "n_factura", True))
        Me.N_facturaTextBox.Location = New System.Drawing.Point(611, 34)
        Me.N_facturaTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.N_facturaTextBox.Name = "N_facturaTextBox"
        Me.N_facturaTextBox.Size = New System.Drawing.Size(76, 20)
        Me.N_facturaTextBox.TabIndex = 3
        '
        'Rut_clienteTextBox
        '
        Me.Rut_clienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "rut_cliente", True))
        Me.Rut_clienteTextBox.Location = New System.Drawing.Point(116, 173)
        Me.Rut_clienteTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Rut_clienteTextBox.Name = "Rut_clienteTextBox"
        Me.Rut_clienteTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Rut_clienteTextBox.TabIndex = 19
        '
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "observacion", True))
        Me.ObservacionTextBox.Location = New System.Drawing.Point(116, 196)
        Me.ObservacionTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(76, 20)
        Me.ObservacionTextBox.TabIndex = 23
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(599, 62)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker1.TabIndex = 31
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.GestiondeinventarioDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Label2"
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ProveedorBindingSource
        Me.ComboBox1.DisplayMember = "nombre_prov"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(116, 33)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(76, 21)
        Me.ComboBox1.TabIndex = 34
        Me.ComboBox1.ValueMember = "nombre_prov"
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "proveedor"
        Me.ProveedorBindingSource.DataSource = Me.GestiondeinventarioDataSet
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'Rut_provTextBox
        '
        Me.Rut_provTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "rut_prov", True))
        Me.Rut_provTextBox.Location = New System.Drawing.Point(611, 10)
        Me.Rut_provTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Rut_provTextBox.Name = "Rut_provTextBox"
        Me.Rut_provTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Rut_provTextBox.TabIndex = 35
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(116, 59)
        Me.DireccionTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(76, 20)
        Me.DireccionTextBox.TabIndex = 39
        '
        'ComunaTextBox
        '
        Me.ComunaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "comuna", True))
        Me.ComunaTextBox.Location = New System.Drawing.Point(116, 82)
        Me.ComunaTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ComunaTextBox.Name = "ComunaTextBox"
        Me.ComunaTextBox.Size = New System.Drawing.Size(76, 20)
        Me.ComunaTextBox.TabIndex = 41
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "ciudad", True))
        Me.CiudadTextBox.Location = New System.Drawing.Point(116, 105)
        Me.CiudadTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(76, 20)
        Me.CiudadTextBox.TabIndex = 43
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(116, 128)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(76, 20)
        Me.EmailTextBox.TabIndex = 45
        '
        'FonoTextBox
        '
        Me.FonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "fono", True))
        Me.FonoTextBox.Location = New System.Drawing.Point(116, 150)
        Me.FonoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FonoTextBox.Name = "FonoTextBox"
        Me.FonoTextBox.Size = New System.Drawing.Size(76, 20)
        Me.FonoTextBox.TabIndex = 47
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.ProductoBindingSource
        Me.ComboBox2.DisplayMember = "cod_producto"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(92, 320)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox2.TabIndex = 48
        Me.ComboBox2.ValueMember = "cod_producto"
        '
        'ProductoTextBox
        '
        Me.ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "producto", True))
        Me.ProductoTextBox.Location = New System.Drawing.Point(92, 347)
        Me.ProductoTextBox.Name = "ProductoTextBox"
        Me.ProductoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProductoTextBox.TabIndex = 49
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(225, 294)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(500, 150)
        Me.DataGridView1.TabIndex = 50
        '
        'Column1
        '
        Me.Column1.HeaderText = "codigo"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "descripcion"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "cantidad"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "precio unitario"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "total"
        Me.Column5.Name = "Column5"
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(91, 373)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(100, 20)
        Me.cantidad.TabIndex = 51
        '
        'precio
        '
        Me.precio.Location = New System.Drawing.Point(91, 399)
        Me.precio.Name = "precio"
        Me.precio.Size = New System.Drawing.Size(100, 20)
        Me.precio.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "cantidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 402)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "precio unitario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 354)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "nombre:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(92, 456)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "agregar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'neto
        '
        Me.neto.Location = New System.Drawing.Point(571, 482)
        Me.neto.Name = "neto"
        Me.neto.Size = New System.Drawing.Size(100, 20)
        Me.neto.TabIndex = 57
        '
        'impuesto
        '
        Me.impuesto.Location = New System.Drawing.Point(571, 507)
        Me.impuesto.Name = "impuesto"
        Me.impuesto.Size = New System.Drawing.Size(100, 20)
        Me.impuesto.TabIndex = 58
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(571, 534)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 20)
        Me.total.TabIndex = 59
        '
        'eliminar
        '
        Me.eliminar.Location = New System.Drawing.Point(92, 488)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(75, 23)
        Me.eliminar.TabIndex = 60
        Me.eliminar.Text = "eliminar"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(91, 523)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "crear factura"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "cantidad", True))
        Me.Label5.Location = New System.Drawing.Point(113, 431)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Tag = ""
        Me.Label5.Text = "Label5"
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 598)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.eliminar)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.impuesto)
        Me.Controls.Add(Me.neto)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.precio)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(ProductoLabel)
        Me.Controls.Add(Me.ProductoTextBox)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Rut_provLabel)
        Me.Controls.Add(Me.Rut_provTextBox)
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
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(N_facturaLabel)
        Me.Controls.Add(Me.N_facturaTextBox)
        Me.Controls.Add(Nombre_provLabel)
        Me.Controls.Add(Rut_clienteLabel)
        Me.Controls.Add(Me.Rut_clienteTextBox)
        Me.Controls.Add(ObservacionLabel)
        Me.Controls.Add(Me.ObservacionTextBox)
        Me.Controls.Add(Valor_netoLabel)
        Me.Controls.Add(IvaLabel)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.FacturaDataGridView)
        Me.Controls.Add(Me.FacturaBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Factura"
        Me.Text = "Factura"
        CType(Me.GestiondeinventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacturaBindingNavigator.ResumeLayout(False)
        Me.FacturaBindingNavigator.PerformLayout()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GestiondeinventarioDataSet As gestiondeinventarioDataSet
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents FacturaTableAdapter As gestiondeinventarioDataSetTableAdapters.facturaTableAdapter
    Friend WithEvents TableAdapterManager As gestiondeinventarioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FacturaBindingNavigator As BindingNavigator
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
    Friend WithEvents FacturaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FacturaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents N_facturaTextBox As TextBox
    Friend WithEvents Rut_clienteTextBox As TextBox
    Friend WithEvents ObservacionTextBox As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As gestiondeinventarioDataSetTableAdapters.productoTableAdapter
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As gestiondeinventarioDataSetTableAdapters.proveedorTableAdapter
    Friend WithEvents Rut_provTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents ComunaTextBox As TextBox
    Friend WithEvents CiudadTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents FonoTextBox As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ProductoTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As TextBox
    Friend WithEvents precio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents neto As TextBox
    Friend WithEvents impuesto As TextBox
    Friend WithEvents total As TextBox
    Friend WithEvents eliminar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
End Class
