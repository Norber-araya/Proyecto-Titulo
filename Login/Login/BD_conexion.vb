Imports System.Configuration
Imports System.Data.OleDb
Public Class BD_conexion
    Dim conexion As New System.Data.OleDb.OleDbConnection()
    Dim direccion As ConnectionStringSettings
    Dim comando As OleDbCommand
    Sub conectar()
        ' hay que entrar a app.config y cambiar los valores connection string x nuestra conexion y name x un nombre
        direccion = ConfigurationManager.ConnectionStrings("conexion")
        conexion.ConnectionString = direccion.ConnectionString
        conexion.Open()

        'MsgBox("conectado")
    End Sub

    Public Sub insertar_Usu(ID_Usuario As String, nombre_prod As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from Usuario where ID_Usuario ='" + ID_Usuario + "'", conexion)

        Dim validar As Integer

        validar = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validar > 0 Then

            'Si existe el Cliente
            MsgBox("El Producto: " & UCase(ID_Usuario) & " ya existe en la base de datos")

        Else

            MsgBox("Tipo de usuario: " & UCase(ID_Usuario) & "XD")

        End If

        desconectar()
    End Sub


    Sub desconectar()
        conexion.Close()
    End Sub
End Class
