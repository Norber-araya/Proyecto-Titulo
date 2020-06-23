<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturaVenta
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
        Dim ProductoLabel As System.Windows.Forms.Label
        Dim ProductoLabel1 As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FacturaVenta))
        Me.GestiondeinventarioDataSet = New Gestion_de_inventario.gestiondeinventarioDataSet()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaTableAdapter = New Gestion_de_inventario.gestiondeinventarioDataSetTableAdapters.facturaTableAdapter()
        Me.TableAdapterManager = New Gestion_de_inventario.gestiondeinventarioDataSetTableAdapters.TableAdapterManager()
        Me.ClienteTableAdapter = New Gestion_de_inventario.gestiondeinventarioDataSetTableAdapters.clienteTableAdapter()
        Me.ProductoTableAdapter = New Gestion_de_inventario.gestiondeinventarioDataSetTableAdapters.productoTableAdapter()
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
        Me.Rut_provTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionTextBox = New System.Windows.Forms.TextBox()
        Me.Valor_netoTextBox = New System.Windows.Forms.TextBox()
        Me.IvaTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox1 = New System.Windows.Forms.TextBox()
        Me.FonoTextBox1 = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox1 = New System.Windows.Forms.TextBox()
        Me.ComunaTextBox1 = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox1 = New System.Windows.Forms.TextBox()
        Me.Rut_clienteTextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
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
        ProductoLabel = New System.Windows.Forms.Label()
        ProductoLabel1 = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        CType(Me.GestiondeinventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacturaBindingNavigator.SuspendLayout()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'N_facturaLabel
        '
        N_facturaLabel.AutoSize = True
        N_facturaLabel.Location = New System.Drawing.Point(609, 60)
        N_facturaLabel.Name = "N_facturaLabel"
        N_facturaLabel.Size = New System.Drawing.Size(61, 13)
        N_facturaLabel.TabIndex = 2
        N_facturaLabel.Text = "N° Factura:"
        '
        'Rut_provLabel
        '
        Rut_provLabel.AutoSize = True
        Rut_provLabel.Location = New System.Drawing.Point(609, 34)
        Rut_provLabel.Name = "Rut_provLabel"
        Rut_provLabel.Size = New System.Drawing.Size(39, 13)
        Rut_provLabel.TabIndex = 4
        Rut_provLabel.Text = "R.U.T:"
        '
        'Nombre_provLabel
        '
        Nombre_provLabel.AutoSize = True
        Nombre_provLabel.Location = New System.Drawing.Point(15, 83)
        Nombre_provLabel.Name = "Nombre_provLabel"
        Nombre_provLabel.Size = New System.Drawing.Size(47, 13)
        Nombre_provLabel.TabIndex = 6
        Nombre_provLabel.Text = "Nombre:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(15, 109)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 8
        DireccionLabel.Text = "Direccion:"
        '
        'ComunaLabel
        '
        ComunaLabel.AutoSize = True
        ComunaLabel.Location = New System.Drawing.Point(15, 135)
        ComunaLabel.Name = "ComunaLabel"
        ComunaLabel.Size = New System.Drawing.Size(49, 13)
        ComunaLabel.TabIndex = 10
        ComunaLabel.Text = "Comuna:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(15, 161)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(43, 13)
        CiudadLabel.TabIndex = 12
        CiudadLabel.Text = "Ciudad:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(15, 187)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 14
        EmailLabel.Text = "Email:"
        '
        'FonoLabel
        '
        FonoLabel.AutoSize = True
        FonoLabel.Location = New System.Drawing.Point(15, 213)
        FonoLabel.Name = "FonoLabel"
        FonoLabel.Size = New System.Drawing.Size(34, 13)
        FonoLabel.TabIndex = 16
        FonoLabel.Text = "Fono:"
        '
        'Rut_clienteLabel
        '
        Rut_clienteLabel.AutoSize = True
        Rut_clienteLabel.Location = New System.Drawing.Point(222, 83)
        Rut_clienteLabel.Name = "Rut_clienteLabel"
        Rut_clienteLabel.Size = New System.Drawing.Size(39, 13)
        Rut_clienteLabel.TabIndex = 18
        Rut_clienteLabel.Text = "R.U.T:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(609, 87)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(37, 13)
        FechaLabel.TabIndex = 20
        FechaLabel.Text = "fecha:"
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.Location = New System.Drawing.Point(15, 239)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(68, 13)
        ObservacionLabel.TabIndex = 22
        ObservacionLabel.Text = "observacion:"
        '
        'Valor_netoLabel
        '
        Valor_netoLabel.AutoSize = True
        Valor_netoLabel.Location = New System.Drawing.Point(554, 480)
        Valor_netoLabel.Name = "Valor_netoLabel"
        Valor_netoLabel.Size = New System.Drawing.Size(57, 13)
        Valor_netoLabel.TabIndex = 24
        Valor_netoLabel.Text = "valor neto:"
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Location = New System.Drawing.Point(554, 506)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(24, 13)
        IvaLabel.TabIndex = 26
        IvaLabel.Text = "iva:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(554, 532)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(30, 13)
        TotalLabel.TabIndex = 28
        TotalLabel.Text = "total:"
        '
        'ProductoLabel
        '
        ProductoLabel.AutoSize = True
        ProductoLabel.Location = New System.Drawing.Point(20, 316)
        ProductoLabel.Name = "ProductoLabel"
        ProductoLabel.Size = New System.Drawing.Size(52, 13)
        ProductoLabel.TabIndex = 70
        ProductoLabel.Text = "producto:"
        '
        'ProductoLabel1
        '
        ProductoLabel1.AutoSize = True
        ProductoLabel1.Location = New System.Drawing.Point(20, 347)
        ProductoLabel1.Name = "ProductoLabel1"
        ProductoLabel1.Size = New System.Drawing.Size(52, 13)
        ProductoLabel1.TabIndex = 71
        ProductoLabel1.Text = "producto:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(31, 373)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(39, 13)
        PrecioLabel.TabIndex = 72
        PrecioLabel.Text = "precio:"
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
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.detalle_facTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Me.FacturaTableAdapter
        Me.TableAdapterManager.productoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.registroTableAdapter = Nothing
        Me.TableAdapterManager.tipousuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gestion_de_inventario.gestiondeinventarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'FacturaBindingNavigator
        '
        Me.FacturaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FacturaBindingNavigator.BindingSource = Me.FacturaBindingSource
        Me.FacturaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FacturaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FacturaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FacturaBindingNavigatorSaveItem})
        Me.FacturaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FacturaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FacturaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FacturaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FacturaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FacturaBindingNavigator.Name = "FacturaBindingNavigator"
        Me.FacturaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FacturaBindingNavigator.Size = New System.Drawing.Size(804, 25)
        Me.FacturaBindingNavigator.TabIndex = 0
        Me.FacturaBindingNavigator.Text = "BindingNavigator1"
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
        'FacturaBindingNavigatorSaveItem
        '
        Me.FacturaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FacturaBindingNavigatorSaveItem.Image = CType(resources.GetObject("FacturaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FacturaBindingNavigatorSaveItem.Name = "FacturaBindingNavigatorSaveItem"
        Me.FacturaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FacturaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FacturaDataGridView
        '
        Me.FacturaDataGridView.AutoGenerateColumns = False
        Me.FacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.FacturaDataGridView.DataSource = Me.FacturaBindingSource
        Me.FacturaDataGridView.Location = New System.Drawing.Point(340, 110)
        Me.FacturaDataGridView.Name = "FacturaDataGridView"
        Me.FacturaDataGridView.Size = New System.Drawing.Size(303, 120)
        Me.FacturaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "n_factura"
        Me.DataGridViewTextBoxColumn1.HeaderText = "n_factura"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "rut_prov"
        Me.DataGridViewTextBoxColumn2.HeaderText = "rut_prov"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nombre_prov"
        Me.DataGridViewTextBoxColumn3.HeaderText = "nombre_prov"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "comuna"
        Me.DataGridViewTextBoxColumn5.HeaderText = "comuna"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ciudad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ciudad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn7.HeaderText = "email"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "fono"
        Me.DataGridViewTextBoxColumn8.HeaderText = "fono"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "rut_cliente"
        Me.DataGridViewTextBoxColumn9.HeaderText = "rut_cliente"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn10.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "observacion"
        Me.DataGridViewTextBoxColumn11.HeaderText = "observacion"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "valor_neto"
        Me.DataGridViewTextBoxColumn12.HeaderText = "valor_neto"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "iva"
        Me.DataGridViewTextBoxColumn13.HeaderText = "iva"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "total"
        Me.DataGridViewTextBoxColumn14.HeaderText = "total"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'N_facturaTextBox
        '
        Me.N_facturaTextBox.Location = New System.Drawing.Point(684, 57)
        Me.N_facturaTextBox.Name = "N_facturaTextBox"
        Me.N_facturaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.N_facturaTextBox.TabIndex = 3
        '
        'Rut_provTextBox
        '
        Me.Rut_provTextBox.Location = New System.Drawing.Point(684, 31)
        Me.Rut_provTextBox.Name = "Rut_provTextBox"
        Me.Rut_provTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Rut_provTextBox.TabIndex = 5
        '
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.Location = New System.Drawing.Point(90, 236)
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ObservacionTextBox.TabIndex = 23
        '
        'Valor_netoTextBox
        '
        Me.Valor_netoTextBox.Location = New System.Drawing.Point(629, 477)
        Me.Valor_netoTextBox.Name = "Valor_netoTextBox"
        Me.Valor_netoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Valor_netoTextBox.TabIndex = 25
        '
        'IvaTextBox
        '
        Me.IvaTextBox.Location = New System.Drawing.Point(629, 503)
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IvaTextBox.TabIndex = 27
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(629, 529)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 29
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.GestiondeinventarioDataSet
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(90, 80)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 33
        '
        'EmailTextBox1
        '
        Me.EmailTextBox1.Location = New System.Drawing.Point(90, 184)
        Me.EmailTextBox1.Name = "EmailTextBox1"
        Me.EmailTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox1.TabIndex = 35
        '
        'FonoTextBox1
        '
        Me.FonoTextBox1.Location = New System.Drawing.Point(90, 210)
        Me.FonoTextBox1.Name = "FonoTextBox1"
        Me.FonoTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.FonoTextBox1.TabIndex = 37
        '
        'DireccionTextBox1
        '
        Me.DireccionTextBox1.Location = New System.Drawing.Point(90, 106)
        Me.DireccionTextBox1.Name = "DireccionTextBox1"
        Me.DireccionTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox1.TabIndex = 39
        '
        'ComunaTextBox1
        '
        Me.ComunaTextBox1.Location = New System.Drawing.Point(90, 132)
        Me.ComunaTextBox1.Name = "ComunaTextBox1"
        Me.ComunaTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.ComunaTextBox1.TabIndex = 41
        '
        'CiudadTextBox1
        '
        Me.CiudadTextBox1.Location = New System.Drawing.Point(90, 158)
        Me.CiudadTextBox1.Name = "CiudadTextBox1"
        Me.CiudadTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.CiudadTextBox1.TabIndex = 43
        '
        'Rut_clienteTextBox1
        '
        Me.Rut_clienteTextBox1.Location = New System.Drawing.Point(281, 80)
        Me.Rut_clienteTextBox1.Name = "Rut_clienteTextBox1"
        Me.Rut_clienteTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Rut_clienteTextBox1.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.buscar)
        Me.Panel1.Controls.Add(Me.ClienteDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(217, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(426, 279)
        Me.Panel1.TabIndex = 44
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(170, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Seleccionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "buscar"
        '
        'buscar
        '
        Me.buscar.Location = New System.Drawing.Point(145, 18)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(100, 20)
        Me.buscar.TabIndex = 1
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AllowUserToAddRows = False
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(56, 63)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.Size = New System.Drawing.Size(320, 160)
        Me.ClienteDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "rut_cliente"
        Me.DataGridViewTextBoxColumn15.HeaderText = "rut_cliente"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn16.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn17.HeaderText = "email"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "fono"
        Me.DataGridViewTextBoxColumn18.HeaderText = "fono"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn19.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "comuna"
        Me.DataGridViewTextBoxColumn20.HeaderText = "comuna"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "ciudad"
        Me.DataGridViewTextBoxColumn21.HeaderText = "ciudad"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(393, 80)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(33, 20)
        Me.Button3.TabIndex = 65
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(206, 313)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(547, 150)
        Me.DataGridView1.TabIndex = 66
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(75, 516)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 69
        Me.Button2.Text = "crear factura"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'eliminar
        '
        Me.eliminar.Location = New System.Drawing.Point(76, 481)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(75, 23)
        Me.eliminar.TabIndex = 68
        Me.eliminar.Text = "eliminar"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(76, 449)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 67
        Me.Button4.Text = "agregar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.ProductoBindingSource
        Me.ComboBox2.DisplayMember = "cod_producto"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(78, 313)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox2.TabIndex = 71
        Me.ComboBox2.ValueMember = "cod_producto"
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.GestiondeinventarioDataSet
        '
        'ProductoTextBox
        '
        Me.ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "producto", True))
        Me.ProductoTextBox.Location = New System.Drawing.Point(78, 344)
        Me.ProductoTextBox.Name = "ProductoTextBox"
        Me.ProductoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProductoTextBox.TabIndex = 72
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(76, 370)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrecioTextBox.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "cantidad:"
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(76, 398)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(100, 20)
        Me.cantidad.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "cantidad", True))
        Me.Label3.Location = New System.Drawing.Point(102, 421)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "cantidad"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(684, 83)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(91, 20)
        Me.DateTimePicker1.TabIndex = 77
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(18, 550)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 78
        Me.Button5.Text = "menu"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'FacturaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 585)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(ProductoLabel1)
        Me.Controls.Add(Me.ProductoTextBox)
        Me.Controls.Add(ProductoLabel)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.eliminar)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Rut_clienteTextBox1)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.EmailTextBox1)
        Me.Controls.Add(Me.FonoTextBox1)
        Me.Controls.Add(Me.DireccionTextBox1)
        Me.Controls.Add(Me.ComunaTextBox1)
        Me.Controls.Add(Me.CiudadTextBox1)
        Me.Controls.Add(N_facturaLabel)
        Me.Controls.Add(Me.N_facturaTextBox)
        Me.Controls.Add(Rut_provLabel)
        Me.Controls.Add(Me.Rut_provTextBox)
        Me.Controls.Add(Nombre_provLabel)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(ComunaLabel)
        Me.Controls.Add(CiudadLabel)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(FonoLabel)
        Me.Controls.Add(Rut_clienteLabel)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(ObservacionLabel)
        Me.Controls.Add(Me.ObservacionTextBox)
        Me.Controls.Add(Valor_netoLabel)
        Me.Controls.Add(Me.Valor_netoTextBox)
        Me.Controls.Add(IvaLabel)
        Me.Controls.Add(Me.IvaTextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.FacturaDataGridView)
        Me.Controls.Add(Me.FacturaBindingNavigator)
        Me.Controls.Add(Me.Button3)
        Me.Name = "FacturaVenta"
        Me.Text = "FacturaVenta"
        CType(Me.GestiondeinventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacturaBindingNavigator.ResumeLayout(False)
        Me.FacturaBindingNavigator.PerformLayout()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Rut_provTextBox As TextBox
    Friend WithEvents ObservacionTextBox As TextBox
    Friend WithEvents Valor_netoTextBox As TextBox
    Friend WithEvents IvaTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents ClienteTableAdapter As gestiondeinventarioDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents EmailTextBox1 As TextBox
    Friend WithEvents FonoTextBox1 As TextBox
    Friend WithEvents DireccionTextBox1 As TextBox
    Friend WithEvents ComunaTextBox1 As TextBox
    Friend WithEvents CiudadTextBox1 As TextBox
    Friend WithEvents Rut_clienteTextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents buscar As TextBox
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ProductoTableAdapter As gestiondeinventarioDataSetTableAdapters.productoTableAdapter
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button5 As Button
End Class
