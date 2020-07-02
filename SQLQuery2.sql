USE [Controlinventario]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 02/07/2020 18:32:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[rut_cliente] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[fono] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[comuna] [varchar](50) NULL,
	[ciudad] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_fac]    Script Date: 02/07/2020 18:32:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_fac](
	[n_factura] [int] NULL,
	[cod_producto] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
	[cantidad] [int] NULL,
	[precio_unitario] [decimal](20, 0) NULL,
	[total] [decimal](20, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_proveedor]    Script Date: 02/07/2020 18:32:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_proveedor](
	[cod_producto] [varchar](50) NULL,
	[rut_prov] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[factura]    Script Date: 02/07/2020 18:32:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura](
	[n_factura] [int] NOT NULL,
	[rut_prov] [varchar](50) NULL,
	[nombre_prov] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[comuna] [varchar](50) NULL,
	[ciudad] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[fono] [varchar](50) NULL,
	[rut_cliente] [varchar](50) NULL,
	[fecha] [date] NULL,
	[observacion] [varchar](50) NULL,
	[valor_neto] [decimal](20, 0) NULL,
	[iva] [decimal](20, 0) NULL,
	[total] [decimal](20, 0) NULL,
	[tipo] [varchar](50) NULL,
 CONSTRAINT [PK_factura] PRIMARY KEY CLUSTERED 
(
	[n_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mermas]    Script Date: 02/07/2020 18:32:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mermas](
	[id_mermas] [int] IDENTITY(1,1) NOT NULL,
	[cod_producto] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[cantidad] [int] NULL,
	[fecha] [date] NULL,
	[observacion] [varchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 02/07/2020 18:32:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[cod_producto] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NULL,
	[precio] [decimal](20, 0) NULL,
	[tipo_producto] [varchar](50) NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[cod_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 02/07/2020 18:32:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedor](
	[rut_prov] [varchar](50) NOT NULL,
	[nombre_prov] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[comuna] [varchar](50) NULL,
	[ciudad] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[fono] [varchar](50) NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[rut_prov] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[registro]    Script Date: 02/07/2020 18:32:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[registro](
	[id_registro] [int] IDENTITY(1,1) NOT NULL,
	[id_producto] [varchar](50) NULL,
	[cantidad] [int] NULL,
	[n_factura] [int] NULL,
	[fecha] [date] NULL,
	[usuario] [varchar](50) NULL,
	[tipo] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipousuario]    Script Date: 02/07/2020 18:32:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipousuario](
	[id_tipousuario] [int] NOT NULL,
	[permiso] [varchar](40) NULL,
 CONSTRAINT [PK_tipousuario] PRIMARY KEY CLUSTERED 
(
	[id_tipousuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 02/07/2020 18:32:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[rut] [varchar](35) NOT NULL,
	[nombre] [varchar](40) NULL,
	[contacto] [varchar](30) NULL,
	[genero] [varchar](20) NULL,
	[contraseña] [varchar](255) NULL,
	[id_tipousuario] [int] NULL,
	[email] [varchar](50) NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[rut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[detalle_fac] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (1, N'RES-100', N'Resma ', 20, CAST(100 AS Decimal(20, 0)), CAST(2000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (2, N'RES-100', N'Resma ', 200, CAST(1000 AS Decimal(20, 0)), CAST(200000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (3, N'RES-100', N'Resma ', 10, CAST(1500 AS Decimal(20, 0)), CAST(15000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_fac] ([n_factura], [cod_producto], [descripcion], [cantidad], [precio_unitario], [total]) VALUES (3, N'ARCH-9526', N'Archivador', 10, CAST(2000 AS Decimal(20, 0)), CAST(20000 AS Decimal(20, 0)))
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'RES-100', N'20345845k')
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'fdf', N'20345845k')
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'RES-100', N'20345845k')
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'RES-100', N'20345845k')
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'GOM-001', N'20345845k')
GO
INSERT [dbo].[detalle_proveedor] ([cod_producto], [rut_prov]) VALUES (N'PER-021', N'20345845k')
GO
INSERT [dbo].[factura] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total], [tipo]) VALUES (1, N'15.3142.535-0', N'MiOficinaS.A', N'los llanos', N'La serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2020-06-28' AS Date), N'', CAST(1620 AS Decimal(20, 0)), CAST(380 AS Decimal(20, 0)), CAST(2000 AS Decimal(20, 0)), N'Entrada')
GO
INSERT [dbo].[factura] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total], [tipo]) VALUES (2, N'15.3142.535-0', N'MiOficinaS.A', N'Los llanos', N'La serena', N'La Serena', N'mioficinaS.A@gmail.com', N'954722488', N'44.300.251-0', CAST(N'2020-06-28' AS Date), N'', CAST(162000 AS Decimal(20, 0)), CAST(38000 AS Decimal(20, 0)), CAST(200000 AS Decimal(20, 0)), N'Entrada')
GO
INSERT [dbo].[factura] ([n_factura], [rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono], [rut_cliente], [fecha], [observacion], [valor_neto], [iva], [total], [tipo]) VALUES (3, N'44300251-0', N'Diego', N'las monturas #3456', N'La serena', N'La serena', N'diego@gmail.com', N'43655467', N'194356278', CAST(N'2020-06-28' AS Date), N'', CAST(28350 AS Decimal(20, 0)), CAST(6650 AS Decimal(20, 0)), CAST(35000 AS Decimal(20, 0)), N'venta')
GO
SET IDENTITY_INSERT [dbo].[mermas] ON 
GO
INSERT [dbo].[mermas] ([id_mermas], [cod_producto], [nombre], [cantidad], [fecha], [observacion]) VALUES (1, N'RES-100', N'Resma ', 10, CAST(N'2020-06-30' AS Date), NULL)
GO
INSERT [dbo].[mermas] ([id_mermas], [cod_producto], [nombre], [cantidad], [fecha], [observacion]) VALUES (2, N'RES-100', N'Resma ', 10, CAST(N'2020-06-30' AS Date), NULL)
GO
INSERT [dbo].[mermas] ([id_mermas], [cod_producto], [nombre], [cantidad], [fecha], [observacion]) VALUES (4, N'PER-021', N'pera', 5, CAST(N'2020-07-02' AS Date), N'productos dañados ')
GO
SET IDENTITY_INSERT [dbo].[mermas] OFF
GO
INSERT [dbo].[producto] ([cod_producto], [nombre], [precio], [tipo_producto], [cantidad]) VALUES (N'GOM-001', N'Goma ', CAST(500 AS Decimal(20, 0)), N'oficina', 19)
GO
INSERT [dbo].[producto] ([cod_producto], [nombre], [precio], [tipo_producto], [cantidad]) VALUES (N'PER-021', N'pera', CAST(10 AS Decimal(20, 0)), N'fruta', 25)
GO
INSERT [dbo].[producto] ([cod_producto], [nombre], [precio], [tipo_producto], [cantidad]) VALUES (N'RES-100', N'resma', CAST(1500 AS Decimal(20, 0)), N'oficina', 9)
GO
INSERT [dbo].[proveedor] ([rut_prov], [nombre_prov], [direccion], [comuna], [ciudad], [email], [fono]) VALUES (N'20345845k', N'Jose ', N'matamoros', N'la serena', N'La serena', N'jose@gmail.com', N'54672398')
GO
SET IDENTITY_INSERT [dbo].[registro] ON 
GO
INSERT [dbo].[registro] ([id_registro], [id_producto], [cantidad], [n_factura], [fecha], [usuario], [tipo]) VALUES (10, N'ARCH-9526', 20, 1, CAST(N'2020-06-28' AS Date), N'', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [id_producto], [cantidad], [n_factura], [fecha], [usuario], [tipo]) VALUES (2, N'RES-100', 20, 1000, CAST(N'2020-06-28' AS Date), N'', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [id_producto], [cantidad], [n_factura], [fecha], [usuario], [tipo]) VALUES (11, N'RES-100', 30, 1, CAST(N'2020-06-28' AS Date), N'', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [id_producto], [cantidad], [n_factura], [fecha], [usuario], [tipo]) VALUES (4, N'ARCH-9526', 4, 44444, CAST(N'2020-06-28' AS Date), N'', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [id_producto], [cantidad], [n_factura], [fecha], [usuario], [tipo]) VALUES (7, N'ARCH-9526', 20, 1000, CAST(N'2020-06-28' AS Date), N'', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [id_producto], [cantidad], [n_factura], [fecha], [usuario], [tipo]) VALUES (12, N'RES-100', 20, 1, CAST(N'2020-06-28' AS Date), N'', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [id_producto], [cantidad], [n_factura], [fecha], [usuario], [tipo]) VALUES (13, N'RES-100', 20, 1, CAST(N'2020-06-28' AS Date), N'', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [id_producto], [cantidad], [n_factura], [fecha], [usuario], [tipo]) VALUES (5, N'ARCH-9526', 20, 1000, CAST(N'2020-06-28' AS Date), N'', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [id_producto], [cantidad], [n_factura], [fecha], [usuario], [tipo]) VALUES (6, N'ARCH-9526', 20, 1000, CAST(N'2020-06-28' AS Date), N'', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [id_producto], [cantidad], [n_factura], [fecha], [usuario], [tipo]) VALUES (15, N'RES-100', 200, 2, CAST(N'2020-06-28' AS Date), N'', N'ingreso')
GO
INSERT [dbo].[registro] ([id_registro], [id_producto], [cantidad], [n_factura], [fecha], [usuario], [tipo]) VALUES (16, N'RES-100', 10, 3, CAST(N'2020-06-28' AS Date), N'', N'venta')
GO
INSERT [dbo].[registro] ([id_registro], [id_producto], [cantidad], [n_factura], [fecha], [usuario], [tipo]) VALUES (17, N'ARCH-9526', 10, 3, CAST(N'2020-06-28' AS Date), N'', N'venta')
GO
SET IDENTITY_INSERT [dbo].[registro] OFF
GO
INSERT [dbo].[tipousuario] ([id_tipousuario], [permiso]) VALUES (100, N'root')
GO
INSERT [dbo].[tipousuario] ([id_tipousuario], [permiso]) VALUES (101, N'admin gerente')
GO
INSERT [dbo].[tipousuario] ([id_tipousuario], [permiso]) VALUES (102, N'gerente')
GO
INSERT [dbo].[tipousuario] ([id_tipousuario], [permiso]) VALUES (103, N'operador bodega')
GO
INSERT [dbo].[tipousuario] ([id_tipousuario], [permiso]) VALUES (104, N'visita')
GO
INSERT [dbo].[tipousuario] ([id_tipousuario], [permiso]) VALUES (105, N'vendedor')
GO
INSERT [dbo].[usuario] ([rut], [nombre], [contacto], [genero], [contraseña], [id_tipousuario], [email]) VALUES (N'199482408', N'Norber Araya', N'953559709', N'hombre', N'32CAIeDuS+sC9dJxSFBwKGs+MBvBS+jbeO4h5YaLupI=', 100, N'diegoandresx0@gmail.com')
GO
ALTER TABLE [dbo].[detalle_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_detalle_proveedor_proveedor] FOREIGN KEY([rut_prov])
REFERENCES [dbo].[proveedor] ([rut_prov])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[detalle_proveedor] CHECK CONSTRAINT [FK_detalle_proveedor_proveedor]
GO
