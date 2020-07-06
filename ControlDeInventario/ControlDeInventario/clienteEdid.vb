Imports System.Data.SqlClient
Public Class clienteEdid
    Dim bdconexion As New BD_conexion
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")
    Public rut As String
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub ClienteEdid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.ControlinventarioDataSet.cliente)

    End Sub
    Public Sub dato1()

        Dim comando = New SqlDataAdapter(" select * from cliente where rut_cliente LIKE'" & TextBox1.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "cliente")
        ClienteDataGridView.DataSource = DS.Tables("cliente")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Rut_clienteTextBox.Text = "" Or NombreTextBox.Text = "" Or EmailTextBox.Text = "" Or FonoTextBox.Text = "" Or DireccionTextBox.Text = "" Or ComunaTextBox.Text = "" Or CiudadTextBox.Text = "" Then
            MsgBox("Hay campos en blanco ")
        Else
            bdconexion.editar_cliente(Rut_clienteTextBox.Text, rut, NombreTextBox.Text, EmailTextBox.Text, FonoTextBox.Text, DireccionTextBox.Text, ComunaTextBox.Text, CiudadTextBox.Text)
            Me.ClienteTableAdapter.Fill(Me.ControlinventarioDataSet.cliente)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Rut_clienteTextBox.Text = ClienteDataGridView.CurrentRow.Cells.Item(0).Value.ToString
        NombreTextBox.Text = ClienteDataGridView.CurrentRow.Cells.Item(1).Value.ToString
        EmailTextBox.Text = ClienteDataGridView.CurrentRow.Cells.Item(2).Value.ToString
        FonoTextBox.Text = ClienteDataGridView.CurrentRow.Cells.Item(3).Value.ToString
        DireccionTextBox.Text = ClienteDataGridView.CurrentRow.Cells.Item(4).Value.ToString
        ComunaTextBox.Text = ClienteDataGridView.CurrentRow.Cells.Item(5).Value.ToString
        CiudadTextBox.Text = ClienteDataGridView.CurrentRow.Cells.Item(6).Value.ToString
        rut = Rut_clienteTextBox.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cliente.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        dato1()
    End Sub
End Class