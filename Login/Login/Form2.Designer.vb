<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim ID_UsuarioLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApelllidoLabel As System.Windows.Forms.Label
        Dim ContactoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim CargoLabel As System.Windows.Forms.Label
        Dim ID_UsuarioLabel1 As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim ID_TipoUsuarioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.LoginnDataSet = New Login.LoginnDataSet()
        Me.Detalle_UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Detalle_UsuarioTableAdapter = New Login.LoginnDataSetTableAdapters.Detalle_UsuarioTableAdapter()
        Me.TableAdapterManager = New Login.LoginnDataSetTableAdapters.TableAdapterManager()
        Me.UsuarioTableAdapter = New Login.LoginnDataSetTableAdapters.UsuarioTableAdapter()
        Me.Detalle_UsuarioBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Detalle_UsuarioBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ID_UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApelllidoTextBox = New System.Windows.Forms.TextBox()
        Me.ContactoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.CargoTextBox = New System.Windows.Forms.TextBox()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID_UsuarioTextBox1 = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ID_TipoUsuarioTextBox = New System.Windows.Forms.TextBox()
        ID_UsuarioLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApelllidoLabel = New System.Windows.Forms.Label()
        ContactoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        CargoLabel = New System.Windows.Forms.Label()
        ID_UsuarioLabel1 = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        ID_TipoUsuarioLabel = New System.Windows.Forms.Label()
        CType(Me.LoginnDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalle_UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalle_UsuarioBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Detalle_UsuarioBindingNavigator.SuspendLayout()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_UsuarioLabel
        '
        ID_UsuarioLabel.AutoSize = True
        ID_UsuarioLabel.Location = New System.Drawing.Point(64, 47)
        ID_UsuarioLabel.Name = "ID_UsuarioLabel"
        ID_UsuarioLabel.Size = New System.Drawing.Size(60, 13)
        ID_UsuarioLabel.TabIndex = 1
        ID_UsuarioLabel.Text = "ID Usuario:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(64, 73)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'ApelllidoLabel
        '
        ApelllidoLabel.AutoSize = True
        ApelllidoLabel.Location = New System.Drawing.Point(64, 99)
        ApelllidoLabel.Name = "ApelllidoLabel"
        ApelllidoLabel.Size = New System.Drawing.Size(49, 13)
        ApelllidoLabel.TabIndex = 5
        ApelllidoLabel.Text = "Apelllido:"
        '
        'ContactoLabel
        '
        ContactoLabel.AutoSize = True
        ContactoLabel.Location = New System.Drawing.Point(64, 125)
        ContactoLabel.Name = "ContactoLabel"
        ContactoLabel.Size = New System.Drawing.Size(53, 13)
        ContactoLabel.TabIndex = 7
        ContactoLabel.Text = "Contacto:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(64, 151)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(55, 13)
        DireccionLabel.TabIndex = 9
        DireccionLabel.Text = "Direccion:"
        '
        'CargoLabel
        '
        CargoLabel.AutoSize = True
        CargoLabel.Location = New System.Drawing.Point(64, 177)
        CargoLabel.Name = "CargoLabel"
        CargoLabel.Size = New System.Drawing.Size(38, 13)
        CargoLabel.TabIndex = 11
        CargoLabel.Text = "Cargo:"
        '
        'ID_UsuarioLabel1
        '
        ID_UsuarioLabel1.AutoSize = True
        ID_UsuarioLabel1.Location = New System.Drawing.Point(52, 236)
        ID_UsuarioLabel1.Name = "ID_UsuarioLabel1"
        ID_UsuarioLabel1.Size = New System.Drawing.Size(60, 13)
        ID_UsuarioLabel1.TabIndex = 13
        ID_UsuarioLabel1.Text = "ID Usuario:"
        AddHandler ID_UsuarioLabel1.Click, AddressOf Me.ID_UsuarioLabel1_Click
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(52, 262)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 15
        PasswordLabel.Text = "Password:"
        '
        'ID_TipoUsuarioLabel
        '
        ID_TipoUsuarioLabel.AutoSize = True
        ID_TipoUsuarioLabel.Location = New System.Drawing.Point(52, 288)
        ID_TipoUsuarioLabel.Name = "ID_TipoUsuarioLabel"
        ID_TipoUsuarioLabel.Size = New System.Drawing.Size(84, 13)
        ID_TipoUsuarioLabel.TabIndex = 17
        ID_TipoUsuarioLabel.Text = "ID Tipo Usuario:"
        '
        'LoginnDataSet
        '
        Me.LoginnDataSet.DataSetName = "LoginnDataSet"
        Me.LoginnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Detalle_UsuarioBindingSource
        '
        Me.Detalle_UsuarioBindingSource.DataMember = "Detalle_Usuario"
        Me.Detalle_UsuarioBindingSource.DataSource = Me.LoginnDataSet
        '
        'Detalle_UsuarioTableAdapter
        '
        Me.Detalle_UsuarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Detalle_UsuarioTableAdapter = Me.Detalle_UsuarioTableAdapter
        Me.TableAdapterManager.Tipo_UsuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Login.LoginnDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Me.UsuarioTableAdapter
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'Detalle_UsuarioBindingNavigator
        '
        Me.Detalle_UsuarioBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Detalle_UsuarioBindingNavigator.BindingSource = Me.Detalle_UsuarioBindingSource
        Me.Detalle_UsuarioBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Detalle_UsuarioBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Detalle_UsuarioBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Detalle_UsuarioBindingNavigatorSaveItem})
        Me.Detalle_UsuarioBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Detalle_UsuarioBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Detalle_UsuarioBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Detalle_UsuarioBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Detalle_UsuarioBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Detalle_UsuarioBindingNavigator.Name = "Detalle_UsuarioBindingNavigator"
        Me.Detalle_UsuarioBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Detalle_UsuarioBindingNavigator.Size = New System.Drawing.Size(337, 25)
        Me.Detalle_UsuarioBindingNavigator.TabIndex = 0
        Me.Detalle_UsuarioBindingNavigator.Text = "BindingNavigator1"
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
        'Detalle_UsuarioBindingNavigatorSaveItem
        '
        Me.Detalle_UsuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Detalle_UsuarioBindingNavigatorSaveItem.Image = CType(resources.GetObject("Detalle_UsuarioBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Detalle_UsuarioBindingNavigatorSaveItem.Name = "Detalle_UsuarioBindingNavigatorSaveItem"
        Me.Detalle_UsuarioBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Detalle_UsuarioBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ID_UsuarioTextBox
        '
        Me.ID_UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_UsuarioBindingSource, "ID_Usuario", True))
        Me.ID_UsuarioTextBox.Location = New System.Drawing.Point(130, 44)
        Me.ID_UsuarioTextBox.Name = "ID_UsuarioTextBox"
        Me.ID_UsuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_UsuarioTextBox.TabIndex = 2
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_UsuarioBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(130, 70)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 4
        '
        'ApelllidoTextBox
        '
        Me.ApelllidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_UsuarioBindingSource, "Apelllido", True))
        Me.ApelllidoTextBox.Location = New System.Drawing.Point(130, 96)
        Me.ApelllidoTextBox.Name = "ApelllidoTextBox"
        Me.ApelllidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApelllidoTextBox.TabIndex = 6
        '
        'ContactoTextBox
        '
        Me.ContactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_UsuarioBindingSource, "Contacto", True))
        Me.ContactoTextBox.Location = New System.Drawing.Point(130, 122)
        Me.ContactoTextBox.Name = "ContactoTextBox"
        Me.ContactoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContactoTextBox.TabIndex = 8
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_UsuarioBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(130, 148)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTextBox.TabIndex = 10
        '
        'CargoTextBox
        '
        Me.CargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_UsuarioBindingSource, "Cargo", True))
        Me.CargoTextBox.Location = New System.Drawing.Point(130, 174)
        Me.CargoTextBox.Name = "CargoTextBox"
        Me.CargoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CargoTextBox.TabIndex = 12
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.LoginnDataSet
        '
        'ID_UsuarioTextBox1
        '
        Me.ID_UsuarioTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "ID_Usuario", True))
        Me.ID_UsuarioTextBox1.Location = New System.Drawing.Point(142, 233)
        Me.ID_UsuarioTextBox1.Name = "ID_UsuarioTextBox1"
        Me.ID_UsuarioTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.ID_UsuarioTextBox1.TabIndex = 14
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(142, 259)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 16
        '
        'ID_TipoUsuarioTextBox
        '
        Me.ID_TipoUsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "ID_TipoUsuario", True))
        Me.ID_TipoUsuarioTextBox.Location = New System.Drawing.Point(142, 285)
        Me.ID_TipoUsuarioTextBox.Name = "ID_TipoUsuarioTextBox"
        Me.ID_TipoUsuarioTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_TipoUsuarioTextBox.TabIndex = 18
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 349)
        Me.Controls.Add(ID_UsuarioLabel1)
        Me.Controls.Add(Me.ID_UsuarioTextBox1)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(ID_TipoUsuarioLabel)
        Me.Controls.Add(Me.ID_TipoUsuarioTextBox)
        Me.Controls.Add(ID_UsuarioLabel)
        Me.Controls.Add(Me.ID_UsuarioTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ApelllidoLabel)
        Me.Controls.Add(Me.ApelllidoTextBox)
        Me.Controls.Add(ContactoLabel)
        Me.Controls.Add(Me.ContactoTextBox)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(CargoLabel)
        Me.Controls.Add(Me.CargoTextBox)
        Me.Controls.Add(Me.Detalle_UsuarioBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.LoginnDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalle_UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalle_UsuarioBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Detalle_UsuarioBindingNavigator.ResumeLayout(False)
        Me.Detalle_UsuarioBindingNavigator.PerformLayout()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginnDataSet As LoginnDataSet
    Friend WithEvents Detalle_UsuarioBindingSource As BindingSource
    Friend WithEvents Detalle_UsuarioTableAdapter As LoginnDataSetTableAdapters.Detalle_UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As LoginnDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Detalle_UsuarioBindingNavigator As BindingNavigator
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
    Friend WithEvents Detalle_UsuarioBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UsuarioTableAdapter As LoginnDataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents ID_UsuarioTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApelllidoTextBox As TextBox
    Friend WithEvents ContactoTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents CargoTextBox As TextBox
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents ID_UsuarioTextBox1 As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents ID_TipoUsuarioTextBox As TextBox
End Class
