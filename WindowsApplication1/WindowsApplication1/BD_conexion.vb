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
    Public Sub insertar_prov(rut_prov As String, nombre_prov As String, direccion As String, contacto As String, comuna As String, mail As String, ciudad As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from proveedor where rut_prov ='" + rut_prov + "'", conexion)

        Dim validar As Integer

        validar = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validar > 0 Then

            'Si existe el Cliente
            MsgBox("El Proveedor: " & UCase(nombre_prov) & " ya existe en la base de datos")

        Else

            comando = New OleDbCommand("INSERT INTO proveedor (`rut_prov`, `nombre_prov`, `direccion`, `contacto`, `comuna`, `mail`, `ciudad`) VALUES ('" + rut_prov + "','" + nombre_prov + "','" + direccion + "','" + contacto + "','" + comuna + "','" + mail + "','" + ciudad + "')", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Proveedor: " & UCase(nombre_prov) & " ha sido ingresado con exito")


        End If

        desconectar()
    End Sub
    Public Sub editar_prov(rut_prov As String, nombre_prov As String, direccion As String, contacto As String, comuna As String, mail As String, ciudad As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from proveedor where rut_prov ='" + rut_prov + "'", conexion)

        Dim validador As Integer
        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then

            comando = New OleDbCommand("UPDATE proveedor SET rut_prov ='" + rut_prov + "', nombre_prov ='" + nombre_prov + "',direccion ='" + direccion + "', contacto ='" + contacto + "',comuna ='" + comuna + "',mail ='" + mail + "',ciudad ='" + ciudad + "' where rut_prov= '" + rut_prov + "'", conexion)
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

            'Si existe el Cliente
            MsgBox("El Producto: " & UCase(nombre_prod) & " ya existe en la base de datos")

        Else

            comando = New OleDbCommand("INSERT INTO productos (`id`, `nombre_prod`, `precio`, `descripcion`) VALUES ('" + id + "','" + nombre_prod + "','" + precio + "','" + descripcion + "')", conexion)
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
    Public Sub insertar_bod(cod_bodega As String, id_producto As String, nombre_prod As String, cantidad As String, fecha As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from bodega where id_producto ='" + id_producto + "'", conexion)

        Dim validar As Integer

        validar = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validar > 0 Then

            'Si existe el Cliente
            MsgBox("El Producto: " & UCase(nombre_prod) & " ya existe en la base de datos")

        Else

            comando = New OleDbCommand("INSERT INTO bodega (`cod_bodega`,`id_producto`, `nombre_prod`, `cantidad`, `fecha `) VALUES ('" + cod_bodega + "','" + id_producto + "','" + nombre_prod + "','" + cantidad + "','" + fecha + "')", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Producto: " & UCase(nombre_prod) & " ha sido ingresado a bodega con exito")


        End If

        desconectar()
    End Sub
    Public Sub insertar_detalleprov(id_prod As String, id_prov As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from detalle_prov where id_prod ='" + id_prod + "'", conexion)

        Dim validar As Integer

        validar = CInt(comando.ExecuteScalar)

        If validar > 0 Then

            'Si existe el Cliente
            MsgBox("El Producto: " & UCase(id_prod) & " ya existe en la base de datos")

        Else
            comando.ExecuteNonQuery()

            comando = New OleDbCommand("INSERT INTO detalle_prov (`id_prod`, `id_prov`) VALUES ('" + id_prod + "','" + id_prov + "')", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Producto: " & UCase(id_prod) & " ha sido ingresadoal detalle con exito")
        End If
        desconectar()
    End Sub
    Public Sub insertar_factura(n_factura As String, nombre_prov As String, rut_prov As String, fono As String, comuna As String, direccion As String, mail As String, detalle As String, producto As String, valor_n As String, valor_t As String, fecha As String, observacion As String, iva As String, ciudad As String)

        conectar()

        comando = New OleDbCommand(" select count(*) from factura where n_factura ='" + n_factura + "'", conexion)

        Dim validar As Integer

        validar = CInt(comando.ExecuteScalar)

        If validar > 0 Then

            MsgBox("La factura: " & UCase(n_factura) & " ya existe en la base de datos")

        Else
            comando.ExecuteNonQuery()

            comando = New OleDbCommand("INSERT INTO factura (`n_factura`, `nombre_prov`, `rut_prov`, `fono`, `comuna`, `direccion`, `mail`, `detalle`, `producto`, `valor_n`, `valor_t`, `fecha`, `observacion`, `iva`, `ciudad`) VALUES ('" + n_factura + "','" + nombre_prov + "','" + rut_prov + "','" + fono + "','" + comuna + "','" + direccion + "','" + mail + "','" + detalle + "','" + producto + "','" + valor_n + "','" + valor_t + "','" + fecha + "','" + observacion + "','" + iva + "','" + ciudad + "')", conexion)
            comando.ExecuteNonQuery()
            MsgBox("La Factura " & UCase(n_factura) & " ha sido ingresadoal con exito")
        End If
        desconectar()
    End Sub
    Public Sub insertar_detalle_fac(n_factura As String, id_producto As String, cantidad As String, descripcion As String, precio_un As String, total As String)

        conectar()


        Dim validar As Integer
        validar = 1

        If validar < 0 Then

            'Si existe el Cliente
            MsgBox("la factura: " & UCase(n_factura) & " ya existe en la base de datos")

        Else
            comando.ExecuteNonQuery()

            comando = New OleDbCommand("INSERT INTO detalle_fac (`n_factura`, `id_producto`, `cantidad`, `descripcion`, `precio_un`, `total`) VALUES ('" + n_factura + "','" + id_producto + "','" + cantidad + "','" + descripcion + "','" + precio_un + "','" + total + "')", conexion)
            comando.ExecuteNonQuery()
            MsgBox("La factura: " & UCase(n_factura) & " ha sido ingresado a detalle con exito")
        End If
        desconectar()
    End Sub
    Sub desconectar()
        conexion.Close()
    End Sub
End Class
