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
        Dim Valor_netoLabel As System.Windows.Forms.Label
        Dim IvaLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim ProductoLabel1 As System.Windows.Forms.Label
        Dim ProductoLabel As System.Windows.Forms.Label
        Dim N_facturaLabel As System.Windows.Forms.Label
        Dim Rut_provLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim Nombre_provLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ComunaLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim FonoLabel As System.Windows.Forms.Label
        Dim Rut_clienteLabel As System.Windows.Forms.Label
        Dim ObservacionLabel As System.Windows.Forms.Label
        Me.Valor_netoTextBox = New System.Windows.Forms.TextBox()
        Me.IvaTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ControlinventarioDataSet = New ControlDeInventario.ControlinventarioDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.N_facturaTextBox = New System.Windows.Forms.TextBox()
        Me.Rut_provTextBox = New System.Windows.Forms.TextBox()
        Me.Rut_clienteTextBox1 = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox1 = New System.Windows.Forms.TextBox()
        Me.FonoTextBox1 = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox1 = New System.Windows.Forms.TextBox()
        Me.ComunaTextBox1 = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox1 = New System.Windows.Forms.TextBox()
        Me.ObservacionTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ClienteTableAdapter = New ControlDeInventario.ControlinventarioDataSetTableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New ControlDeInventario.ControlinventarioDataSetTableAdapters.TableAdapterManager()
        Me.ProductoTableAdapter = New ControlDeInventario.ControlinventarioDataSetTableAdapters.productoTableAdapter()
        Valor_netoLabel = New System.Windows.Forms.Label()
        IvaLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        ProductoLabel1 = New System.Windows.Forms.Label()
        ProductoLabel = New System.Windows.Forms.Label()
        N_facturaLabel = New System.Windows.Forms.Label()
        Rut_provLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        Nombre_provLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ComunaLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        FonoLabel = New System.Windows.Forms.Label()
        Rut_clienteLabel = New System.Windows.Forms.Label()
        ObservacionLabel = New System.Windows.Forms.Label()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Valor_netoLabel
        '
        Valor_netoLabel.AutoSize = True
        Valor_netoLabel.Location = New System.Drawing.Point(748, 558)
        Valor_netoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Valor_netoLabel.Name = "Valor_netoLabel"
        Valor_netoLabel.Size = New System.Drawing.Size(75, 17)
        Valor_netoLabel.TabIndex = 151
        Valor_netoLabel.Text = "valor neto:"
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Location = New System.Drawing.Point(748, 590)
        IvaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(30, 17)
        IvaLabel.TabIndex = 153
        IvaLabel.Text = "iva:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(748, 622)
        TotalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(39, 17)
        TotalLabel.TabIndex = 155
        TotalLabel.Text = "total:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(28, 421)
        PrecioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(51, 17)
        PrecioLabel.TabIndex = 143
        PrecioLabel.Text = "precio:"
        '
        'ProductoLabel1
        '
        ProductoLabel1.AutoSize = True
        ProductoLabel1.Location = New System.Drawing.Point(13, 389)
        ProductoLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ProductoLabel1.Name = "ProductoLabel1"
        ProductoLabel1.Size = New System.Drawing.Size(68, 17)
        ProductoLabel1.TabIndex = 141
        ProductoLabel1.Text = "producto:"
        '
        'ProductoLabel
        '
        ProductoLabel.AutoSize = True
        ProductoLabel.Location = New System.Drawing.Point(13, 351)
        ProductoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ProductoLabel.Name = "ProductoLabel"
        ProductoLabel.Size = New System.Drawing.Size(68, 17)
        ProductoLabel.TabIndex = 140
        ProductoLabel.Text = "producto:"
        '
        'N_facturaLabel
        '
        N_facturaLabel.AutoSize = True
        N_facturaLabel.Location = New System.Drawing.Point(844, 47)
        N_facturaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        N_facturaLabel.Name = "N_facturaLabel"
        N_facturaLabel.Size = New System.Drawing.Size(80, 17)
        N_facturaLabel.TabIndex = 129
        N_facturaLabel.Text = "N° Factura:"
        '
        'Rut_provLabel
        '
        Rut_provLabel.AutoSize = True
        Rut_provLabel.Location = New System.Drawing.Point(844, 15)
        Rut_provLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Rut_provLabel.Name = "Rut_provLabel"
        Rut_provLabel.Size = New System.Drawing.Size(49, 17)
        Rut_provLabel.TabIndex = 131
        Rut_provLabel.Text = "R.U.T:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(844, 80)
        FechaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(47, 17)
        FechaLabel.TabIndex = 133
        FechaLabel.Text = "fecha:"
        '
        'Nombre_provLabel
        '
        Nombre_provLabel.AutoSize = True
        Nombre_provLabel.Location = New System.Drawing.Point(16, 33)
        Nombre_provLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Nombre_provLabel.Name = "Nombre_provLabel"
        Nombre_provLabel.Size = New System.Drawing.Size(62, 17)
        Nombre_provLabel.TabIndex = 113
        Nombre_provLabel.Text = "Nombre:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(16, 65)
        DireccionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(71, 17)
        DireccionLabel.TabIndex = 114
        DireccionLabel.Text = "Direccion:"
        '
        'ComunaLabel
        '
        ComunaLabel.AutoSize = True
        ComunaLabel.Location = New System.Drawing.Point(16, 97)
        ComunaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ComunaLabel.Name = "ComunaLabel"
        ComunaLabel.Size = New System.Drawing.Size(64, 17)
        ComunaLabel.TabIndex = 115
        ComunaLabel.Text = "Comuna:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(16, 129)
        CiudadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(56, 17)
        CiudadLabel.TabIndex = 116
        CiudadLabel.Text = "Ciudad:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(16, 161)
        EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(46, 17)
        EmailLabel.TabIndex = 117
        EmailLabel.Text = "Email:"
        '
        'FonoLabel
        '
        FonoLabel.AutoSize = True
        FonoLabel.Location = New System.Drawing.Point(16, 193)
        FonoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FonoLabel.Name = "FonoLabel"
        FonoLabel.Size = New System.Drawing.Size(44, 17)
        FonoLabel.TabIndex = 118
        FonoLabel.Text = "Fono:"
        '
        'Rut_clienteLabel
        '
        Rut_clienteLabel.AutoSize = True
        Rut_clienteLabel.Location = New System.Drawing.Point(292, 33)
        Rut_clienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Rut_clienteLabel.Name = "Rut_clienteLabel"
        Rut_clienteLabel.Size = New System.Drawing.Size(49, 17)
        Rut_clienteLabel.TabIndex = 119
        Rut_clienteLabel.Text = "R.U.T:"
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.Location = New System.Drawing.Point(16, 225)
        ObservacionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(89, 17)
        ObservacionLabel.TabIndex = 120
        ObservacionLabel.Text = "observacion:"
        '
        'Valor_netoTextBox
        '
        Me.Valor_netoTextBox.Location = New System.Drawing.Point(848, 554)
        Me.Valor_netoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Valor_netoTextBox.Name = "Valor_netoTextBox"
        Me.Valor_netoTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Valor_netoTextBox.TabIndex = 152
        '
        'IvaTextBox
        '
        Me.IvaTextBox.Location = New System.Drawing.Point(848, 586)
        Me.IvaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(132, 22)
        Me.IvaTextBox.TabIndex = 154
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(848, 618)
        Me.TotalTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(132, 22)
        Me.TotalTextBox.TabIndex = 156
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(11, 639)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 28)
        Me.Button5.TabIndex = 149
        Me.Button5.Text = "menu"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "cantidad", True))
        Me.Label3.Location = New System.Drawing.Point(123, 480)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 148
        Me.Label3.Text = "cantidad"
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.ControlinventarioDataSet
        '
        'ControlinventarioDataSet
        '
        Me.ControlinventarioDataSet.DataSetName = "ControlinventarioDataSet"
        Me.ControlinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 460)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 147
        Me.Label2.Text = "cantidad:"
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(88, 452)
        Me.cantidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(132, 22)
        Me.cantidad.TabIndex = 146
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(88, 417)
        Me.PrecioTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(132, 22)
        Me.PrecioTextBox.TabIndex = 145
        '
        'ProductoTextBox
        '
        Me.ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "nombre", True))
        Me.ProductoTextBox.Location = New System.Drawing.Point(91, 385)
        Me.ProductoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProductoTextBox.Multiline = True
        Me.ProductoTextBox.Name = "ProductoTextBox"
        Me.ProductoTextBox.Size = New System.Drawing.Size(132, 24)
        Me.ProductoTextBox.TabIndex = 144
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.ProductoBindingSource
        Me.ComboBox2.DisplayMember = "cod_producto"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(91, 347)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(132, 24)
        Me.ComboBox2.TabIndex = 142
        Me.ComboBox2.ValueMember = "cod_producto"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(87, 597)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 139
        Me.Button2.Text = "crear factura"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'eliminar
        '
        Me.eliminar.Location = New System.Drawing.Point(88, 554)
        Me.eliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(100, 28)
        Me.eliminar.TabIndex = 138
        Me.eliminar.Text = "eliminar"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(88, 514)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 28)
        Me.Button4.TabIndex = 137
        Me.Button4.Text = "agregar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ClienteDataGridView)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.buscar)
        Me.Panel1.Location = New System.Drawing.Point(317, 79)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(471, 363)
        Me.Panel1.TabIndex = 136
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(92, 55)
        Me.ClienteDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.Size = New System.Drawing.Size(301, 226)
        Me.ClienteDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "rut_cliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "rut_cliente"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn3.HeaderText = "email"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fono"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fono"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "comuna"
        Me.DataGridViewTextBoxColumn6.HeaderText = "comuna"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ciudad"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ciudad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.ControlinventarioDataSet
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(205, 289)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Seleccionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "buscar"
        '
        'buscar
        '
        Me.buscar.Location = New System.Drawing.Point(193, 22)
        Me.buscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(132, 22)
        Me.buscar.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(277, 347)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(743, 185)
        Me.DataGridView1.TabIndex = 135
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(944, 75)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(132, 22)
        Me.DateTimePicker1.TabIndex = 134
        '
        'N_facturaTextBox
        '
        Me.N_facturaTextBox.Location = New System.Drawing.Point(944, 43)
        Me.N_facturaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.N_facturaTextBox.Name = "N_facturaTextBox"
        Me.N_facturaTextBox.Size = New System.Drawing.Size(132, 22)
        Me.N_facturaTextBox.TabIndex = 130
        '
        'Rut_provTextBox
        '
        Me.Rut_provTextBox.Location = New System.Drawing.Point(944, 11)
        Me.Rut_provTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Rut_provTextBox.Name = "Rut_provTextBox"
        Me.Rut_provTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Rut_provTextBox.TabIndex = 132
        '
        'Rut_clienteTextBox1
        '
        Me.Rut_clienteTextBox1.Location = New System.Drawing.Point(371, 30)
        Me.Rut_clienteTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Rut_clienteTextBox1.Name = "Rut_clienteTextBox1"
        Me.Rut_clienteTextBox1.Size = New System.Drawing.Size(132, 22)
        Me.Rut_clienteTextBox1.TabIndex = 122
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Location = New System.Drawing.Point(116, 30)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(132, 22)
        Me.NombreTextBox.TabIndex = 123
        '
        'EmailTextBox1
        '
        Me.EmailTextBox1.Location = New System.Drawing.Point(116, 158)
        Me.EmailTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EmailTextBox1.Name = "EmailTextBox1"
        Me.EmailTextBox1.Size = New System.Drawing.Size(132, 22)
        Me.EmailTextBox1.TabIndex = 124
        '
        'FonoTextBox1
        '
        Me.FonoTextBox1.Location = New System.Drawing.Point(116, 190)
        Me.FonoTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FonoTextBox1.Name = "FonoTextBox1"
        Me.FonoTextBox1.Size = New System.Drawing.Size(132, 22)
        Me.FonoTextBox1.TabIndex = 125
        '
        'DireccionTextBox1
        '
        Me.DireccionTextBox1.Location = New System.Drawing.Point(116, 62)
        Me.DireccionTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DireccionTextBox1.Name = "DireccionTextBox1"
        Me.DireccionTextBox1.Size = New System.Drawing.Size(132, 22)
        Me.DireccionTextBox1.TabIndex = 126
        '
        'ComunaTextBox1
        '
        Me.ComunaTextBox1.Location = New System.Drawing.Point(116, 94)
        Me.ComunaTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComunaTextBox1.Name = "ComunaTextBox1"
        Me.ComunaTextBox1.Size = New System.Drawing.Size(132, 22)
        Me.ComunaTextBox1.TabIndex = 127
        '
        'CiudadTextBox1
        '
        Me.CiudadTextBox1.Location = New System.Drawing.Point(116, 126)
        Me.CiudadTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CiudadTextBox1.Name = "CiudadTextBox1"
        Me.CiudadTextBox1.Size = New System.Drawing.Size(132, 22)
        Me.CiudadTextBox1.TabIndex = 128
        '
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.Location = New System.Drawing.Point(116, 222)
        Me.ObservacionTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(132, 22)
        Me.ObservacionTextBox.TabIndex = 121
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(512, 33)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(44, 25)
        Me.Button3.TabIndex = 150
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
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
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'FacturaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 686)
        Me.Controls.Add(Valor_netoLabel)
        Me.Controls.Add(Me.Valor_netoTextBox)
        Me.Controls.Add(IvaLabel)
        Me.Controls.Add(Me.IvaTextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.Button5)
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
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(N_facturaLabel)
        Me.Controls.Add(Me.N_facturaTextBox)
        Me.Controls.Add(Rut_provLabel)
        Me.Controls.Add(Me.Rut_provTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.Rut_clienteTextBox1)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.EmailTextBox1)
        Me.Controls.Add(Me.FonoTextBox1)
        Me.Controls.Add(Me.DireccionTextBox1)
        Me.Controls.Add(Me.ComunaTextBox1)
        Me.Controls.Add(Me.CiudadTextBox1)
        Me.Controls.Add(Nombre_provLabel)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(ComunaLabel)
        Me.Controls.Add(CiudadLabel)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(FonoLabel)
        Me.Controls.Add(Rut_clienteLabel)
        Me.Controls.Add(ObservacionLabel)
        Me.Controls.Add(Me.ObservacionTextBox)
        Me.Controls.Add(Me.Button3)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FacturaVenta"
        Me.Text = "Form3"
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Valor_netoTextBox As TextBox
    Friend WithEvents IvaTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cantidad As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents ProductoTextBox As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents buscar As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents N_facturaTextBox As TextBox
    Friend WithEvents Rut_provTextBox As TextBox
    Friend WithEvents Rut_clienteTextBox1 As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents EmailTextBox1 As TextBox
    Friend WithEvents FonoTextBox1 As TextBox
    Friend WithEvents DireccionTextBox1 As TextBox
    Friend WithEvents ComunaTextBox1 As TextBox
    Friend WithEvents CiudadTextBox1 As TextBox
    Friend WithEvents ObservacionTextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents ControlinventarioDataSet As ControlinventarioDataSet
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents ClienteTableAdapter As ControlinventarioDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents TableAdapterManager As ControlinventarioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents ProductoTableAdapter As ControlinventarioDataSetTableAdapters.productoTableAdapter
    Friend WithEvents ProductoBindingSource As BindingSource
End Class
