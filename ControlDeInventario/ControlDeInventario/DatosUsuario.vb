Imports System.Data.SqlClient
Public Class DatosUsuario
    Dim bdconexion As New BD_conexion
    Dim conexion As New SqlConnection("Data Source=.;Initial Catalog=Controlinventario;Integrated Security=True")
    Public rut As String
    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ControlinventarioDataSet)

    End Sub

    Private Sub DatosUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ControlinventarioDataSet.usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.ControlinventarioDataSet.usuario)
        Panel1.Visible = False
        dato1()
    End Sub
    Public Sub dato1()
        bdconexion.select_usuario(rut)

    End Sub

    Private Sub ContactoTextBox_TextChanged(sender As Object, e As EventArgs) Handles ContactoTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RutTextBox.Text = "" Or NombreTextBox.Text = "" Or GeneroTextBox.Text = "" Or EmailTextBox.Text = "" Then
            MsgBox("Hay campos en blanco")
        Else
            bdconexion.editar_ususrio(RutTextBox.Text, rut, NombreTextBox.Text, ContactoTextBox.Text, GeneroTextBox.Text, EmailTextBox.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel1.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CambiarContraseña.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class