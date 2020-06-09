Imports System.Configuration
Imports System.Data.OleDb
Public Class BD_conexion
    Dim conexion As New System.Data.OleDb.OleDbConnection()
    Dim direccion As ConnectionStringSettings
    Dim comando As OleDbCommand
    Public Property ConfigurationManager As Object

    Sub conectar(

        ' hay que entrar a app.config y cambiar los valores connection string x nuestra conexion y name x un nombre
        direccion = ConfigurationManager.ConnectionStrings("conexion")
        conexion.ConnectionString = direccion.ConnectionString
        conexion.Open()

        'MsgBox("conectado")
    End Sub

End Class
