<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VerBoleta
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
        Dim N_boletaLabel As System.Windows.Forms.Label
        Dim Rut_empresaLabel As System.Windows.Forms.Label
        Dim Rut_clienteLabel As System.Windows.Forms.Label
        Dim Nombre_empresaLabel As System.Windows.Forms.Label
        Dim DirecionLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.N_boletaTextBox = New System.Windows.Forms.TextBox()
        Me.Rut_empresaTextBox = New System.Windows.Forms.TextBox()
        Me.Rut_clienteTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_empresaTextBox = New System.Windows.Forms.TextBox()
        Me.DirecionTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.ControlinventarioDataSet = New ControlDeInventario.ControlinventarioDataSet()
        Me.Detalle_boletaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Detalle_boletaTableAdapter = New ControlDeInventario.ControlinventarioDataSetTableAdapters.detalle_boletaTableAdapter()
        Me.TableAdapterManager = New ControlDeInventario.ControlinventarioDataSetTableAdapters.TableAdapterManager()
        Me.Detalle_boletaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        N_boletaLabel = New System.Windows.Forms.Label()
        Rut_empresaLabel = New System.Windows.Forms.Label()
        Rut_clienteLabel = New System.Windows.Forms.Label()
        Nombre_empresaLabel = New System.Windows.Forms.Label()
        DirecionLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalle_boletaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalle_boletaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'N_boletaLabel
        '
        N_boletaLabel.AutoSize = True
        N_boletaLabel.Location = New System.Drawing.Point(21, 26)
        N_boletaLabel.Name = "N_boletaLabel"
        N_boletaLabel.Size = New System.Drawing.Size(54, 13)
        N_boletaLabel.TabIndex = 18
        N_boletaLabel.Text = "N° boleta:"
        '
        'Rut_empresaLabel
        '
        Rut_empresaLabel.AutoSize = True
        Rut_empresaLabel.Location = New System.Drawing.Point(21, 52)
        Rut_empresaLabel.Name = "Rut_empresaLabel"
        Rut_empresaLabel.Size = New System.Drawing.Size(65, 13)
        Rut_empresaLabel.TabIndex = 20
        Rut_empresaLabel.Text = "rut empresa:"
        '
        'Rut_clienteLabel
        '
        Rut_clienteLabel.AutoSize = True
        Rut_clienteLabel.Location = New System.Drawing.Point(244, 48)
        Rut_clienteLabel.Name = "Rut_clienteLabel"
        Rut_clienteLabel.Size = New System.Drawing.Size(56, 13)
        Rut_clienteLabel.TabIndex = 22
        Rut_clienteLabel.Text = "rut cliente:"
        '
        'Nombre_empresaLabel
        '
        Nombre_empresaLabel.AutoSize = True
        Nombre_empresaLabel.Location = New System.Drawing.Point(21, 78)
        Nombre_empresaLabel.Name = "Nombre_empresaLabel"
        Nombre_empresaLabel.Size = New System.Drawing.Size(88, 13)
        Nombre_empresaLabel.TabIndex = 24
        Nombre_empresaLabel.Text = "nombre empresa:"
        '
        'DirecionLabel
        '
        DirecionLabel.AutoSize = True
        DirecionLabel.Location = New System.Drawing.Point(21, 104)
        DirecionLabel.Name = "DirecionLabel"
        DirecionLabel.Size = New System.Drawing.Size(47, 13)
        DirecionLabel.TabIndex = 26
        DirecionLabel.Text = "direcion:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(263, 23)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(37, 13)
        FechaLabel.TabIndex = 28
        FechaLabel.Text = "fecha:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(276, 342)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 30
        TotalLabel.Text = "Total:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'N_boletaTextBox
        '
        Me.N_boletaTextBox.Enabled = False
        Me.N_boletaTextBox.Location = New System.Drawing.Point(115, 23)
        Me.N_boletaTextBox.Name = "N_boletaTextBox"
        Me.N_boletaTextBox.Size = New System.Drawing.Size(83, 20)
        Me.N_boletaTextBox.TabIndex = 19
        '
        'Rut_empresaTextBox
        '
        Me.Rut_empresaTextBox.Location = New System.Drawing.Point(115, 49)
        Me.Rut_empresaTextBox.Name = "Rut_empresaTextBox"
        Me.Rut_empresaTextBox.Size = New System.Drawing.Size(83, 20)
        Me.Rut_empresaTextBox.TabIndex = 21
        '
        'Rut_clienteTextBox
        '
        Me.Rut_clienteTextBox.Location = New System.Drawing.Point(319, 45)
        Me.Rut_clienteTextBox.Name = "Rut_clienteTextBox"
        Me.Rut_clienteTextBox.Size = New System.Drawing.Size(83, 20)
        Me.Rut_clienteTextBox.TabIndex = 23
        '
        'Nombre_empresaTextBox
        '
        Me.Nombre_empresaTextBox.Location = New System.Drawing.Point(115, 75)
        Me.Nombre_empresaTextBox.Name = "Nombre_empresaTextBox"
        Me.Nombre_empresaTextBox.Size = New System.Drawing.Size(83, 20)
        Me.Nombre_empresaTextBox.TabIndex = 25
        '
        'DirecionTextBox
        '
        Me.DirecionTextBox.Location = New System.Drawing.Point(115, 101)
        Me.DirecionTextBox.Name = "DirecionTextBox"
        Me.DirecionTextBox.Size = New System.Drawing.Size(83, 20)
        Me.DirecionTextBox.TabIndex = 27
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(319, 17)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(83, 20)
        Me.FechaDateTimePicker.TabIndex = 29
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(321, 339)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(83, 20)
        Me.TotalTextBox.TabIndex = 31
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
        Me.TableAdapterManager.boletaTableAdapter = Nothing
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
        'Detalle_boletaDataGridView
        '
        Me.Detalle_boletaDataGridView.AllowUserToAddRows = False
        Me.Detalle_boletaDataGridView.AllowUserToDeleteRows = False
        Me.Detalle_boletaDataGridView.AutoGenerateColumns = False
        Me.Detalle_boletaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Detalle_boletaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Detalle_boletaDataGridView.DataSource = Me.Detalle_boletaBindingSource
        Me.Detalle_boletaDataGridView.Location = New System.Drawing.Point(58, 141)
        Me.Detalle_boletaDataGridView.Name = "Detalle_boletaDataGridView"
        Me.Detalle_boletaDataGridView.ReadOnly = True
        Me.Detalle_boletaDataGridView.Size = New System.Drawing.Size(344, 183)
        Me.Detalle_boletaDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "n_boleta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "n_boleta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "cod_prodcuto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "cod_prodcuto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'VerBoleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 414)
        Me.Controls.Add(Me.Detalle_boletaDataGridView)
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
        Me.Name = "VerBoleta"
        Me.Text = "VerBoleta"
        CType(Me.ControlinventarioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalle_boletaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalle_boletaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents N_boletaTextBox As TextBox
    Friend WithEvents Rut_empresaTextBox As TextBox
    Friend WithEvents Rut_clienteTextBox As TextBox
    Friend WithEvents Nombre_empresaTextBox As TextBox
    Friend WithEvents DirecionTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents ControlinventarioDataSet As ControlinventarioDataSet
    Friend WithEvents Detalle_boletaBindingSource As BindingSource
    Friend WithEvents Detalle_boletaTableAdapter As ControlinventarioDataSetTableAdapters.detalle_boletaTableAdapter
    Friend WithEvents TableAdapterManager As ControlinventarioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Detalle_boletaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
