<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerBoleta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerBoleta))
        Dim N_boletaLabel As System.Windows.Forms.Label
        Dim Rut_empresaLabel As System.Windows.Forms.Label
        Dim Rut_clienteLabel As System.Windows.Forms.Label
        Dim Nombre_empresaLabel As System.Windows.Forms.Label
        Dim DirecionLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Me.ControlinventarioDataSet = New ControlDeInventario.ControlinventarioDataSet()
        Me.Detalle_boletaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Detalle_boletaTableAdapter = New ControlDeInventario.ControlinventarioDataSetTableAdapters.detalle_boletaTableAdapter()
        Me.TableAdapterManager = New ControlDeInventario.ControlinventarioDataSetTableAdapters.TableAdapterManager()
        Me.Detalle_boletaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Detalle_boletaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Detalle_boletaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BoletaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BoletaTableAdapter = New ControlDeInventario.ControlinventarioDataSetTableAdapters.boletaTableAdapter()
        Me.N_boletaTextBox = New System.Windows.Forms.TextBox()
        Me.Rut_empresaTextBox = New System.Windows.Forms.TextBox()
        Me.Rut_clienteTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_empresaTextBox = New System.Windows.Forms.TextBox()
        Me.DirecionTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        N_boletaLabel = New System.Windows.Forms.Label()
        Rut_empresaLabel = New System.Windows.Forms.Label()
        Rut_clienteLabel = New System.Windows.Forms.Label()
        Nombre_empresaLabel = New System.Windows.Forms.Label()
        DirecionLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalle_boletaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalle_boletaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Detalle_boletaBindingNavigator.SuspendLayout()
        CType(Me.Detalle_boletaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoletaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ControlinventarioDataSet
        '
        Me.ControlinventarioDataSet.DataSetName = "ControlinventarioDataSet"
        Me.ControlinventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Detalle_boletaBindingSource
        '
        Me.Detalle_boletaBindingSource.DataMember = "detalle_boleta"
        Me.Detalle_boletaBindingSource.DataSource = Me.ControlinventarioDataSet
        '
        'Detalle_boletaTableAdapter
        '
        Me.Detalle_boletaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.boletaTableAdapter = Me.BoletaTableAdapter
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.detalle_boletaTableAdapter = Me.Detalle_boletaTableAdapter
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
        'Detalle_boletaBindingNavigator
        '
        Me.Detalle_boletaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Detalle_boletaBindingNavigator.BindingSource = Me.Detalle_boletaBindingSource
        Me.Detalle_boletaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Detalle_boletaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Detalle_boletaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Detalle_boletaBindingNavigatorSaveItem})
        Me.Detalle_boletaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Detalle_boletaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Detalle_boletaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Detalle_boletaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Detalle_boletaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Detalle_boletaBindingNavigator.Name = "Detalle_boletaBindingNavigator"
        Me.Detalle_boletaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Detalle_boletaBindingNavigator.Size = New System.Drawing.Size(475, 25)
        Me.Detalle_boletaBindingNavigator.TabIndex = 0
        Me.Detalle_boletaBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'Detalle_boletaBindingNavigatorSaveItem
        '
        Me.Detalle_boletaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Detalle_boletaBindingNavigatorSaveItem.Image = CType(resources.GetObject("Detalle_boletaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Detalle_boletaBindingNavigatorSaveItem.Name = "Detalle_boletaBindingNavigatorSaveItem"
        Me.Detalle_boletaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Detalle_boletaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Detalle_boletaDataGridView
        '
        Me.Detalle_boletaDataGridView.AutoGenerateColumns = False
        Me.Detalle_boletaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Detalle_boletaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Detalle_boletaDataGridView.DataSource = Me.Detalle_boletaBindingSource
        Me.Detalle_boletaDataGridView.Location = New System.Drawing.Point(83, 164)
        Me.Detalle_boletaDataGridView.Name = "Detalle_boletaDataGridView"
        Me.Detalle_boletaDataGridView.Size = New System.Drawing.Size(342, 179)
        Me.Detalle_boletaDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "n_boleta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "n_boleta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "cod_prodcuto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "cod_prodcuto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'BoletaBindingSource
        '
        Me.BoletaBindingSource.DataMember = "boleta"
        Me.BoletaBindingSource.DataSource = Me.ControlinventarioDataSet
        '
        'BoletaTableAdapter
        '
        Me.BoletaTableAdapter.ClearBeforeFill = True
        '
        'N_boletaLabel
        '
        N_boletaLabel.AutoSize = True
        N_boletaLabel.Location = New System.Drawing.Point(29, 50)
        N_boletaLabel.Name = "N_boletaLabel"
        N_boletaLabel.Size = New System.Drawing.Size(54, 13)
        N_boletaLabel.TabIndex = 2
        N_boletaLabel.Text = "N° boleta:"
        '
        'N_boletaTextBox
        '
        Me.N_boletaTextBox.Enabled = False
        Me.N_boletaTextBox.Location = New System.Drawing.Point(123, 47)
        Me.N_boletaTextBox.Name = "N_boletaTextBox"
        Me.N_boletaTextBox.Size = New System.Drawing.Size(83, 20)
        Me.N_boletaTextBox.TabIndex = 3
        '
        'Rut_empresaLabel
        '
        Rut_empresaLabel.AutoSize = True
        Rut_empresaLabel.Location = New System.Drawing.Point(29, 76)
        Rut_empresaLabel.Name = "Rut_empresaLabel"
        Rut_empresaLabel.Size = New System.Drawing.Size(65, 13)
        Rut_empresaLabel.TabIndex = 4
        Rut_empresaLabel.Text = "rut empresa:"
        '
        'Rut_empresaTextBox
        '
        Me.Rut_empresaTextBox.Location = New System.Drawing.Point(123, 73)
        Me.Rut_empresaTextBox.Name = "Rut_empresaTextBox"
        Me.Rut_empresaTextBox.Size = New System.Drawing.Size(83, 20)
        Me.Rut_empresaTextBox.TabIndex = 5
        '
        'Rut_clienteLabel
        '
        Rut_clienteLabel.AutoSize = True
        Rut_clienteLabel.Location = New System.Drawing.Point(252, 72)
        Rut_clienteLabel.Name = "Rut_clienteLabel"
        Rut_clienteLabel.Size = New System.Drawing.Size(56, 13)
        Rut_clienteLabel.TabIndex = 6
        Rut_clienteLabel.Text = "rut cliente:"
        '
        'Rut_clienteTextBox
        '
        Me.Rut_clienteTextBox.Location = New System.Drawing.Point(327, 69)
        Me.Rut_clienteTextBox.Name = "Rut_clienteTextBox"
        Me.Rut_clienteTextBox.Size = New System.Drawing.Size(83, 20)
        Me.Rut_clienteTextBox.TabIndex = 7
        '
        'Nombre_empresaLabel
        '
        Nombre_empresaLabel.AutoSize = True
        Nombre_empresaLabel.Location = New System.Drawing.Point(29, 102)
        Nombre_empresaLabel.Name = "Nombre_empresaLabel"
        Nombre_empresaLabel.Size = New System.Drawing.Size(88, 13)
        Nombre_empresaLabel.TabIndex = 8
        Nombre_empresaLabel.Text = "nombre empresa:"
        '
        'Nombre_empresaTextBox
        '
        Me.Nombre_empresaTextBox.Location = New System.Drawing.Point(123, 99)
        Me.Nombre_empresaTextBox.Name = "Nombre_empresaTextBox"
        Me.Nombre_empresaTextBox.Size = New System.Drawing.Size(83, 20)
        Me.Nombre_empresaTextBox.TabIndex = 9
        '
        'DirecionLabel
        '
        DirecionLabel.AutoSize = True
        DirecionLabel.Location = New System.Drawing.Point(29, 128)
        DirecionLabel.Name = "DirecionLabel"
        DirecionLabel.Size = New System.Drawing.Size(47, 13)
        DirecionLabel.TabIndex = 10
        DirecionLabel.Text = "direcion:"
        '
        'DirecionTextBox
        '
        Me.DirecionTextBox.Location = New System.Drawing.Point(123, 125)
        Me.DirecionTextBox.Name = "DirecionTextBox"
        Me.DirecionTextBox.Size = New System.Drawing.Size(83, 20)
        Me.DirecionTextBox.TabIndex = 11
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(271, 47)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(37, 13)
        FechaLabel.TabIndex = 12
        FechaLabel.Text = "fecha:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(284, 366)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 14
        TotalLabel.Text = "Total:"
        AddHandler TotalLabel.Click, AddressOf Me.TotalLabel_Click
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(329, 363)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(83, 20)
        Me.TotalTextBox.TabIndex = 15
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(327, 41)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(83, 20)
        Me.FechaDateTimePicker.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(19, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VerBoleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 440)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(N_boletaLabel)
        Me.Controls.Add(Me.N_boletaTextBox)
        Me.Controls.Add(Rut_empresaLabel)
        Me.Controls.Add(Me.Rut_empresaTextBox)
        Me.Controls.Add(Rut_clienteLabel)
        Me.Controls.Add(Me.Rut_clienteTextBox)
        Me.Controls.Add(Nombre_empresaLabel)
        Me.Controls.Add(Me.Nombre_empresaTextBox)
        Me.Controls.Add(DirecionLabel)
        Me.Controls.Add(Me.DirecionTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.Detalle_boletaDataGridView)
        Me.Controls.Add(Me.Detalle_boletaBindingNavigator)
        Me.Name = "VerBoleta"
        Me.Text = "VerBoleta"
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalle_boletaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalle_boletaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Detalle_boletaBindingNavigator.ResumeLayout(False)
        Me.Detalle_boletaBindingNavigator.PerformLayout()
        CType(Me.Detalle_boletaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoletaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ControlinventarioDataSet As ControlinventarioDataSet
    Friend WithEvents Detalle_boletaBindingSource As BindingSource
    Friend WithEvents Detalle_boletaTableAdapter As ControlinventarioDataSetTableAdapters.detalle_boletaTableAdapter
    Friend WithEvents TableAdapterManager As ControlinventarioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Detalle_boletaBindingNavigator As BindingNavigator
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
    Friend WithEvents Detalle_boletaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Detalle_boletaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents BoletaTableAdapter As ControlinventarioDataSetTableAdapters.boletaTableAdapter
    Friend WithEvents BoletaBindingSource As BindingSource
    Friend WithEvents N_boletaTextBox As TextBox
    Friend WithEvents Rut_empresaTextBox As TextBox
    Friend WithEvents Rut_clienteTextBox As TextBox
    Friend WithEvents Nombre_empresaTextBox As TextBox
    Friend WithEvents DirecionTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents Button1 As Button
End Class
