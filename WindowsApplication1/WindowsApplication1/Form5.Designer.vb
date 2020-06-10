<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim DetalleLabel As System.Windows.Forms.Label
        Dim Valor_nLabel As System.Windows.Forms.Label
        Dim Valor_tLabel As System.Windows.Forms.Label
        Dim ObservacionLabel As System.Windows.Forms.Label
        Dim IvaLabel As System.Windows.Forms.Label
        Dim Rut_provLabel As System.Windows.Forms.Label
        Dim Nombre_provLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ContactoLabel As System.Windows.Forms.Label
        Dim ComunaLabel As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim Nombre_prodLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Me.BodegaDataSet = New WindowsApplication1.bodegaDataSet()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaTableAdapter = New WindowsApplication1.bodegaDataSetTableAdapters.facturaTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.bodegaDataSetTableAdapters.TableAdapterManager()
        Me.Detalle_facTableAdapter = New WindowsApplication1.bodegaDataSetTableAdapters.detalle_facTableAdapter()
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
        Me.N_facturaTextBox = New System.Windows.Forms.TextBox()
        Me.DetalleTextBox = New System.Windows.Forms.TextBox()
        Me.Valor_nTextBox = New System.Windows.Forms.TextBox()
        Me.Valor_tTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionTextBox = New System.Windows.Forms.TextBox()
        Me.IvaTextBox = New System.Windows.Forms.TextBox()
        Me.Detalle_facBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New WindowsApplication1.bodegaDataSetTableAdapters.proveedorTableAdapter()
        Me.Rut_provTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_provTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.ContactoTextBox = New System.Windows.Forms.TextBox()
        Me.ComunaTextBox = New System.Windows.Forms.TextBox()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.FacturaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New WindowsApplication1.bodegaDataSetTableAdapters.productosTableAdapter()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_prodTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        N_facturaLabel = New System.Windows.Forms.Label()
        DetalleLabel = New System.Windows.Forms.Label()
        Valor_nLabel = New System.Windows.Forms.Label()
        Valor_tLabel = New System.Windows.Forms.Label()
        ObservacionLabel = New System.Windows.Forms.Label()
        IvaLabel = New System.Windows.Forms.Label()
        Rut_provLabel = New System.Windows.Forms.Label()
        Nombre_provLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ContactoLabel = New System.Windows.Forms.Label()
        ComunaLabel = New System.Windows.Forms.Label()
        MailLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        Nombre_prodLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacturaBindingNavigator.SuspendLayout()
        CType(Me.Detalle_facBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'N_facturaLabel
        '
        N_facturaLabel.AutoSize = True
        N_facturaLabel.Location = New System.Drawing.Point(71, 128)
        N_facturaLabel.Name = "N_facturaLabel"
        N_facturaLabel.Size = New System.Drawing.Size(68, 17)
        N_facturaLabel.TabIndex = 1
        N_facturaLabel.Text = "n factura:"
        '
        'DetalleLabel
        '
        DetalleLabel.AutoSize = True
        DetalleLabel.Location = New System.Drawing.Point(71, 352)
        DetalleLabel.Name = "DetalleLabel"
        DetalleLabel.Size = New System.Drawing.Size(54, 17)
        DetalleLabel.TabIndex = 15
        DetalleLabel.Text = "detalle:"
        '
        'Valor_nLabel
        '
        Valor_nLabel.AutoSize = True
        Valor_nLabel.Location = New System.Drawing.Point(71, 386)
        Valor_nLabel.Name = "Valor_nLabel"
        Valor_nLabel.Size = New System.Drawing.Size(55, 17)
        Valor_nLabel.TabIndex = 19
        Valor_nLabel.Text = "valor n:"
        '
        'Valor_tLabel
        '
        Valor_tLabel.AutoSize = True
        Valor_tLabel.Location = New System.Drawing.Point(71, 414)
        Valor_tLabel.Name = "Valor_tLabel"
        Valor_tLabel.Size = New System.Drawing.Size(51, 17)
        Valor_tLabel.TabIndex = 21
        Valor_tLabel.Text = "valor t:"
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.Location = New System.Drawing.Point(71, 442)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(89, 17)
        ObservacionLabel.TabIndex = 25
        ObservacionLabel.Text = "observacion:"
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Location = New System.Drawing.Point(71, 470)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(30, 17)
        IvaLabel.TabIndex = 27
        IvaLabel.Text = "iva:"
        '
        'Rut_provLabel
        '
        Rut_provLabel.AutoSize = True
        Rut_provLabel.Location = New System.Drawing.Point(71, 156)
        Rut_provLabel.Name = "Rut_provLabel"
        Rut_provLabel.Size = New System.Drawing.Size(61, 17)
        Rut_provLabel.TabIndex = 42
        Rut_provLabel.Text = "rut prov:"
        '
        'Nombre_provLabel
        '
        Nombre_provLabel.AutoSize = True
        Nombre_provLabel.Location = New System.Drawing.Point(71, 184)
        Nombre_provLabel.Name = "Nombre_provLabel"
        Nombre_provLabel.Size = New System.Drawing.Size(92, 17)
        Nombre_provLabel.TabIndex = 44
        Nombre_provLabel.Text = "nombre prov:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(71, 212)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(69, 17)
        DireccionLabel.TabIndex = 46
        DireccionLabel.Text = "direccion:"
        '
        'ContactoLabel
        '
        ContactoLabel.AutoSize = True
        ContactoLabel.Location = New System.Drawing.Point(71, 240)
        ContactoLabel.Name = "ContactoLabel"
        ContactoLabel.Size = New System.Drawing.Size(66, 17)
        ContactoLabel.TabIndex = 48
        ContactoLabel.Text = "contacto:"
        '
        'ComunaLabel
        '
        ComunaLabel.AutoSize = True
        ComunaLabel.Location = New System.Drawing.Point(71, 268)
        ComunaLabel.Name = "ComunaLabel"
        ComunaLabel.Size = New System.Drawing.Size(62, 17)
        ComunaLabel.TabIndex = 50
        ComunaLabel.Text = "comuna:"
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(71, 296)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(37, 17)
        MailLabel.TabIndex = 52
        MailLabel.Text = "mail:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(71, 324)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(54, 17)
        CiudadLabel.TabIndex = 54
        CiudadLabel.Text = "ciudad:"
        '
        'BodegaDataSet
        '
        Me.BodegaDataSet.DataSetName = "bodegaDataSet"
        Me.BodegaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "factura"
        Me.FacturaBindingSource.DataSource = Me.BodegaDataSet
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.bodegaTableAdapter = Nothing
        Me.TableAdapterManager.detalle_facTableAdapter = Me.Detalle_facTableAdapter
        Me.TableAdapterManager.detalle_provTableAdapter = Nothing
        Me.TableAdapterManager.facturaTableAdapter = Me.FacturaTableAdapter
        Me.TableAdapterManager.productosTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.bodegaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Detalle_facTableAdapter
        '
        Me.Detalle_facTableAdapter.ClearBeforeFill = True
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
        Me.FacturaBindingNavigator.Size = New System.Drawing.Size(939, 27)
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
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'FacturaBindingNavigatorSaveItem
        '
        Me.FacturaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FacturaBindingNavigatorSaveItem.Image = CType(resources.GetObject("FacturaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FacturaBindingNavigatorSaveItem.Name = "FacturaBindingNavigatorSaveItem"
        Me.FacturaBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.FacturaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'N_facturaTextBox
        '
        Me.N_facturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "n_factura", True))
        Me.N_facturaTextBox.Location = New System.Drawing.Point(169, 125)
        Me.N_facturaTextBox.Name = "N_facturaTextBox"
        Me.N_facturaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.N_facturaTextBox.TabIndex = 2
        '
        'DetalleTextBox
        '
        Me.DetalleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "detalle", True))
        Me.DetalleTextBox.Location = New System.Drawing.Point(169, 349)
        Me.DetalleTextBox.Name = "DetalleTextBox"
        Me.DetalleTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DetalleTextBox.TabIndex = 16
        '
        'Valor_nTextBox
        '
        Me.Valor_nTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "valor_n", True))
        Me.Valor_nTextBox.Location = New System.Drawing.Point(169, 383)
        Me.Valor_nTextBox.Name = "Valor_nTextBox"
        Me.Valor_nTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Valor_nTextBox.TabIndex = 20
        '
        'Valor_tTextBox
        '
        Me.Valor_tTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "valor_t", True))
        Me.Valor_tTextBox.Location = New System.Drawing.Point(169, 411)
        Me.Valor_tTextBox.Name = "Valor_tTextBox"
        Me.Valor_tTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Valor_tTextBox.TabIndex = 22
        '
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "observacion", True))
        Me.ObservacionTextBox.Location = New System.Drawing.Point(169, 439)
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ObservacionTextBox.TabIndex = 26
        '
        'IvaTextBox
        '
        Me.IvaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturaBindingSource, "iva", True))
        Me.IvaTextBox.Location = New System.Drawing.Point(169, 467)
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IvaTextBox.TabIndex = 28
        '
        'Detalle_facBindingSource
        '
        Me.Detalle_facBindingSource.DataMember = "detalle_fac"
        Me.Detalle_facBindingSource.DataSource = Me.BodegaDataSet
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(277, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 52)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Seleccionar proveedor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ProductosDataGridView)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.ProveedorDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(319, 492)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 463)
        Me.Panel1.TabIndex = 42
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(224, 366)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 51)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Seleccionar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ProveedorDataGridView
        '
        Me.ProveedorDataGridView.AutoGenerateColumns = False
        Me.ProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ProveedorDataGridView.DataSource = Me.ProveedorBindingSource
        Me.ProveedorDataGridView.Location = New System.Drawing.Point(42, 53)
        Me.ProveedorDataGridView.Name = "ProveedorDataGridView"
        Me.ProveedorDataGridView.RowTemplate.Height = 24
        Me.ProveedorDataGridView.Size = New System.Drawing.Size(516, 108)
        Me.ProveedorDataGridView.TabIndex = 0
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "contacto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "contacto"
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
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "mail"
        Me.DataGridViewTextBoxColumn6.HeaderText = "mail"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ciudad"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ciudad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "proveedor"
        Me.ProveedorBindingSource.DataSource = Me.BodegaDataSet
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'Rut_provTextBox
        '
        Me.Rut_provTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "rut_prov", True))
        Me.Rut_provTextBox.Location = New System.Drawing.Point(169, 153)
        Me.Rut_provTextBox.Name = "Rut_provTextBox"
        Me.Rut_provTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Rut_provTextBox.TabIndex = 43
        '
        'Nombre_provTextBox
        '
        Me.Nombre_provTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "nombre_prov", True))
        Me.Nombre_provTextBox.Location = New System.Drawing.Point(169, 181)
        Me.Nombre_provTextBox.Name = "Nombre_provTextBox"
        Me.Nombre_provTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Nombre_provTextBox.TabIndex = 45
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(169, 209)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DireccionTextBox.TabIndex = 47
        '
        'ContactoTextBox
        '
        Me.ContactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "contacto", True))
        Me.ContactoTextBox.Location = New System.Drawing.Point(169, 237)
        Me.ContactoTextBox.Name = "ContactoTextBox"
        Me.ContactoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ContactoTextBox.TabIndex = 49
        '
        'ComunaTextBox
        '
        Me.ComunaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "comuna", True))
        Me.ComunaTextBox.Location = New System.Drawing.Point(169, 265)
        Me.ComunaTextBox.Name = "ComunaTextBox"
        Me.ComunaTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ComunaTextBox.TabIndex = 51
        '
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "mail", True))
        Me.MailTextBox.Location = New System.Drawing.Point(169, 293)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(100, 22)
        Me.MailTextBox.TabIndex = 53
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource, "ciudad", True))
        Me.CiudadTextBox.Location = New System.Drawing.Point(169, 321)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CiudadTextBox.TabIndex = 55
        '
        'FacturaDataGridView
        '
        Me.FacturaDataGridView.AutoGenerateColumns = False
        Me.FacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.FacturaDataGridView.DataSource = Me.FacturaBindingSource
        Me.FacturaDataGridView.Location = New System.Drawing.Point(331, 95)
        Me.FacturaDataGridView.Name = "FacturaDataGridView"
        Me.FacturaDataGridView.RowTemplate.Height = 24
        Me.FacturaDataGridView.Size = New System.Drawing.Size(582, 386)
        Me.FacturaDataGridView.TabIndex = 55
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "n_factura"
        Me.DataGridViewTextBoxColumn8.HeaderText = "n_factura"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "nombre_prov"
        Me.DataGridViewTextBoxColumn9.HeaderText = "nombre_prov"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "rut_prov"
        Me.DataGridViewTextBoxColumn10.HeaderText = "rut_prov"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "fono"
        Me.DataGridViewTextBoxColumn11.HeaderText = "fono"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "comuna"
        Me.DataGridViewTextBoxColumn12.HeaderText = "comuna"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn13.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "mail"
        Me.DataGridViewTextBoxColumn14.HeaderText = "mail"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "detalle"
        Me.DataGridViewTextBoxColumn15.HeaderText = "detalle"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "producto"
        Me.DataGridViewTextBoxColumn16.HeaderText = "producto"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "valor_n"
        Me.DataGridViewTextBoxColumn17.HeaderText = "valor_n"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "valor_t"
        Me.DataGridViewTextBoxColumn18.HeaderText = "valor_t"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn19.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "observacion"
        Me.DataGridViewTextBoxColumn20.HeaderText = "observacion"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "iva"
        Me.DataGridViewTextBoxColumn21.HeaderText = "iva"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "ciudad"
        Me.DataGridViewTextBoxColumn22.HeaderText = "ciudad"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(127, 728)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 36)
        Me.Button3.TabIndex = 56
        Me.Button3.Text = "Insertar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(804, 37)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(109, 22)
        Me.DateTimePicker1.TabIndex = 57
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Location = New System.Drawing.Point(79, 498)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(66, 17)
        CantidadLabel.TabIndex = 61
        CantidadLabel.Text = "cantidad:"
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_facBindingSource, "cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(169, 495)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CantidadTextBox.TabIndex = 62
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(124, 534)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(39, 17)
        TotalLabel.TabIndex = 65
        TotalLabel.Text = "total:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_facBindingSource, "total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(169, 531)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TotalTextBox.TabIndex = 66
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.BodegaDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(42, 213)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.RowTemplate.Height = 24
        Me.ProductosDataGridView.Size = New System.Drawing.Size(516, 119)
        Me.ProductosDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "nombre_prod"
        Me.DataGridViewTextBoxColumn24.HeaderText = "nombre_prod"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn25.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn26.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(140, 564)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 17)
        IdLabel.TabIndex = 66
        IdLabel.Text = "Id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(169, 561)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IdTextBox.TabIndex = 67
        '
        'Nombre_prodLabel
        '
        Nombre_prodLabel.AutoSize = True
        Nombre_prodLabel.Location = New System.Drawing.Point(70, 592)
        Nombre_prodLabel.Name = "Nombre_prodLabel"
        Nombre_prodLabel.Size = New System.Drawing.Size(93, 17)
        Nombre_prodLabel.TabIndex = 67
        Nombre_prodLabel.Text = "nombre prod:"
        '
        'Nombre_prodTextBox
        '
        Me.Nombre_prodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "nombre_prod", True))
        Me.Nombre_prodTextBox.Location = New System.Drawing.Point(169, 589)
        Me.Nombre_prodTextBox.Name = "Nombre_prodTextBox"
        Me.Nombre_prodTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Nombre_prodTextBox.TabIndex = 68
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(112, 619)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(51, 17)
        PrecioLabel.TabIndex = 68
        PrecioLabel.Text = "precio:"
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(169, 616)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PrecioTextBox.TabIndex = 69
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 975)
        Me.Controls.Add(PrecioLabel)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(Nombre_prodLabel)
        Me.Controls.Add(Me.Nombre_prodTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(Me.FacturaDataGridView)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Rut_provLabel)
        Me.Controls.Add(Me.Rut_provTextBox)
        Me.Controls.Add(Nombre_provLabel)
        Me.Controls.Add(Me.Nombre_provTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(ContactoLabel)
        Me.Controls.Add(Me.ContactoTextBox)
        Me.Controls.Add(ComunaLabel)
        Me.Controls.Add(Me.ComunaTextBox)
        Me.Controls.Add(MailLabel)
        Me.Controls.Add(Me.MailTextBox)
        Me.Controls.Add(CiudadLabel)
        Me.Controls.Add(Me.CiudadTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(N_facturaLabel)
        Me.Controls.Add(Me.N_facturaTextBox)
        Me.Controls.Add(DetalleLabel)
        Me.Controls.Add(Me.DetalleTextBox)
        Me.Controls.Add(Valor_nLabel)
        Me.Controls.Add(Me.Valor_nTextBox)
        Me.Controls.Add(Valor_tLabel)
        Me.Controls.Add(Me.Valor_tTextBox)
        Me.Controls.Add(ObservacionLabel)
        Me.Controls.Add(Me.ObservacionTextBox)
        Me.Controls.Add(IvaLabel)
        Me.Controls.Add(Me.IvaTextBox)
        Me.Controls.Add(Me.FacturaBindingNavigator)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.BodegaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacturaBindingNavigator.ResumeLayout(False)
        Me.FacturaBindingNavigator.PerformLayout()
        CType(Me.Detalle_facBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BodegaDataSet As bodegaDataSet
    Friend WithEvents FacturaBindingSource As BindingSource
    Friend WithEvents FacturaTableAdapter As bodegaDataSetTableAdapters.facturaTableAdapter
    Friend WithEvents TableAdapterManager As bodegaDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents Detalle_facTableAdapter As bodegaDataSetTableAdapters.detalle_facTableAdapter
    Friend WithEvents N_facturaTextBox As TextBox
    Friend WithEvents DetalleTextBox As TextBox
    Friend WithEvents Valor_nTextBox As TextBox
    Friend WithEvents Valor_tTextBox As TextBox
    Friend WithEvents ObservacionTextBox As TextBox
    Friend WithEvents IvaTextBox As TextBox
    Friend WithEvents Detalle_facBindingSource As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As bodegaDataSetTableAdapters.proveedorTableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents ProveedorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Rut_provTextBox As TextBox
    Friend WithEvents Nombre_provTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents ContactoTextBox As TextBox
    Friend WithEvents ComunaTextBox As TextBox
    Friend WithEvents MailTextBox As TextBox
    Friend WithEvents CiudadTextBox As TextBox
    Friend WithEvents FacturaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CantidadTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As bodegaDataSetTableAdapters.productosTableAdapter
    Friend WithEvents ProductosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents Nombre_prodTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
End Class
