Imports System.Data.SqlClient
Public Class UsuarioEdid
    Dim bdconexion As New BD_conexion
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")
    Public rut2 As String
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RutTextBox1.Text = UsuarioDataGridView.CurrentRow.Cells.Item(1).Value.ToString
        NombreTextBox1.Text = UsuarioDataGridView.CurrentRow.Cells.Item(2).Value.ToString
        ContactoTextBox1.Text = UsuarioDataGridView.CurrentRow.Cells.Item(3).Value.ToString
        GeneroTextBox1.Text = UsuarioDataGridView.CurrentRow.Cells.Item(4).Value.ToString
        EmailTextBox1.Text = UsuarioDataGridView.CurrentRow.Cells.Item(7).Value.ToString
    End Sub

    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub UsuarioEdid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.ControlinventarioDataSet.usuario)

    End Sub
    Public Sub dato1()

        Dim comando = New SqlDataAdapter(" select * from usuario where rut LIKE'" & Busqueda.Text & "%'", conexion)
        Dim DS As New DataSet
        comando.Fill(DS, "usuario")
        UsuarioDataGridView.DataSource = DS.Tables("usuario")

    End Sub

    Private Sub UsuarioDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsuarioDataGridView.CellContentClick

    End Sub

    Private Sub Busqueda_TextChanged(sender As Object, e As EventArgs) Handles Busqueda.TextChanged
        dato1()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Usuario.Show()
        Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If RutTextBox1.Text = "" Or NombreTextBox1.Text = "" Or GeneroTextBox1.Text = "" Or EmailTextBox1.Text = "" Then
            MsgBox("Hay campos en blanco")
        Else
            bdconexion.editar_usuario(RutTextBox1.Text, rut2, NombreTextBox1.Text, ContactoTextBox1.Text, GeneroTextBox1.Text, EmailTextBox1.Text)
            Me.UsuarioTableAdapter.Fill(Me.ControlinventarioDataSet.usuario)
        End If
        


    End Sub

    Private Sub RutTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RutTextBox1.TextChanged
        rut2 = RutTextBox1.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each Fila As DataGridViewRow In UsuarioDataGridView.Rows

            If Fila.Cells("eliminar").Value <> Nothing Then
                Dim dato As String = Fila.Cells(1).Value.ToString
                bdconexion.eliminar_usuario(dato)

            End If

        Next
        Me.UsuarioTableAdapter.Fill(Me.ControlinventarioDataSet.usuario)

    End Sub
End Class