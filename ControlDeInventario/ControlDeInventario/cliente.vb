Public Class cliente
    Dim bdconexion As New BD_conexion
    Public rut As String
    Public tipo As String
    Public nombre As String
    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.ControlinventarioDataSet.cliente)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clienteEdid.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        bdconexion.insertar_cliente(Rut_clienteTextBox.Text, NombreTextBox.Text, EmailTextBox.Text, FonoTextBox.Text, DireccionTextBox.Text, ComunaTextBox.Text, CiudadTextBox.Text)
        Me.ClienteTableAdapter.Fill(Me.ControlinventarioDataSet.cliente)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Navegacion.Show()
        Me.Close()
    End Sub
End Class