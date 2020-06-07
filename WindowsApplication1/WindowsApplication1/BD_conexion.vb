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
    Public Sub insertar_prov(rut_prov As String, nombre_prov As String, direccion As String, contacto As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from proveedor where rut_prov ='" + rut_prov + "'", conexion)

        Dim validar As Integer

        validar = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validar > 0 Then

            'Si existe el Proveedor 
            MsgBox("El Proveedor: " & UCase(nombre_prov) & " ya existe en la base de datos")

        Else

            comando = New OleDbCommand("INSERT INTO proveedor (`rut_prov`, `nombre_prov`, `direccion`, `contacto`) VALUES ('" + rut_prov + "','" + nombre_prov + "','" & direccion & "','" + contacto + "')", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Proveedor: " & UCase(nombre_prov) & " ha sido ingresado con exito")


        End If

        desconectar()
    End Sub
    Public Sub editar_prov(rut_prov As String, nombre_prov As String, direccion As String, contacto As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from proveedor where rut_prov ='" + rut_prov + "'", conexion)

        Dim validador As Integer
        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then

            comando = New OleDbCommand("UPDATE proveedor SET rut_prov ='" + rut_prov + "', nombre_prov ='" + nombre_prov + "',direccion ='" + direccion + "', contacto ='" + contacto + "' where rut_prov= '" + rut_prov + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Proveedor: " & UCase(nombre_prov) & " fue actualizado")
        Else

            MsgBox("El Proveedor: " & UCase(nombre_prov) & " No existe en la base de datos")

        End If

        desconectar()
    End Sub

    Sub eliminar_prov(rut_prov As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from proveedor where rut_prov ='" + rut_prov + "'", conexion)

        Dim validador As Integer

        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then
            comando = New OleDbCommand("DELETE FROM proveedor WHERE rut_prov ='" + rut_prov + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Proveedor: " & UCase(rut_prov) & " ha sido borrado")
        Else
            MsgBox("El Proveedor: " & UCase(rut_prov) & " no existe")
        End If

        desconectar()

    End Sub
    Public Sub insertar_prod(id As String, nombre_prod As String, precio As String, descripcion As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from productos where id ='" + id + "'", conexion)

        Dim validar As Integer

        validar = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validar > 0 Then

            'Si existe el Producto
            MsgBox("El Producto: " & UCase(nombre_prod) & " ya existe en la base de datos")

        Else

            comando = New OleDbCommand("INSERT INTO productos (`id`, `nombre_prod`, `precio`, `descripcion`) VALUES ('" + id + "','" + nombre_prod + "','" & precio & "','" + descripcion + "')", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Producto: " & UCase(nombre_prod) & " ha sido ingresado con exito")


        End If

        desconectar()
    End Sub
    Public Sub editar_prod(id As String, nombre_prod As String, precio As String, descripcion As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from productos where id ='" + id + "'", conexion)

        Dim validador As Integer
        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then

            comando = New OleDbCommand("UPDATE productos SET id ='" + id + "', nombre_prod ='" + nombre_prod + "',precio ='" + precio + "', descripcion ='" + descripcion + "' where id= '" + id + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Producto: " & UCase(nombre_prod) & " fue actualizado")
        Else

            MsgBox("El Producto: " & UCase(nombre_prod) & " No existe en la base de datos")

        End If

        desconectar()
    End Sub
    Sub eliminar_prod(id As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from productos where id ='" + id + "'", conexion)

        Dim validador As Integer

        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then
            comando = New OleDbCommand("DELETE FROM productos WHERE id ='" + id + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Producto: " & UCase(id) & " ha sido borrado")
        Else
            MsgBox("El Producto: " & UCase(id) & " no existe")
        End If

        desconectar()
    End Sub
    Sub desconectar()
        conexion.Close()
    End Sub
End Class
