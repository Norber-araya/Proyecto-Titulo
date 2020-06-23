<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        Dim ProductoLabel As System.Windows.Forms.Label
        Dim Rut_provLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ComunaLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim FonoLabel As System.Windows.Forms.Label
        Dim N_facturaLabel As System.Windows.Forms.Label
        Dim Nombre_provLabel As System.Windows.Forms.Label
        Dim Rut_clienteLabel As System.Windows.Forms.Label
        Dim ObservacionLabel As System.Windows.Forms.Label
        Dim Valor_netoLabel As System.Windows.Forms.Label
        Dim IvaLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.Seleccionar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.NombrePro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.total = New System.Windows.Forms.TextBox()
        Me.impuesto = New System.Windows.Forms.TextBox()
        Me.neto = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.precio = New System.Windows.Forms.TextBox()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Rut_provTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.ComunaTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.FonoTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.N_facturaTextBox = New System.Windows.Forms.TextBox()
        Me.Rut_clienteTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionTextBox = New System.Windows.Forms.TextBox()
        Me.GestiondeinventarioDataSet = New Gestion_de_inventario.gestiondeinventarioDataSet()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New Gestion_de_inventario.gestiondeinventarioDataSetTableAdapters.productoTableAdapter()
        Me.TableAdapterManager = New Gestion_de_inventario.gestiondeinventarioDataSetTableAdapters.TableAdapterManager()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New Gestion_de_inventario.gestiondeinventarioDataSetTableAdapters.proveedorTableAdapter()
        Me.ProveedorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ProductoLabel = New System.Windows.Forms.Label()
        Rut_provLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ComunaLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        FonoLabel = New System.Windows.Forms.Label()
        N_facturaLabel = New System.Windows.Forms.Label()
        Nombre_provLabel = New System.Windows.Forms.Label()
        Rut_clienteLabel = New System.Windows.Forms.Label()
        ObservacionLabel = New System.Windows.Forms.Label()
        Valor_netoLabel = New System.Windows.Forms.Label()
        IvaLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestiondeinventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductoLabel
        '
        ProductoLabel.AutoSize = True
        ProductoLabel.Location = New System.Drawing.Point(47, 333)
        ProductoLabel.Name = "ProductoLabel"
        ProductoLabel.Size = New System.Drawing.Size(52, 13)
        ProductoLabel.TabIndex = 90
        ProductoLabel.Text = "producto:"
        '
        'Rut_provLabel
        '
        Rut_provLabel.AutoSize = True
        Rut_provLabel.Location = New System.Drawing.Point(551, 22)
        Rut_provLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Rut_provLabel.Name = "Rut_provLabel"
        Rut_provLabel.Size = New System.Drawing.Size(39, 13)
        Rut_provLabel.TabIndex = 78
        Rut_provLabel.Text = "R.U.T:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(55, 72)
        DireccionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 80
        DireccionLabel.Text = "Direccion:"
        '
        'ComunaLabel
        '
        ComunaLabel.AutoSize = True
        ComunaLabel.Location = New System.Drawing.Point(55, 95)
        ComunaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ComunaLabel.Name = "ComunaLabel"
        ComunaLabel.Size = New System.Drawing.Size(48, 13)
        ComunaLabel.TabIndex = 82
        ComunaLabel.Text = "comuna:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(55, 117)
        CiudadLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(42, 13)
        CiudadLabel.TabIndex = 84
        CiudadLabel.Text = "ciudad:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(55, 140)
        EmailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 86
        EmailLabel.Text = "email:"
        '
        'FonoLabel
        '
        FonoLabel.AutoSize = True
        FonoLabel.Location = New System.Drawing.Point(55, 163)
        FonoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FonoLabel.Name = "FonoLabel"
        FonoLabel.Size = New System.Drawing.Size(31, 13)
        FonoLabel.TabIndex = 88
        FonoLabel.Text = "fono:"
        '
        'N_facturaLabel
        '
        N_facturaLabel.AutoSize = True
        N_facturaLabel.Location = New System.Drawing.Point(550, 47)
        N_facturaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        N_facturaLabel.Name = "N_facturaLabel"
        N_facturaLabel.Size = New System.Drawing.Size(58, 13)
        N_facturaLabel.TabIndex = 67
        N_facturaLabel.Text = "N°Factura:"
        '
        'Nombre_provLabel
        '
        Nombre_provLabel.AutoSize = True
        Nombre_provLabel.Location = New System.Drawing.Point(55, 45)
        Nombre_provLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Nombre_provLabel.Name = "Nombre_provLabel"
        Nombre_provLabel.Size = New System.Drawing.Size(47, 13)
        Nombre_provLabel.TabIndex = 69
        Nombre_provLabel.Text = "Nombre:"
        '
        'Rut_clienteLabel
        '
        Rut_clienteLabel.AutoSize = True
        Rut_clienteLabel.Location = New System.Drawing.Point(223, 44)
        Rut_clienteLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Rut_clienteLabel.Name = "Rut_clienteLabel"
        Rut_clienteLabel.Size = New System.Drawing.Size(39, 13)
        Rut_clienteLabel.TabIndex = 70
        Rut_clienteLabel.Text = "R.U.T:"
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.Location = New System.Drawing.Point(55, 186)
        ObservacionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(68, 13)
        ObservacionLabel.TabIndex = 72
        ObservacionLabel.Text = "observacion:"
        '
        'Valor_netoLabel
        '
        Valor_netoLabel.AutoSize = True
        Valor_netoLabel.Location = New System.Drawing.Point(522, 495)
        Valor_netoLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Valor_netoLabel.Name = "Valor_netoLabel"
        Valor_netoLabel.Size = New System.Drawing.Size(57, 13)
        Valor_netoLabel.TabIndex = 74
        Valor_netoLabel.Text = "valor neto:"
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Location = New System.Drawing.Point(522, 520)
        IvaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(24, 13)
        IvaLabel.TabIndex = 75
        IvaLabel.Text = "iva:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(522, 543)
        TotalLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(30, 13)
        TotalLabel.TabIndex = 76
        TotalLabel.Text = "total:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(69, 573)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 109
        Me.Button4.Text = "volver"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ProveedorDataGridView)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.buscar)
        Me.Panel1.Controls.Add(Me.Seleccionar)
        Me.Panel1.Location = New System.Drawing.Point(251, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 309)
        Me.Panel1.TabIndex = 108
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Buscar:"
        '
        'buscar
        '
        Me.buscar.Location = New System.Drawing.Point(168, 15)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(100, 20)
        Me.buscar.TabIndex = 2
        '
        'Seleccionar
        '
        Me.Seleccionar.Location = New System.Drawing.Point(168, 263)
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Size = New System.Drawing.Size(75, 23)
        Me.Seleccionar.TabIndex = 1
        Me.Seleccionar.Text = "Selecionar"
        Me.Seleccionar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(705, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(33, 20)
        Me.Button3.TabIndex = 107
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'NombrePro
        '
        Me.NombrePro.Location = New System.Drawing.Point(129, 45)
        Me.NombrePro.Name = "NombrePro"
        Me.NombrePro.Size = New System.Drawing.Size(76, 20)
        Me.NombrePro.TabIndex = 106
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "cantidad", True))
        Me.Label5.Location = New System.Drawing.Point(126, 441)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 105
        Me.Label5.Tag = ""
        Me.Label5.Text = "Label5"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(104, 533)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 104
        Me.Button1.Text = "crear factura"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'eliminar
        '
        Me.eliminar.Location = New System.Drawing.Point(105, 498)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(75, 23)
        Me.eliminar.TabIndex = 103
        Me.eliminar.Text = "eliminar"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(584, 544)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 20)
        Me.total.TabIndex = 102
        '
        'impuesto
        '
        Me.impuesto.Location = New System.Drawing.Point(584, 517)
        Me.impuesto.Name = "impuesto"
        Me.impuesto.Size = New System.Drawing.Size(100, 20)
        Me.impuesto.TabIndex = 101
        '
        'neto
        '
        Me.neto.Location = New System.Drawing.Point(584, 492)
        Me.neto.Name = "neto"
        Me.neto.Size = New System.Drawing.Size(100, 20)
        Me.neto.TabIndex = 100
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(105, 466)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 99
        Me.Button2.Text = "agregar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 364)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "precio unitario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 390)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "cantidad:"
        '
        'precio
        '
        Me.precio.Location = New System.Drawing.Point(104, 409)
        Me.precio.Name = "precio"
        Me.precio.Size = New System.Drawing.Size(100, 20)
        Me.precio.TabIndex = 95
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(104, 383)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(100, 20)
        Me.cantidad.TabIndex = 94
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(238, 304)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(500, 150)
        Me.DataGridView1.TabIndex = 93
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
        'ProductoTextBox
        '
        Me.ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "producto", True))
        Me.ProductoTextBox.Location = New System.Drawing.Point(105, 357)
        Me.ProductoTextBox.Name = "ProductoTextBox"
        Me.ProductoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProductoTextBox.TabIndex = 92
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.ProductoBindingSource
        Me.ComboBox2.DisplayMember = "cod_producto"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(105, 330)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox2.TabIndex = 91
        Me.ComboBox2.ValueMember = "cod_producto"
        '
        'Rut_provTextBox
        '
        Me.Rut_provTextBox.Location = New System.Drawing.Point(624, 20)
        Me.Rut_provTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Rut_provTextBox.Name = "Rut_provTextBox"
        Me.Rut_provTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Rut_provTextBox.TabIndex = 79
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.Location = New System.Drawing.Point(129, 69)
        Me.DireccionTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(76, 20)
        Me.DireccionTextBox.TabIndex = 81
        '
        'ComunaTextBox
        '
        Me.ComunaTextBox.Location = New System.Drawing.Point(129, 92)
        Me.ComunaTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ComunaTextBox.Name = "ComunaTextBox"
        Me.ComunaTextBox.Size = New System.Drawing.Size(76, 20)
        Me.ComunaTextBox.TabIndex = 83
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.Location = New System.Drawing.Point(129, 115)
        Me.CiudadTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(76, 20)
        Me.CiudadTextBox.TabIndex = 85
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(129, 138)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(76, 20)
        Me.EmailTextBox.TabIndex = 87
        '
        'FonoTextBox
        '
        Me.FonoTextBox.Location = New System.Drawing.Point(129, 160)
        Me.FonoTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FonoTextBox.Name = "FonoTextBox"
        Me.FonoTextBox.Size = New System.Drawing.Size(76, 20)
        Me.FonoTextBox.TabIndex = 89
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(612, 72)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker1.TabIndex = 77
        '
        'N_facturaTextBox
        '
        Me.N_facturaTextBox.Location = New System.Drawing.Point(624, 44)
        Me.N_facturaTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.N_facturaTextBox.Name = "N_facturaTextBox"
        Me.N_facturaTextBox.Size = New System.Drawing.Size(76, 20)
        Me.N_facturaTextBox.TabIndex = 68
        '
        'Rut_clienteTextBox
        '
        Me.Rut_clienteTextBox.Location = New System.Drawing.Point(284, 41)
        Me.Rut_clienteTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Rut_clienteTextBox.Name = "Rut_clienteTextBox"
        Me.Rut_clienteTextBox.Size = New System.Drawing.Size(76, 20)
        Me.Rut_clienteTextBox.TabIndex = 71
        '
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.Location = New System.Drawing.Point(129, 184)
        Me.ObservacionTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(76, 20)
        Me.ObservacionTextBox.TabIndex = 73
        '
        'GestiondeinventarioDataSet
        '
        Me.GestiondeinventarioDataSet.DataSetName = "gestiondeinventarioDataSet"
        Me.GestiondeinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.GestiondeinventarioDataSet
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
        Me.TableAdapterManager.facturaTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.proveedorTableAdapter = Me.ProveedorTableAdapter
        Me.TableAdapterManager.registroTableAdapter = Nothing
        Me.TableAdapterManager.tipousuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Gestion_de_inventario.gestiondeinventarioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
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
        'ProveedorDataGridView
        '
        Me.ProveedorDataGridView.AllowUserToAddRows = False
        Me.ProveedorDataGridView.AllowUserToDeleteRows = False
        Me.ProveedorDataGridView.AutoGenerateColumns = False
        Me.ProveedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ProveedorDataGridView.DataSource = Me.ProveedorBindingSource
        Me.ProveedorDataGridView.Location = New System.Drawing.Point(57, 55)
        Me.ProveedorDataGridView.Name = "ProveedorDataGridView"
        Me.ProveedorDataGridView.ReadOnly = True
        Me.ProveedorDataGridView.RowHeadersVisible = False
        Me.ProveedorDataGridView.Size = New System.Drawing.Size(300, 183)
        Me.ProveedorDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "rut_prov"
        Me.DataGridViewTextBoxColumn1.HeaderText = "rut_prov"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre_prov"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre_prov"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "comuna"
        Me.DataGridViewTextBoxColumn4.HeaderText = "comuna"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ciudad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ciudad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn6.HeaderText = "email"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "fono"
        Me.DataGridViewTextBoxColumn7.HeaderText = "fono"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 615)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.NombrePro)
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
        Me.Name = "Factura"
        Me.Text = "Factura"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestiondeinventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents buscar As TextBox
    Friend WithEvents Seleccionar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents NombrePro As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents total As TextBox
    Friend WithEvents impuesto As TextBox
    Friend WithEvents neto As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents precio As TextBox
    Friend WithEvents cantidad As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents ProductoTextBox As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Rut_provTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents ComunaTextBox As TextBox
    Friend WithEvents CiudadTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents FonoTextBox As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents N_facturaTextBox As TextBox
    Friend WithEvents Rut_clienteTextBox As TextBox
    Friend WithEvents ObservacionTextBox As TextBox
    Friend WithEvents GestiondeinventarioDataSet As gestiondeinventarioDataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As gestiondeinventarioDataSetTableAdapters.productoTableAdapter
    Friend WithEvents TableAdapterManager As gestiondeinventarioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProveedorTableAdapter As gestiondeinventarioDataSetTableAdapters.proveedorTableAdapter
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
