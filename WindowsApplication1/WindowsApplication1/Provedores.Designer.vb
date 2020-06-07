<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Provedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Provedores))
        Dim Rut_provLabel As System.Windows.Forms.Label
        Dim Nombre_provLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim ContactoLabel As System.Windows.Forms.Label
        Me.BodegaDataSet1 = New WindowsApplication1.bodegaDataSet()
        Me.ProveedorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter1 = New WindowsApplication1.bodegaDataSetTableAdapters.proveedorTableAdapter()
        Me.TableAdapterManager1 = New WindowsApplication1.bodegaDataSetTableAdapters.TableAdapterManager()
        Me.ProveedorBindingSource1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ProveedorBindingSource1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Rut_provTextBox1 = New System.Windows.Forms.TextBox()
        Me.Nombre_provTextBox1 = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox1 = New System.Windows.Forms.TextBox()
        Me.ContactoTextBox1 = New System.Windows.Forms.TextBox()
        Me.ProveedorDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Rut_provLabel = New System.Windows.Forms.Label()
        Nombre_provLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        ContactoLabel = New System.Windows.Forms.Label()
        CType(Me.BodegaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedorBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProveedorBindingSource1BindingNavigator.SuspendLayout()
        CType(Me.ProveedorDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BodegaDataSet1
        '
        Me.BodegaDataSet1.DataSetName = "bodegaDataSet"
        Me.BodegaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProveedorBindingSource1
        '
        Me.ProveedorBindingSource1.DataMember = "proveedor"
        Me.ProveedorBindingSource1.DataSource = Me.BodegaDataSet1
        '
        'ProveedorTableAdapter1
        '
        Me.ProveedorTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.productosTableAdapter = Nothing
        Me.TableAdapterManager1.proveedorTableAdapter = Me.ProveedorTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.bodegaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProveedorBindingSource1BindingNavigator
        '
        Me.ProveedorBindingSource1BindingNavigator.AddNewItem = Me.ToolStripButton5
        Me.ProveedorBindingSource1BindingNavigator.BindingSource = Me.ProveedorBindingSource1
        Me.ProveedorBindingSource1BindingNavigator.CountItem = Me.ToolStripLabel1
        Me.ProveedorBindingSource1BindingNavigator.DeleteItem = Me.ToolStripButton6
        Me.ProveedorBindingSource1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripButton6, Me.ProveedorBindingSource1BindingNavigatorSaveItem})
        Me.ProveedorBindingSource1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProveedorBindingSource1BindingNavigator.MoveFirstItem = Me.ToolStripButton1
        Me.ProveedorBindingSource1BindingNavigator.MoveLastItem = Me.ToolStripButton4
        Me.ProveedorBindingSource1BindingNavigator.MoveNextItem = Me.ToolStripButton3
        Me.ProveedorBindingSource1BindingNavigator.MovePreviousItem = Me.ToolStripButton2
        Me.ProveedorBindingSource1BindingNavigator.Name = "ProveedorBindingSource1BindingNavigator"
        Me.ProveedorBindingSource1BindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.ProveedorBindingSource1BindingNavigator.Size = New System.Drawing.Size(664, 25)
        Me.ProveedorBindingSource1BindingNavigator.TabIndex = 0
        Me.ProveedorBindingSource1BindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "BindingNavigatorMoveFirstItem"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Mover primero"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "BindingNavigatorMovePreviousItem"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Mover anterior"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "BindingNavigatorSeparator"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Posición"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "BindingNavigatorPositionItem"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Posición actual"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "BindingNavigatorCountItem"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(37, 15)
        Me.ToolStripLabel1.Text = "de {0}"
        Me.ToolStripLabel1.ToolTipText = "Número total de elementos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "BindingNavigatorSeparator"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "BindingNavigatorMoveNextItem"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton3.Text = "Mover siguiente"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "BindingNavigatorMoveLastItem"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton4.Text = "Mover último"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "BindingNavigatorSeparator"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 6)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "BindingNavigatorAddNewItem"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Agregar nuevo"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "BindingNavigatorDeleteItem"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton6.Text = "Eliminar"
        '
        'ProveedorBindingSource1BindingNavigatorSaveItem
        '
        Me.ProveedorBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProveedorBindingSource1BindingNavigatorSaveItem.Image = CType(resources.GetObject("ProveedorBindingSource1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProveedorBindingSource1BindingNavigatorSaveItem.Name = "ProveedorBindingSource1BindingNavigatorSaveItem"
        Me.ProveedorBindingSource1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ProveedorBindingSource1BindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Rut_provLabel
        '
        Rut_provLabel.AutoSize = True
        Rut_provLabel.Location = New System.Drawing.Point(29, 95)
        Rut_provLabel.Name = "Rut_provLabel"
        Rut_provLabel.Size = New System.Drawing.Size(46, 13)
        Rut_provLabel.TabIndex = 1
        Rut_provLabel.Text = "rut prov:"
        '
        'Rut_provTextBox1
        '
        Me.Rut_provTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource1, "rut_prov", True))
        Me.Rut_provTextBox1.Location = New System.Drawing.Point(104, 92)
        Me.Rut_provTextBox1.Name = "Rut_provTextBox1"
        Me.Rut_provTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Rut_provTextBox1.TabIndex = 2
        '
        'Nombre_provLabel
        '
        Nombre_provLabel.AutoSize = True
        Nombre_provLabel.Location = New System.Drawing.Point(29, 121)
        Nombre_provLabel.Name = "Nombre_provLabel"
        Nombre_provLabel.Size = New System.Drawing.Size(69, 13)
        Nombre_provLabel.TabIndex = 3
        Nombre_provLabel.Text = "nombre prov:"
        '
        'Nombre_provTextBox1
        '
        Me.Nombre_provTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource1, "nombre_prov", True))
        Me.Nombre_provTextBox1.Location = New System.Drawing.Point(104, 118)
        Me.Nombre_provTextBox1.Name = "Nombre_provTextBox1"
        Me.Nombre_provTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_provTextBox1.TabIndex = 4
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(29, 147)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(53, 13)
        DireccionLabel.TabIndex = 5
        DireccionLabel.Text = "direccion:"
        '
        'DireccionTextBox1
        '
        Me.DireccionTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource1, "direccion", True))
        Me.DireccionTextBox1.Location = New System.Drawing.Point(104, 144)
        Me.DireccionTextBox1.Name = "DireccionTextBox1"
        Me.DireccionTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox1.TabIndex = 6
        '
        'ContactoLabel
        '
        ContactoLabel.AutoSize = True
        ContactoLabel.Location = New System.Drawing.Point(29, 173)
        ContactoLabel.Name = "ContactoLabel"
        ContactoLabel.Size = New System.Drawing.Size(52, 13)
        ContactoLabel.TabIndex = 7
        ContactoLabel.Text = "contacto:"
        '
        'ContactoTextBox1
        '
        Me.ContactoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedorBindingSource1, "contacto", True))
        Me.ContactoTextBox1.Location = New System.Drawing.Point(104, 170)
        Me.ContactoTextBox1.Name = "ContactoTextBox1"
        Me.ContactoTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.ContactoTextBox1.TabIndex = 8
        '
        'ProveedorDataGridView1
        '
        Me.ProveedorDataGridView1.AutoGenerateColumns = False
        Me.ProveedorDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProveedorDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ProveedorDataGridView1.DataSource = Me.ProveedorBindingSource1
        Me.ProveedorDataGridView1.Location = New System.Drawing.Point(310, 81)
        Me.ProveedorDataGridView1.Name = "ProveedorDataGridView1"
        Me.ProveedorDataGridView1.Size = New System.Drawing.Size(300, 220)
        Me.ProveedorDataGridView1.TabIndex = 9
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "rut_prov"
        Me.DataGridViewTextBoxColumn5.HeaderText = "rut_prov"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "nombre_prov"
        Me.DataGridViewTextBoxColumn6.HeaderText = "nombre_prov"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "contacto"
        Me.DataGridViewTextBoxColumn8.HeaderText = "contacto"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Provedores
        '
        Me.ClientSize = New System.Drawing.Size(664, 362)
        Me.Controls.Add(Me.ProveedorDataGridView1)
        Me.Controls.Add(Rut_provLabel)
        Me.Controls.Add(Me.Rut_provTextBox1)
        Me.Controls.Add(Nombre_provLabel)
        Me.Controls.Add(Me.Nombre_provTextBox1)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox1)
        Me.Controls.Add(ContactoLabel)
        Me.Controls.Add(Me.ContactoTextBox1)
        Me.Controls.Add(Me.ProveedorBindingSource1BindingNavigator)
        Me.Name = "Provedores"
        CType(Me.BodegaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedorBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProveedorBindingSource1BindingNavigator.ResumeLayout(False)
        Me.ProveedorBindingSource1BindingNavigator.PerformLayout()
        CType(Me.ProveedorDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btncrear As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnmostrar As Button
    Friend WithEvents BodegaDataSet As bodegaDataSet
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As bodegaDataSetTableAdapters.proveedorTableAdapter
    Friend WithEvents TableAdapterManager As bodegaDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents ProveedorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Rut_provTextBox As TextBox
    Friend WithEvents Nombre_provTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents ContactoTextBox As TextBox
    Friend WithEvents BodegaDataSet1 As bodegaDataSet
    Friend WithEvents ProveedorBindingSource1 As BindingSource
    Friend WithEvents ProveedorTableAdapter1 As bodegaDataSetTableAdapters.proveedorTableAdapter
    Friend WithEvents TableAdapterManager1 As bodegaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProveedorBindingSource1BindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ProveedorBindingSource1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Rut_provTextBox1 As TextBox
    Friend WithEvents Nombre_provTextBox1 As TextBox
    Friend WithEvents DireccionTextBox1 As TextBox
    Friend WithEvents ContactoTextBox1 As TextBox
    Friend WithEvents ProveedorDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
