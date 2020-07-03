Imports System.Data.SqlClient
Public Class Bodega
    Dim bdconexion As New BD_conexion
    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")
    End Function

    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub Bodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.DataSource = producto()
    End Sub
    Public Function producto() As DataTable
        Dim porfa As New DataTable
        Using connection = GetConnection()
            connection.Open()

            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select * from producto"
                Dim reader = command.ExecuteReader()
                'Dim r As SqlDataReader = command.ExecuteReader()
                porfa.Load(reader)


            End Using
            Return porfa
        End Using

    End Function
    Public Sub dato2()

        Dim comando = New SqlDataAdapter(" select * from producto where cod_producto LIKE'" & TextBox1.Text & "%'", GetConnection)
        Dim DS As New DataSet
        comando.Fill(DS, "producto")
        DataGridView1.DataSource = DS.Tables("producto")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub DataGridView1_CellFormatting_1(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If Me.DataGridView1.Columns(e.ColumnIndex).Name = "cantidad" Then

            If e.Value IsNot Nothing Then
                If e.Value.[GetType]() <> GetType(System.DBNull) Then
                    'Stock menor a 20'

                    If Convert.ToInt32(e.Value) <= 20 Then
                        e.CellStyle.BackColor = Color.LightSalmon
                        e.CellStyle.ForeColor = Color.Black

                    End If
                    'Stock menor a 10'
                    If Convert.ToInt32(e.Value) <= 10 Then
                        e.CellStyle.BackColor = Color.Red
                        e.CellStyle.ForeColor = Color.Black
                    End If
                    If Convert.ToInt32(e.Value) > 20 Then
                        e.CellStyle.BackColor = Color.LightGreen
                        e.CellStyle.ForeColor = Color.Black
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        dato2()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Navegacion.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        For Each Fila As DataGridViewRow In DataGridView1.Rows

            If Fila.Cells("eliminar").Value <> Nothing Then
                Dim dato As String = Fila.Cells(1).Value.ToString
                bdconexion.eliminar_prod(dato)
                'bdconexion.insertar_registro()

            End If

        Next
        Me.ProductoTableAdapter.Fill(Me.ControlinventarioDataSet.producto)

    End Sub
End Class