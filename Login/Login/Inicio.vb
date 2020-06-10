Public Class Inicio
    Dim bdconexion As New BD_conexion
    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Registrarse.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Iniciar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Iniciar_Click_1(sender As Object, e As EventArgs) Handles Iniciar.Click
        bdconexion.insertar_Usu(Usuario.Text, Password.Text)
        Me.UsuarioTableAdapter.Fill(Me.LoginnDataSet.Usuario)
        If Me.UsuarioTableAdapter.BuscarDatos(Me.LoginnDataSet.Usuario, Usuario.Text, Password.Text) Then
            MsgBox("Bienvenido", MsgBoxStyle.Information)

        Else
            MsgBox("datos incorectos", MsgBoxStyle.Critical)


        End If
    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub
End Class