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
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim ProductoLabel As System.Windows.Forms.Label
        Me.Valor_netoTextBox = New System.Windows.Forms.TextBox()
        Me.IvaTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.ControlinventarioDataSet = New ControlDeInventario.ControlinventarioDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.buscar = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.elimina = New System.Windows.Forms.DataGridViewCheckBoxColumn()
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
        Me.cod_producto = New System.Windows.Forms.TextBox()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.precio = New System.Windows.Forms.TextBox()
        Me.ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New ControlDeInventario.ControlinventarioDataSetTableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New ControlDeInventario.ControlinventarioDataSetTableAdapters.TableAdapterManager()
        Me.ProductoTableAdapter = New ControlDeInventario.ControlinventarioDataSetTableAdapters.productoTableAdapter()
        Valor_netoLabel = New System.Windows.Forms.Label()
        IvaLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
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
        CantidadLabel = New System.Windows.Forms.Label()
        ProductoLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Valor_netoLabel
        '
        Valor_netoLabel.AutoSize = True
        Valor_netoLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Valor_netoLabel.Location = New System.Drawing.Point(788, 556)
        Valor_netoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Valor_netoLabel.Name = "Valor_netoLabel"
        Valor_netoLabel.Size = New System.Drawing.Size(83, 21)
        Valor_netoLabel.TabIndex = 151
        Valor_netoLabel.Text = "Valor neto"
        '
        'IvaLabel
        '
        IvaLabel.AutoSize = True
        IvaLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IvaLabel.Location = New System.Drawing.Point(788, 588)
        IvaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IvaLabel.Name = "IvaLabel"
        IvaLabel.Size = New System.Drawing.Size(33, 21)
        IvaLabel.TabIndex = 153
        IvaLabel.Text = "IVA"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalLabel.Location = New System.Drawing.Point(788, 620)
        TotalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(46, 21)
        TotalLabel.TabIndex = 155
        TotalLabel.Text = "Total"
        '
        'N_facturaLabel
        '
        N_facturaLabel.AutoSize = True
        N_facturaLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        N_facturaLabel.Location = New System.Drawing.Point(19, 43)
        N_facturaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        N_facturaLabel.Name = "N_facturaLabel"
        N_facturaLabel.Size = New System.Drawing.Size(84, 21)
        N_facturaLabel.TabIndex = 129
        N_facturaLabel.Text = "N° Factura:"
        '
        'Rut_provLabel
        '
        Rut_provLabel.AutoSize = True
        Rut_provLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rut_provLabel.Location = New System.Drawing.Point(32, 11)
        Rut_provLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Rut_provLabel.Name = "Rut_provLabel"
        Rut_provLabel.Size = New System.Drawing.Size(42, 21)
        Rut_provLabel.TabIndex = 131
        Rut_provLabel.Text = "R.U.T"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(299, 11)
        FechaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(52, 21)
        FechaLabel.TabIndex = 133
        FechaLabel.Text = "Fecha"
        '
        'Nombre_provLabel
        '
        Nombre_provLabel.AutoSize = True
        Nombre_provLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombre_provLabel.Location = New System.Drawing.Point(28, 103)
        Nombre_provLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Nombre_provLabel.Name = "Nombre_provLabel"
        Nombre_provLabel.Size = New System.Drawing.Size(68, 21)
        Nombre_provLabel.TabIndex = 113
        Nombre_provLabel.Text = "Nombre:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.Location = New System.Drawing.Point(28, 135)
        DireccionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(81, 21)
        DireccionLabel.TabIndex = 114
        DireccionLabel.Text = "Direccion:"
        '
        'ComunaLabel
        '
        ComunaLabel.AutoSize = True
        ComunaLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ComunaLabel.Location = New System.Drawing.Point(28, 167)
        ComunaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ComunaLabel.Name = "ComunaLabel"
        ComunaLabel.Size = New System.Drawing.Size(71, 21)
        ComunaLabel.TabIndex = 115
        ComunaLabel.Text = "Comuna:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CiudadLabel.Location = New System.Drawing.Point(28, 199)
        CiudadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(63, 21)
        CiudadLabel.TabIndex = 116
        CiudadLabel.Text = "Ciudad:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(28, 231)
        EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(52, 21)
        EmailLabel.TabIndex = 117
        EmailLabel.Text = "Email:"
        '
        'FonoLabel
        '
        FonoLabel.AutoSize = True
        FonoLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FonoLabel.Location = New System.Drawing.Point(28, 263)
        FonoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FonoLabel.Name = "FonoLabel"
        FonoLabel.Size = New System.Drawing.Size(47, 21)
        FonoLabel.TabIndex = 118
        FonoLabel.Text = "Fono:"
        '
        'Rut_clienteLabel
        '
        Rut_clienteLabel.AutoSize = True
        Rut_clienteLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Rut_clienteLabel.Location = New System.Drawing.Point(309, 100)
        Rut_clienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Rut_clienteLabel.Name = "Rut_clienteLabel"
        Rut_clienteLabel.Size = New System.Drawing.Size(42, 21)
        Rut_clienteLabel.TabIndex = 119
        Rut_clienteLabel.Text = "R.U.T"
        '
        'ObservacionLabel
        '
        ObservacionLabel.AutoSize = True
        ObservacionLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObservacionLabel.Location = New System.Drawing.Point(20, 295)
        ObservacionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ObservacionLabel.Name = "ObservacionLabel"
        ObservacionLabel.Size = New System.Drawing.Size(101, 21)
        ObservacionLabel.TabIndex = 120
        ObservacionLabel.Text = "Observacion:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CantidadLabel.Location = New System.Drawing.Point(32, 444)
        CantidadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(74, 21)
        CantidadLabel.TabIndex = 191
        CantidadLabel.Text = "Cantidad"
        '
        'ProductoLabel
        '
        ProductoLabel.AutoSize = True
        ProductoLabel.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductoLabel.Location = New System.Drawing.Point(32, 347)
        ProductoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ProductoLabel.Name = "ProductoLabel"
        ProductoLabel.Size = New System.Drawing.Size(77, 21)
        ProductoLabel.TabIndex = 186
        ProductoLabel.Text = "Producto:"
        '
        'Valor_netoTextBox
        '
        Me.Valor_netoTextBox.Location = New System.Drawing.Point(896, 556)
        Me.Valor_netoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Valor_netoTextBox.Name = "Valor_netoTextBox"
        Me.Valor_netoTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Valor_netoTextBox.TabIndex = 152
        '
        'IvaTextBox
        '
        Me.IvaTextBox.Location = New System.Drawing.Point(896, 588)
        Me.IvaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.IvaTextBox.Name = "IvaTextBox"
        Me.IvaTextBox.Size = New System.Drawing.Size(132, 22)
        Me.IvaTextBox.TabIndex = 154
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(896, 620)
        Me.TotalTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(132, 22)
        Me.TotalTextBox.TabIndex = 156
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_menu
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(821, 652)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(267, 105)
        Me.Button5.TabIndex = 149
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(175, 484)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 17)
        Me.Label3.TabIndex = 148
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_crearfac
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(3, 651)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(267, 106)
        Me.Button2.TabIndex = 139
        Me.Button2.UseVisualStyleBackColor = True
        '
        'eliminar
        '
        Me.eliminar.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_eliminar
        Me.eliminar.FlatAppearance.BorderSize = 0
        Me.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminar.Location = New System.Drawing.Point(293, 651)
        Me.eliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(268, 116)
        Me.eliminar.TabIndex = 138
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_agregarprod
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(16, 513)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(268, 108)
        Me.Button4.TabIndex = 137
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Panel1.Controls.Add(Me.ClienteDataGridView)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.buscar)
        Me.Panel1.Location = New System.Drawing.Point(408, 112)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(543, 431)
        Me.Panel1.TabIndex = 136
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AllowUserToAddRows = False
        Me.ClienteDataGridView.AllowUserToDeleteRows = False
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(68, 58)
        Me.ClienteDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.ReadOnly = True
        Me.ClienteDataGridView.RowHeadersVisible = False
        Me.ClienteDataGridView.Size = New System.Drawing.Size(400, 226)
        Me.ClienteDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "rut_cliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "rut_cliente"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn3.HeaderText = "email"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fono"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fono"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "comuna"
        Me.DataGridViewTextBoxColumn6.HeaderText = "comuna"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ciudad"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ciudad"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.ControlinventarioDataSet
        '
        'ControlinventarioDataSet
        '
        Me.ControlinventarioDataSet.DataSetName = "ControlinventarioDataSet"
        Me.ControlinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.ControlDeInventario.My.Resources.Resources.boton_seleccionar
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(137, 292)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(269, 113)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(92, 25)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "buscar"
        '
        'buscar
        '
        Me.buscar.Location = New System.Drawing.Point(180, 25)
        Me.buscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(132, 22)
        Me.buscar.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.elimina})
        Me.DataGridView1.Location = New System.Drawing.Point(313, 335)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(807, 204)
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
        'elimina
        '
        Me.elimina.HeaderText = "eliminar"
        Me.elimina.Name = "elimina"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(360, 7)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(132, 22)
        Me.DateTimePicker1.TabIndex = 134
        '
        'N_facturaTextBox
        '
        Me.N_facturaTextBox.Enabled = False
        Me.N_facturaTextBox.Location = New System.Drawing.Point(128, 43)
        Me.N_facturaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.N_facturaTextBox.Name = "N_facturaTextBox"
        Me.N_facturaTextBox.Size = New System.Drawing.Size(132, 22)
        Me.N_facturaTextBox.TabIndex = 130
        '
        'Rut_provTextBox
        '
        Me.Rut_provTextBox.Location = New System.Drawing.Point(128, 7)
        Me.Rut_provTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Rut_provTextBox.Name = "Rut_provTextBox"
        Me.Rut_provTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Rut_provTextBox.TabIndex = 132
        '
        'Rut_clienteTextBox1
        '
        Me.Rut_clienteTextBox1.Location = New System.Drawing.Point(371, 95)
        Me.Rut_clienteTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Rut_clienteTextBox1.Name = "Rut_clienteTextBox1"
        Me.Rut_clienteTextBox1.Size = New System.Drawing.Size(132, 22)
        Me.Rut_clienteTextBox1.TabIndex = 122
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Location = New System.Drawing.Point(128, 100)
        Me.NombreTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(132, 22)
        Me.NombreTextBox.TabIndex = 123
        '
        'EmailTextBox1
        '
        Me.EmailTextBox1.Location = New System.Drawing.Point(128, 228)
        Me.EmailTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EmailTextBox1.Name = "EmailTextBox1"
        Me.EmailTextBox1.Size = New System.Drawing.Size(132, 22)
        Me.EmailTextBox1.TabIndex = 124
        '
        'FonoTextBox1
        '
        Me.FonoTextBox1.Location = New System.Drawing.Point(128, 260)
        Me.FonoTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FonoTextBox1.Name = "FonoTextBox1"
        Me.FonoTextBox1.Size = New System.Drawing.Size(132, 22)
        Me.FonoTextBox1.TabIndex = 125
        '
        'DireccionTextBox1
        '
        Me.DireccionTextBox1.Location = New System.Drawing.Point(128, 132)
        Me.DireccionTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DireccionTextBox1.Name = "DireccionTextBox1"
        Me.DireccionTextBox1.Size = New System.Drawing.Size(132, 22)
        Me.DireccionTextBox1.TabIndex = 126
        '
        'ComunaTextBox1
        '
        Me.ComunaTextBox1.Location = New System.Drawing.Point(128, 164)
        Me.ComunaTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComunaTextBox1.Name = "ComunaTextBox1"
        Me.ComunaTextBox1.Size = New System.Drawing.Size(132, 22)
        Me.ComunaTextBox1.TabIndex = 127
        '
        'CiudadTextBox1
        '
        Me.CiudadTextBox1.Location = New System.Drawing.Point(128, 196)
        Me.CiudadTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CiudadTextBox1.Name = "CiudadTextBox1"
        Me.CiudadTextBox1.Size = New System.Drawing.Size(132, 22)
        Me.CiudadTextBox1.TabIndex = 128
        '
        'ObservacionTextBox
        '
        Me.ObservacionTextBox.Location = New System.Drawing.Point(128, 292)
        Me.ObservacionTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ObservacionTextBox.Name = "ObservacionTextBox"
        Me.ObservacionTextBox.Size = New System.Drawing.Size(132, 22)
        Me.ObservacionTextBox.TabIndex = 121
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(524, 95)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(44, 25)
        Me.Button3.TabIndex = 150
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cod_producto
        '
        Me.cod_producto.Location = New System.Drawing.Point(121, 348)
        Me.cod_producto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cod_producto.Name = "cod_producto"
        Me.cod_producto.Size = New System.Drawing.Size(132, 22)
        Me.cod_producto.TabIndex = 193
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(121, 443)
        Me.cantidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(132, 22)
        Me.cantidad.TabIndex = 192
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 380)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 21)
        Me.Label1.TabIndex = 190
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-1, 412)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 21)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "Precio unitario"
        '
        'precio
        '
        Me.precio.Location = New System.Drawing.Point(121, 411)
        Me.precio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.precio.Name = "precio"
        Me.precio.Size = New System.Drawing.Size(132, 22)
        Me.precio.TabIndex = 188
        '
        'ProductoTextBox
        '
        Me.ProductoTextBox.Location = New System.Drawing.Point(121, 378)
        Me.ProductoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProductoTextBox.Name = "ProductoTextBox"
        Me.ProductoTextBox.Size = New System.Drawing.Size(132, 22)
        Me.ProductoTextBox.TabIndex = 187
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(257, 347)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(48, 25)
        Me.Button6.TabIndex = 194
        Me.Button6.Text = "..."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.ControlinventarioDataSet
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.boletaTableAdapter = Nothing
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
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
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'FacturaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1119, 759)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.cod_producto)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.precio)
        Me.Controls.Add(ProductoLabel)
        Me.Controls.Add(Me.ProductoTextBox)
        Me.Controls.Add(Valor_netoLabel)
        Me.Controls.Add(Me.Valor_netoTextBox)
        Me.Controls.Add(IvaLabel)
        Me.Controls.Add(Me.IvaTextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.eliminar)
        Me.Controls.Add(Me.Panel1)
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
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FacturaVenta"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Valor_netoTextBox As TextBox
    Friend WithEvents IvaTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents buscar As TextBox
    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents elimina As DataGridViewCheckBoxColumn
    Friend WithEvents cod_producto As TextBox
    Friend WithEvents cantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents precio As TextBox
    Friend WithEvents ProductoTextBox As TextBox
    Friend WithEvents Button6 As Button
End Class
