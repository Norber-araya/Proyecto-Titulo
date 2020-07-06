Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class Consulta
    Private Sub Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView2.Visible = False
        TextBox1.Visible = False
        Label3.Visible = False
    End Sub
    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")
    End Function


    Public Function productoVendido(fromDate As DateTime, toDate As DateTime) As DataTable
        Dim porfa As New DataTable
        Using connection = GetConnection()
            connection.Open()

            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = "select 
                                       p.cod_producto,
                                       p.nombre,
                                       p.precio as PrecioUnitario,
                                       sum(r.cantidad) as CantidadTotal,
                                       sum(r.precio*r.cantidad)as total
                                       from 
                                       registro r
                                       inner join producto p on p.cod_producto=r.id_producto
                                       where r.fecha between @startDate and @endDate and r.tipo='venta'
                                       group by 
                                       p.cod_producto, p.nombre, p.precio
                                       order by CantidadTotal desc"
                command.Parameters.Add("@startDate", SqlDbType.Date).Value = fromDate
                command.Parameters.Add("@endDate", SqlDbType.Date).Value = toDate
                Dim reader = command.ExecuteReader()
                'Dim r As SqlDataReader = command.ExecuteReader()


                Dim can As Integer = 0
                porfa.Load(reader)

            End Using
            Return porfa
        End Using
    End Function
    Public Sub dato1()
        Dim total As String
        TextBox1.Text = "0"
        If DataGridView2.Rows.Count > 0 Then

            For Each Fila As DataGridViewRow In DataGridView2.Rows

                If Not Fila Is Nothing Then
                    total = Fila.Cells("total").Value

                    TextBox1.Text = Val(total) + Val(TextBox1.Text)

                End If
            Next

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fromData = DateTimePicker1.Value
        Dim toDate = DateTimePicker2.Value
        DataGridView2.DataSource = productoVendido(fromData, New DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59))
        DataGridView2.Visible = True
        Label3.Visible = True
        TextBox1.Visible = True
        dato1()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fromData = DateTime.Today
        Dim toDate = DateTime.Now
        DataGridView2.DataSource = productoVendido(fromData, toDate)
        DataGridView2.Visible = True
        Label3.Visible = True
        TextBox1.Visible = True
        dato1()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim fromData = DateTime.Today.AddDays(-7)
        Dim toDate = DateTime.Now
        DataGridView2.DataSource = productoVendido(fromData, toDate)
        DataGridView2.Visible = True
        Label3.Visible = True
        TextBox1.Visible = True
        dato1()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim fromData = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        Dim toDate = DateTime.Now
        DataGridView2.DataSource = productoVendido(fromData, toDate)
        DataGridView2.Visible = True
        Label3.Visible = True
        TextBox1.Visible = True
        dato1()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim fromData = New DateTime(DateTime.Now.Year, 1, 1)
        Dim toDate = DateTime.Now
        DataGridView2.DataSource = productoVendido(fromData, toDate)
        DataGridView2.Visible = True
        Label3.Visible = True
        TextBox1.Visible = True
        dato1()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub DataGridView2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView2.CellFormatting

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Navegacion.Show()
        Close()
    End Sub
End Class