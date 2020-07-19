Imports System.Configuration
Imports System.Data.SqlClient
Public Class BD_conexion
    Dim conexion As New System.Data.SqlClient.SqlConnection()
    Dim direccion As ConnectionStringSettings
    Dim comando As SqlCommand
    Public tipo As String
    Sub conectar()
        ' hay que entrar a app.config y cambiar los valores connection string x nuestra conexion y name x un nombre
        direccion = ConfigurationManager.ConnectionStrings("conexion")
        conexion.ConnectionString = direccion.ConnectionString
        conexion.Open()

        'MsgBox("conectado")
    End Sub
    Sub dato1()
        If tipo = "100" Then
            Navegacion.permiso.Text = "Root"
            'Button4.Location = New Point(359, 10)
            'Navegacion.Size = New Size(100, 100)
        End If
        If tipo = "101" Then
            Navegacion.permiso.Text = "Administardor Gerente"
        End If
        If tipo = "102" Then
            Navegacion.permiso.Text = "Gerente"
            Navegacion.Button1.Visible = False 'proveedor
            Navegacion.Button2.Visible = False 'producto
            Navegacion.Button3.Visible = False 'usuario
            Navegacion.Button11.Visible = False 'cliente
            Navegacion.Button13.Visible = False 'boleta
            Navegacion.Button5.Visible = False 'Factura ingreso
            Navegacion.Button10.Visible = False 'Factura ventas
            Navegacion.Button4.Location = New Point(106, 127) 'bodega
            Navegacion.Button7.Location = New Point(106, 236) 'merma
            Navegacion.Button14.Location = New Point(387, 236) 'datos personales
            Navegacion.Button9.Location = New Point(683, 127) ' documento
            Navegacion.Button6.Location = New Point(675, 236) 'reportes
            Navegacion.Button12.Location = New Point(387, 370) 'Cerrar sesion
            Navegacion.Size = New Size(1000, 550)

        End If
        If tipo = "103" Then
            Navegacion.permiso.Text = "Operador Bodega"
            Navegacion.Button1.Visible = False 'proveedor
            Navegacion.Button2.Visible = False 'producto
            Navegacion.Button3.Visible = False 'usuario
            Navegacion.Button11.Visible = False 'cliente
            Navegacion.Button6.Visible = False 'Reportes 
            Navegacion.Button4.Location = New Point(106, 127) 'bodega
            Navegacion.Button7.Location = New Point(106, 236) 'merma
            Navegacion.Button5.Location = New Point(683, 127) 'factura ingreso
            Navegacion.Button10.Location = New Point(675, 236) 'factura egreso
            Navegacion.Button9.Location = New Point(685, 343) 'documento
            Navegacion.Button13.Location = New Point(106, 343) 'boleta
            Navegacion.Button14.Location = New Point(387, 236) 'datos personales
            Navegacion.Button12.Location = New Point(387, 450) 'Cerrar sesion


        End If
        If tipo = "104" Then
            Navegacion.permiso.Text = "Visita"
            Navegacion.Button1.Visible = False 'proveedor
            Navegacion.Button2.Visible = False 'producto
            Navegacion.Button3.Visible = False 'usuario
            Navegacion.Button11.Visible = False 'cliente
            Navegacion.Button13.Visible = False 'boleta
            Navegacion.Button5.Visible = False 'Factura ingreso
            Navegacion.Button10.Visible = False 'Factura ventas
            Navegacion.Button4.Location = New Point(106, 127) 'bodega
            Navegacion.Button7.Location = New Point(106, 236) 'merma
            Navegacion.Button14.Location = New Point(387, 236) 'datos personales
            Navegacion.Button9.Location = New Point(683, 127) ' documento
            Navegacion.Button6.Location = New Point(675, 236) 'reportes
            Navegacion.Button12.Location = New Point(387, 370) 'Cerrar sesion
            Navegacion.Size = New Size(1000, 550)
        End If
        If tipo = "105" Then
            Navegacion.permiso.Text = "Vendedor"
            Navegacion.Button1.Visible = False 'proveedor
            Navegacion.Button2.Visible = False 'producto
            Navegacion.Button3.Visible = False 'usuario
            Navegacion.Button11.Visible = False 'cliente
            'Navegacion.Button13.Visible = False 'boleta
            Navegacion.Button5.Visible = False 'Factura ingreso
            'Navegacion.Button10.Visible = False 'Factura ventas
            Navegacion.Button7.Visible = False 'merma
            Navegacion.Button6.Visible = False 'Reportes 
            Navegacion.Button4.Location = New Point(106, 127) 'bodega
            Navegacion.Button9.Location = New Point(106, 236) 'documento
            Navegacion.Button10.Location = New Point(678, 127) 'factura egreso
            Navegacion.Button13.Location = New Point(683, 236) 'boleta
            Navegacion.Button14.Location = New Point(387, 236) 'datos personales
            Navegacion.Button12.Location = New Point(387, 370) 'Cerrar sesion
            Navegacion.Size = New Size(1000, 550)

        End If

    End Sub

    'RECUPERAR CONTRASEÑA'
    Sub recuperar_contraseña(usuario As String)
        conectar()
        Dim corre As New Correo
        Dim enc As New Encriptador
        Dim contraseña As String
        Dim email As String

        comando = New SqlCommand(" select * from usuario where rut ='" & usuario & "'", conexion)
        Dim dr As SqlDataReader = comando.ExecuteReader()
        Dim VLDR_Nombre As Integer = 0
        If dr.Read() Then
            contraseña = Convert.ToString(dr("contraseña"))
            email = Convert.ToString(dr("email"))
            VLDR_Nombre = 1
        End If
        If VLDR_Nombre = 1 Then
            Dim emisor, pass, asunto As String
            emisor = "mioficinaS.A@gmail.com"
            pass = "mioficina1998"
            asunto = "Contraseña"
            Dim mensaje As String
            mensaje = "Su clave es: "
            mensaje = mensaje + enc.Desencriptar(contraseña)
            corre.enviarCorreo(emisor, pass, mensaje, asunto, email)
        ElseIf VLDR_Nombre = 0 Then
            MsgBox("usuario no existe")
        End If



        VLDR_Nombre = 0
        desconectar()
    End Sub
    'RECUPERAR CONTRASEÑA'

    'LOGIN'

    Sub select_usuario2(usuario As String, contraseña As String)
        Dim enc As New Encriptador
        conectar()

        comando = New SqlCommand(" select count(*) from usuario where rut ='" + usuario + "' and contraseña ='" + enc.Encriptar(contraseña) + "'", conexion)


        Dim VLDR_Nombre As Integer

        VLDR_Nombre = CInt(comando.ExecuteScalar)
        comando.ExecuteNonQuery()
        If VLDR_Nombre > 0 Then
            CambiarContraseña.Show()
            DatosUsuario.Hide()
        Else
            'Si NO existe el Cliente
            MsgBox("usuario o contraseña incorrecto")

        End If
        desconectar()
    End Sub
    Sub select_usuario(rut As String)

        conectar()

        comando = New SqlCommand(" select * from usuario where rut ='" & rut & "'", conexion)
        Dim dr As SqlDataReader = comando.ExecuteReader()
        If dr.Read() Then
            DatosUsuario.RutTextBox.Text = Convert.ToString(dr("rut"))
            DatosUsuario.NombreTextBox.Text = Convert.ToString(dr("nombre"))
            DatosUsuario.ContactoTextBox.Text = Convert.ToString(dr("contacto"))
            DatosUsuario.GeneroTextBox.Text = Convert.ToString(dr("genero"))
            DatosUsuario.EmailTextBox.Text = Convert.ToString(dr("email"))


            'tipo = Convert.ToString(dr("id_tipousuario"))
            'nombre = Convert.ToString(dr("nombre"))
        End If
        desconectar()
    End Sub
    Sub prueba(usuario As String)
        conectar()
        Dim nombre As String
        Dim rut As String
        comando = New SqlCommand(" select * from usuario where rut ='" + usuario + "'", conexion)
        Dim dr As SqlDataReader = comando.ExecuteReader()
        If dr.Read() Then
            rut = Convert.ToString(dr("rut"))
            tipo = Convert.ToString(dr("id_tipousuario"))
            nombre = Convert.ToString(dr("nombre"))
        End If
        'enviar datos al menu'
        Navegacion.tipo = tipo
        Navegacion.rut.Text = rut
        Navegacion.nombre.Text = nombre
        dato1()
        desconectar()
    End Sub
    Sub login(usuario As String, contraseña As String)
        Dim enc As New Encriptador
        conectar()

        comando = New SqlCommand(" select count(*) from usuario where rut ='" + usuario + "' and contraseña ='" + enc.Encriptar(contraseña) + "'", conexion)


        Dim VLDR_Nombre As Integer

        VLDR_Nombre = CInt(comando.ExecuteScalar)
        comando.ExecuteNonQuery()
        If VLDR_Nombre > 0 Then
            Navegacion.Show()
            Form1.Close()
        Else
            'Si NO existe el Cliente
            MsgBox("usuario o contraseña incorrecto")

        End If
        desconectar()
    End Sub

    'LOGIN'

    'USUARIO'
    Public Sub insertar_usuario(rut As String, nombre As String, contacto As String, genero As String, contraseña As String, id_tipousuario As Integer, email As String)
        Dim emisor, pass, asunto As String
        emisor = "mioficinaS.A@gmail.com"
        pass = "mioficina1998"
        asunto = "Datos de su cuenta"
        Dim mensaje As String
        mensaje = "Su usuario  es: "
        mensaje = mensaje + rut
        Dim mensaje2 As String
        mensaje2 = ", y su clave es: "
        mensaje2 = mensaje2 + contraseña
        mensaje = mensaje + mensaje2
        Dim enc As New Encriptador
        conectar()

        comando = New SqlCommand(" select count(*) from usuario where rut ='" + rut + "'", conexion)
        Dim corre As New Correo
        Dim validar As Integer

        validar = CInt(comando.ExecuteScalar)

        If validar > 0 Then

            'Si existe el Cliente
            MsgBox("El Usuario: " & UCase(rut) & " ya existe en la base de datos")

        Else
            comando.ExecuteNonQuery()

            comando = New SqlCommand("INSERT INTO [usuario] ([rut], [nombre], [contacto], [genero], [contraseña], [id_tipousuario], [email])  VALUES ('" & rut + "','" & nombre & "','" & contacto & "','" & genero & "','" & enc.Encriptar(contraseña) & "','" & id_tipousuario & "','" & email & "')", conexion)

            comando.ExecuteNonQuery()

            MsgBox("El Usuario: " & UCase(rut) & " ha sido ingresado con exito")
            corre.enviarCorreo(emisor, pass, mensaje, asunto, email)

        End If
        desconectar()
    End Sub
    Sub eliminar_usuario(rut As String)

        conectar()

        comando = New SqlCommand(" select count(*) from usuario where rut ='" + rut + "'", conexion)

        Dim validador As Integer

        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then
            comando = New SqlCommand("DELETE FROM usuario WHERE rut ='" + rut + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Usuario: " & UCase(rut) & " ha sido borrado")
        Else
            MsgBox("El Usuario: " & UCase(rut) & " no existe")
        End If

        desconectar()
    End Sub

    Public Sub editar_usuario(rut As String, rut2 As String, nombre As String, contacto As String, genero As String, email As String)

        conectar()

        comando = New SqlCommand(" select count(*) from usuario where rut ='" + rut2 + "'", conexion)
        Dim validador As Integer
        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then

            comando = New SqlCommand("UPDATE usuario SET rut ='" & rut & "',nombre ='" + nombre + "',contacto ='" + contacto + "',genero ='" + genero + "',email ='" + email + "' where rut= '" + rut2 + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El usuario: " & UCase(rut) & " fue actualizado")
            DatosUsuario.rut = rut

        Else

            MsgBox("Error al modificar los datos")

        End If

        desconectar()
    End Sub
    Public Sub editar_contraseña(rut As String, contraseña As String)

        conectar()

        comando = New SqlCommand(" select count(*) from usuario where rut ='" + rut + "'", conexion)
        Dim validador As Integer
        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then
            Dim enc As New Encriptador
            comando = New SqlCommand("UPDATE usuario SET contraseña ='" + enc.Encriptar(contraseña) + "' where rut= '" + rut + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("Contraseña Modificada")
            CambiarContraseña.Close()
            Navegacion.Close()
            Form1.Show()

        Else

            MsgBox("El usuario: " & UCase(rut) & " No existe en la base de datos")

        End If

        desconectar()
    End Sub
    'USUARIO'


    'Producto Sentencias sql'
    Public Sub insertar_prod(cod_producto As String, producto As String, precio As Double, tipo_producto As String)

        conectar()

        comando = New SqlCommand(" select count(*) from producto where cod_producto ='" + cod_producto + "'", conexion)
        Dim validar As Integer
        validar = CInt(comando.ExecuteScalar)
        comando.ExecuteNonQuery()
        If validar > 0 Then

            'Si existe el Clientehh
            MsgBox("El Producto: " & UCase(producto) & " ya existe en la base de datos")

        Else
            Dim cantidad As Integer = 0
            comando = New SqlCommand("INSERT INTO [producto] ([cod_producto], [nombre], [precio], [tipo_producto], [cantidad]) VALUES ('" & cod_producto & "','" & producto & "','" & precio & "','" & tipo_producto & "','" & cantidad & "')", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Producto: " & UCase(producto) & " ha sido ingresado con exito")

        End If
        desconectar()
    End Sub

    Public Sub editar_prod(cod_producto As String, cod As String, producto As String, precio As Double, tipo_producto As String, cantidad As Integer)

        conectar()

        comando = New SqlCommand(" select count(*) from producto where cod_producto ='" & cod & "'", conexion)

        Dim validador As Integer
        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then

            comando = New SqlCommand("UPDATE producto SET cod_producto ='" & cod_producto & "', nombre ='" & producto & "',precio ='" & precio & "',tipo_producto ='" & tipo_producto & "',cantidad ='" & cantidad & "' where cod_producto= '" & cod & "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Producto: " & UCase(producto) & " fue actualizado")
        Else

            MsgBox("El Producto: " & UCase(producto) & " No existe en la base de datos")

        End If

        desconectar()
    End Sub

    Sub eliminar_prod(cod_producto As String)
        conectar()

        comando = New SqlCommand(" select count(*) from producto where cod_producto ='" + cod_producto + "'", conexion)

        Dim validador As Integer

        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then
            comando = New SqlCommand("DELETE FROM producto WHERE cod_producto ='" + cod_producto + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Producto: " & UCase(cod_producto) & " ha sido borrado")
        Else
        End If

        desconectar()
    End Sub
    'Producto Sentencias sql'

    'DETALLE PROVEEDOR'
    Public Sub insertar_DetaProv(cod_productorov As String, rut_prov As String)

        conectar()
        comando = New SqlCommand("INSERT INTO [detalle_proveedor] ([cod_producto], [rut_prov]) VALUES ('" & cod_productorov & "','" & rut_prov & "')", conexion)
        comando.ExecuteNonQuery()

        desconectar()
    End Sub


    'DETALLE PROVEEDOR'

    'PROVEEDOR'
    Public Sub insertar_prov(rut_prov As String, nombre_prov As String, direccion As String, comuna As String, ciudad As String, email As String, fono As String)

        conectar()

        comando = New SqlCommand(" select count(*) from proveedor where rut_prov ='" + rut_prov + "'", conexion)

        Dim validar As Integer

        validar = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validar > 0 Then

            'Si existe el Cliente
            MsgBox("El Proveedor: " & UCase(nombre_prov) & " ya existe en la base de datos")

        Else

            comando = New SqlCommand("INSERT INTO [proveedor] ([rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono]) VALUES ('" & rut_prov & "','" & nombre_prov & "','" & direccion & "','" & comuna & "','" & ciudad & "','" & email & "','" & fono & "')", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Proveedor: " & UCase(nombre_prov) & " ha sido ingresado con exito")


        End If

        desconectar()
    End Sub
    Public Sub editar_prov(rut_prov As String, ru2 As String, nombre_prov As String, direccion As String, comuna As String, ciudad As String, email As String, fono As String)

        conectar()

        comando = New SqlCommand(" select count(*) from proveedor where rut_prov ='" + rut_prov + "'", conexion)

        Dim validador As Integer
        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then

            comando = New SqlCommand("UPDATE proveedor SET rut_prov ='" + rut_prov + "', nombre_prov ='" + nombre_prov + "',direccion ='" + direccion + "', comuna ='" + comuna + "',ciudad ='" + ciudad + "',email ='" + email + "',fono ='" + fono + "' where rut_prov= '" + rut_prov + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Proveedor: " & UCase(nombre_prov) & " fue actualizado")
        Else

            MsgBox("El Proveedor: " & UCase(nombre_prov) & " No existe en la base de datos")

        End If

        desconectar()
    End Sub

    Sub eliminar_prov(rut_prov As String)

        conectar()

        comando = New SqlCommand(" select count(*) from proveedor where rut_prov ='" + rut_prov + "'", conexion)

        Dim validador As Integer

        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then
            comando = New SqlCommand("DELETE FROM proveedor WHERE rut_prov ='" + rut_prov + "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Proveedor: " & UCase(rut_prov) & " ha sido borrado")
        Else

        End If

        desconectar()

    End Sub

    'PROVEEDOR'


    'REGISTROS'
    Public Sub insertar_registro(documento As String, n_documento As Integer, id_producto As String, precio As Double, cantidad As Integer, fecha As Date, usuario As String, tipo As String)

        conectar()

        comando = New SqlCommand("INSERT INTO  [registro] ([documento], [n_documento], [id_producto], [precio], [cantidad], [fecha], [usuario], [tipo])  VALUES ('" & documento & "','" & n_documento & "','" & id_producto & "','" & precio & "','" & cantidad & "','" & fecha & "','" & usuario & "','" & tipo & "')", conexion)
        comando.ExecuteNonQuery()
        'MsgBox("El Registro ha sido ingresado con exito")

        desconectar()
    End Sub
    Sub eliminar_registro(id_pro As String, n_documento As Integer)

        conectar()

        comando = New SqlCommand("DELETE FROM registro WHERE id_producto ='" & id_pro & "' and n_documento ='" & n_documento & "'", conexion)
        comando.ExecuteNonQuery()
        'MsgBox("El registro ha sido borrado")

        desconectar()

    End Sub

    Sub eliminar_mermas(id_mermas As Integer)
        conectar()

        comando = New SqlCommand(" select count(*) from mermas where id_mermas ='" & id_mermas & "'", conexion)

        Dim validador As Integer

        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then
            comando = New SqlCommand("DELETE FROM mermas WHERE id_mermas ='" & id_mermas & "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El registro: " & UCase(id_mermas) & " ha sido borrado")
        Else
            'MsgBox("El Producto: " & UCase(id_mermas) & " no existe")
        End If

        desconectar()
    End Sub

    'REGISTROS'


    'actualizacion de bodega'
    Public Sub actua_prod(cod_producto As String, cantidad As Integer)
        Dim can As String
        conectar()

        comando = New SqlCommand(" select * from producto where cod_producto ='" + cod_producto + "'", conexion)


        Dim dr As SqlDataReader = comando.ExecuteReader()
        If dr.Read() Then
            can = Convert.ToString(dr("cantidad"))
        End If
        cantidad = cantidad + Val(can)
        desconectar()
        conectar()
        comando = New SqlCommand("UPDATE producto SET cantidad ='" & cantidad & "' where cod_producto = '" & cod_producto & "'", conexion)
        comando.ExecuteNonQuery()

        desconectar()
    End Sub
    Public Sub actua_prod2(cod_producto As String, cantidad As Integer)
        Dim can As String
        conectar()

        comando = New SqlCommand(" select * from producto where cod_producto ='" + cod_producto + "'", conexion)


        Dim dr As SqlDataReader = comando.ExecuteReader()
        If dr.Read() Then
            can = Convert.ToString(dr("cantidad"))
        End If
        cantidad = Val(can) - cantidad
        desconectar()
        conectar()
        comando = New SqlCommand("UPDATE producto SET cantidad ='" & cantidad & "' where cod_producto = '" & cod_producto & "'", conexion)
        comando.ExecuteNonQuery()

        desconectar()
    End Sub
    'actualizacion de bodega'

    'GUIA DE DESPACHO'
    Public Sub insertar_guia(factura As Integer, rut_prov As String, nombre_prov As String, direccion As String, comuna As String, ciudad As String, email As String, fono As String, rut_cliente As String, fecha As Date, observacion As String, valor_neto As Double, iva As Double, total As Double)
        conectar()

        comando = New SqlCommand("INSERT INTO [guia_despacho] ([rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total], [factura_asociada])  VALUES ('" & rut_prov & "','" & nombre_prov & "','" & direccion & "','" & comuna & "','" & ciudad & "','" & email & "','" & fono & "','" & rut_cliente & "','" & fecha & "','" & observacion & "','" & valor_neto & "','" & iva & "','" & total & "','" & factura & "')", conexion)
        comando.ExecuteNonQuery()

        desconectar()
    End Sub
    'GUIA DE DESPACHO'


    'FACTURAS IMGRESO'

    Public Sub select_factura(n_factura As Integer)

        conectar()

        comando = New SqlCommand(" select count(*) from factura_ingreso where n_factura ='" & n_factura & "'", conexion)

        Dim validar As Integer
        FacturaVenta.validador = 0
        Factura.validador = 0
        validar = CInt(comando.ExecuteScalar)
        If validar > 0 Then

            MsgBox("La factura: " & UCase(n_factura) & " ya existe en la base de datos")
            FacturaVenta.validador = 1
            Factura.validador = 1
        End If
        desconectar()

    End Sub
    Public Sub insertar_factura(n_factura As Integer, rut_prov As String, nombre_prov As String, direccion As String, comuna As String, ciudad As String, email As String, fono As String, rut_cliente As String, fecha As Date, observacion As String, valor_neto As Double, iva As Double, total As Double)

        conectar()

        comando = New SqlCommand(" select count(*) from factura_ingreso where n_factura ='" & n_factura & "'", conexion)

        Dim validar As Integer

        validar = CInt(comando.ExecuteScalar)

        If validar > 0 Then

            MsgBox("La factura: " & UCase(n_factura) & " ya existe en la base de datos")

        Else
            Dim ss As Double = 0

            comando = New SqlCommand("INSERT INTO [factura_ingreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total])  VALUES ('" & n_factura & "','" & rut_prov & "','" & nombre_prov & "','" & direccion & "','" & comuna & "','" & ciudad & "','" & email & "','" & fono & "','" & rut_cliente & "','" & fecha & "','" & observacion & "','" & valor_neto & "','" & iva & "','" & total & "')", conexion)
            comando.ExecuteNonQuery()
            MsgBox("La Factura " & UCase(n_factura) & " ha sido ingresadoa con exito")
        End If
        desconectar()
    End Sub

    'FACTURAS INGRESO'

    'FACTURAS egreso'

    Public Sub select_factura_egreso(n_factura As Integer)

        conectar()

        comando = New SqlCommand(" select count(*) from factura_ingreso where n_factura ='" & n_factura & "'", conexion)

        Dim validar As Integer
        FacturaVenta.validador = 0
        Factura.validador = 0
        validar = CInt(comando.ExecuteScalar)
        If validar > 0 Then

            MsgBox("La factura: " & UCase(n_factura) & " ya existe en la base de datos")
            FacturaVenta.validador = 1
            Factura.validador = 1
        End If
        desconectar()

    End Sub
    Public Sub insertar_factura_egreso(n_factura As Integer, rut_prov As String, nombre_prov As String, direccion As String, comuna As String, ciudad As String, email As String, fono As String, rut_cliente As String, fecha As Date, observacion As String, valor_neto As Double, iva As Double, total As Double)

        conectar()

        comando = New SqlCommand(" select count(*) from factura_egreso where n_factura ='" & n_factura & "'", conexion)

        Dim validar As Integer

        validar = CInt(comando.ExecuteScalar)

        If validar > 0 Then

            MsgBox("La factura: " & UCase(n_factura) & " ya existe en la base de datos")

        Else
            Dim ss As Double = 0

            comando = New SqlCommand("INSERT INTO [factura_egreso] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total])  VALUES ('" & n_factura & "','" & rut_prov & "','" & nombre_prov & "','" & direccion & "','" & comuna & "','" & ciudad & "','" & email & "','" & fono & "','" & rut_cliente & "','" & fecha & "','" & observacion & "','" & valor_neto & "','" & iva & "','" & total & "')", conexion)
            comando.ExecuteNonQuery()
        End If
        desconectar()
    End Sub

    'FACTURAS INGRESO'

    'detalle guia'
    Public Sub insertar_detalle_guia(n_guia As Integer, cod_producto As String, descripcion As String, cantidad As Integer, precio_unitario As Double, total As Double)

        conectar()

        comando = New SqlCommand("INSERT INTO [detalle_guia] ([n_guia], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total])  VALUES ('" & n_guia & "','" & cod_producto & "','" & descripcion & "','" & cantidad & "','" & precio_unitario & "','" & total & "')", conexion)
        comando.ExecuteNonQuery()
        'MsgBox("El Registro ha sido ingresado con exito")

        desconectar()
    End Sub
    'detalle guia'

    'DETALLE FACTURA INGRESO'
    Public Sub insertar_fac_deta(n_factura As Integer, cod_producto As String, descripcion As String, cantidad As Integer, precio_unitario As Double, total As Double)

        conectar()

        comando = New SqlCommand("INSERT INTO [detalle_fac_ingreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total])  VALUES ('" & n_factura & "','" & cod_producto & "','" & descripcion & "','" & cantidad & "','" & precio_unitario & "','" & total & "')", conexion)
        comando.ExecuteNonQuery()
        'MsgBox("El Registro ha sido ingresado con exito")

        desconectar()
    End Sub


    'DETALLE FACTURA INGRESO'

    'DETALLE FACTURA egreso'
    Public Sub insertar_fac_deta2(n_factura As Integer, cod_producto As String, descripcion As String, cantidad As Integer, precio_unitario As Double, total As Double)

        conectar()

        comando = New SqlCommand("INSERT INTO [detalle_fac_egreso] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total])  VALUES ('" & n_factura & "','" & cod_producto & "','" & descripcion & "','" & cantidad & "','" & precio_unitario & "','" & total & "')", conexion)
        comando.ExecuteNonQuery()
        'MsgBox("El Registro ha sido ingresado con exito")

        desconectar()
    End Sub


    'DETALLE FACTURA egreso'

    'BOLETA'
    Public Sub select_boleta(n_boleta As Integer)

        conectar()

        comando = New SqlCommand(" select count(*) from boleta where n_boleta ='" & n_boleta & "'", conexion)
        Dim validar As Integer
        validar = CInt(comando.ExecuteScalar)
        comando.ExecuteNonQuery()
        If validar > 0 Then

            'Si existe el Clientehh
            'MsgBox("El boleta: " & UCase(n_boleta) & " ya existe en la base de datos")
            boleta.validador = 1
        End If
        desconectar()
    End Sub
    Public Sub insertar_boleta(n_boleta As Integer, rut_empresa As String, rut_cliente As String, nombre_empresa As String, direccion As String, fecha As Date, total As Double)

        conectar()

        comando = New SqlCommand(" select count(*) from boleta where n_boleta ='" & n_boleta & "'", conexion)
        Dim validar As Integer
        validar = CInt(comando.ExecuteScalar)
        comando.ExecuteNonQuery()
        If validar > 0 Then

            'Si existe el Clientehh
            MsgBox("El boleta: " & UCase(n_boleta) & " ya existe en la base de datos")

        Else
            Dim cantidad As Integer = 0
            comando = New SqlCommand("INSERT INTO [boleta] ([n_boleta], [rut_empresa], [rut_cliente], [nombre_empresa], [direcion], [fecha], [total])  VALUES ('" & n_boleta & "','" & rut_empresa & "','" & rut_cliente & "','" & nombre_empresa & "','" & direccion & "','" & fecha & "','" & total & "')", conexion)
            comando.ExecuteNonQuery()
            'MsgBox("El Producto: "
        End If
        desconectar()
    End Sub

    Public Sub insertar_detalle_bol(n_boleta As Integer, cod_producto As String, cantidad As Integer)

        conectar()

        comando = New SqlCommand("INSERT INTO [detalle_boleta] ([n_boleta], [cod_prodcuto], [cantidad])  VALUES ('" & n_boleta & "','" & cod_producto & "','" & cantidad & "')", conexion)
        comando.ExecuteNonQuery()
        'MsgBox("El Registro ha sido ingresado con exito")

        desconectar()
    End Sub

    Sub eliminar_boleta(n_boleta As Integer)
        conectar()

        comando = New SqlCommand(" select count(*) from detalle_boleta where n_boleta ='" & n_boleta & "'", conexion)

        Dim validador As Integer

        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then
            comando = New SqlCommand("DELETE FROM detalle_boleta WHERE n_boleta ='" & n_boleta & "'", conexion)
            comando.ExecuteNonQuery()
        Else

        End If

        desconectar()
    End Sub

    'BOLETA'








    'CLIENTE'
    Public Sub insertar_cliente(rut_cliente As String, nombre As String, email As String, fono As String, direccion As String, comuna As String, ciudad As String)

        conectar()

        comando = New SqlCommand(" select count(*) from cliente where rut_cliente ='" + rut_cliente + "'", conexion)
        Dim validar As Integer
        validar = CInt(comando.ExecuteScalar)
        comando.ExecuteNonQuery()
        If validar > 0 Then

            'Si existe el Cliente
            MsgBox("El Producto: " & UCase(rut_cliente) & " ya existe en la base de datos")

        Else
            Dim cantidad As Integer = 0
            comando = New SqlCommand("INSERT INTO [cliente] ([rut_cliente], [nombre], [email], [fono], [direccion], [comuna], [ciudad]) VALUES ('" & rut_cliente & "','" & nombre & "','" & email & "','" & fono & "','" & direccion & "','" & comuna & "','" & ciudad & "')", conexion)
            comando.ExecuteNonQuery()
            'MsgBox("El Producto: " & UCase(producto) & " ha sido ingresado con exito")

        End If
        desconectar()
    End Sub

    Sub eliminar_cliente(rut As String)

        conectar()

        comando = New SqlCommand(" select count(*) from cliente where rut_cliente ='" & rut & "'", conexion)

        Dim validador As Integer

        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then
            comando = New SqlCommand("DELETE FROM cliente WHERE rut_cliente ='" & rut & "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El Cliente: " & UCase(rut) & " ha sido borrado")
        Else
            MsgBox("El Cliente: " & UCase(rut) & " no existe")
        End If

        desconectar()

    End Sub

    Public Sub editar_cliente(rut_cliente As String, rut As String, nombre As String, email As String, fono As String, direccion As String, comuna As String, ciudad As String)

        conectar()

        comando = New SqlCommand(" select count(*) from cliente where rut_cliente ='" & rut & "'", conexion)

        Dim validador As Integer
        validador = CInt(comando.ExecuteScalar)

        comando.ExecuteNonQuery()

        If validador > 0 Then

            comando = New SqlCommand("UPDATE cliente SET rut_cliente ='" & rut_cliente & "', nombre ='" & nombre & "',email ='" & email & "',fono ='" & fono & "',direccion ='" & direccion & "',comuna ='" & comuna & "',ciudad ='" & ciudad & "' where rut_cliente= '" & rut & "'", conexion)
            comando.ExecuteNonQuery()
            MsgBox("El cliente: " & UCase(rut_cliente) & " fue actualizado")
        Else

            'MsgBox("El cliente: " & UCase(rut) & " No existe en la base de datos")

        End If

        desconectar()
    End Sub
    'CLIENTE'

    'MERMAS'
    Public Sub insertar_mermas(cod_producto As String, producto As String, cantidad As Integer, fecha As Date, observacion As String)

        conectar()

        comando = New SqlCommand(" select count(*) from producto where cod_producto ='" + cod_producto + "'", conexion)
        Dim validar As Integer
        validar = CInt(comando.ExecuteScalar)
        comando.ExecuteNonQuery()
        If validar > 0 Then
            comando = New SqlCommand("INSERT INTO [mermas] ([cod_producto], [nombre], [cantidad], [fecha], [observacion]) VALUES ('" & cod_producto & "','" & producto & "','" & cantidad & "','" & fecha & "','" & observacion & "')", conexion)
            comando.ExecuteNonQuery()
            'MsgBox("El Producto: " & UCase(producto) & " ha sido ingresado con exito")


        Else
            MsgBox("El Producto: " & UCase(producto) & " no existe ")

        End If
        desconectar()
    End Sub
    'MERMAS'







    Sub desconectar()
        conexion.Close()
    End Sub

End Class
