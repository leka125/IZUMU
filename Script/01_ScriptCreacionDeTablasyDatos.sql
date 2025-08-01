USE [IZUMU]
GO
/****** Object:  Table [dbo].[DatosPersonales]    Script Date: 27/07/2025 5:31:52 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatosPersonales](
	[IdInformacionPersonal] [int] IDENTITY(1,1) NOT NULL,
	[IdTipoDeDocumento] [nvarchar](10) NOT NULL,
	[NumeroDeDocumento] [nvarchar](50) NOT NULL,
	[FechaDeNacimiento] [date] NOT NULL,
	[PrimerNombre] [nvarchar](50) NOT NULL,
	[SegundoNombre] [nvarchar](50) NULL,
	[PrimerApellido] [nvarchar](50) NOT NULL,
	[SegundoApellido] [nvarchar](50) NOT NULL,
	[DireccionDeResidencia] [nvarchar](100) NOT NULL,
	[NúmeroDeCelular] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[PlanContratado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdInformacionPersonal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanContratado]    Script Date: 27/07/2025 5:31:52 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanContratado](
	[Id] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDeDocumento]    Script Date: 27/07/2025 5:31:52 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDeDocumento](
	[Id] [nvarchar](10) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DatosPersonales] ON 

INSERT [dbo].[DatosPersonales] ([IdInformacionPersonal], [IdTipoDeDocumento], [NumeroDeDocumento], [FechaDeNacimiento], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [DireccionDeResidencia], [NúmeroDeCelular], [Email], [PlanContratado]) VALUES (1, N'CC', N'123456789', CAST(N'1990-05-10' AS Date), N'Juan', N'Manuel', N'Pérez', N'Gómez', N'Calle 123 #45-67', N'3001234567', N'juan.perez@example.com', 1)
INSERT [dbo].[DatosPersonales] ([IdInformacionPersonal], [IdTipoDeDocumento], [NumeroDeDocumento], [FechaDeNacimiento], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [DireccionDeResidencia], [NúmeroDeCelular], [Email], [PlanContratado]) VALUES (2, N'TI', N'987654321', CAST(N'2002-08-01' AS Date), N'Ana', NULL, N'Martínez', N'López', N'Av. Siempre Viva 742', N'3109876543', N'ana.martinez@example.com', 3)
INSERT [dbo].[DatosPersonales] ([IdInformacionPersonal], [IdTipoDeDocumento], [NumeroDeDocumento], [FechaDeNacimiento], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [DireccionDeResidencia], [NúmeroDeCelular], [Email], [PlanContratado]) VALUES (3, N'CC', N'555555555', CAST(N'1985-03-15' AS Date), N'Luis', N'Alberto', N'Ramírez', N'Torres', N'Cra 45 #67-89', N'3205555555', N'luis.ramirez@example.com', 3)
INSERT [dbo].[DatosPersonales] ([IdInformacionPersonal], [IdTipoDeDocumento], [NumeroDeDocumento], [FechaDeNacimiento], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [DireccionDeResidencia], [NúmeroDeCelular], [Email], [PlanContratado]) VALUES (4, N'CE', N'111222333', CAST(N'1978-11-30' AS Date), N'Marta', NULL, N'García', N'Fernández', N'Calle 8 #12-34', N'3011112233', N'marta.garcia@example.com', 1)
INSERT [dbo].[DatosPersonales] ([IdInformacionPersonal], [IdTipoDeDocumento], [NumeroDeDocumento], [FechaDeNacimiento], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [DireccionDeResidencia], [NúmeroDeCelular], [Email], [PlanContratado]) VALUES (5, N'RC', N'444333222', CAST(N'2010-07-05' AS Date), N'Sofía', N'Isabel', N'Ruiz', N'Moreno', N'Av. Las Palmas 123', N'3154443322', N'sofia.ruiz@example.com', 2)
INSERT [dbo].[DatosPersonales] ([IdInformacionPersonal], [IdTipoDeDocumento], [NumeroDeDocumento], [FechaDeNacimiento], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [DireccionDeResidencia], [NúmeroDeCelular], [Email], [PlanContratado]) VALUES (7, N'CC', N'987654321', CAST(N'2025-07-08' AS Date), N'Andres', NULL, N'Lopez', N'Obrador', N'calle 120 #4-23', N'300202365', N'andres@gmail.com', 1)
INSERT [dbo].[DatosPersonales] ([IdInformacionPersonal], [IdTipoDeDocumento], [NumeroDeDocumento], [FechaDeNacimiento], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [DireccionDeResidencia], [NúmeroDeCelular], [Email], [PlanContratado]) VALUES (14, N'RC', N'123654789', CAST(N'2025-07-01' AS Date), N'Andres', N'Manuel', N'Lopez', N'Obrador', N'mexico', N'3001423658', N'andres@gmail.com', 4)
SET IDENTITY_INSERT [dbo].[DatosPersonales] OFF
GO
INSERT [dbo].[PlanContratado] ([Id], [Descripcion]) VALUES (1, N'Plan Básico')
INSERT [dbo].[PlanContratado] ([Id], [Descripcion]) VALUES (2, N'P.O.S')
INSERT [dbo].[PlanContratado] ([Id], [Descripcion]) VALUES (3, N'P.O.S.S')
INSERT [dbo].[PlanContratado] ([Id], [Descripcion]) VALUES (4, N'Sin Plan')
GO
INSERT [dbo].[TipoDeDocumento] ([Id], [Descripcion]) VALUES (N'CC', N'Cédula de Ciudadanía')
INSERT [dbo].[TipoDeDocumento] ([Id], [Descripcion]) VALUES (N'CE', N'Cédula de Extranjería')
INSERT [dbo].[TipoDeDocumento] ([Id], [Descripcion]) VALUES (N'PAS', N'Pasaporte')
INSERT [dbo].[TipoDeDocumento] ([Id], [Descripcion]) VALUES (N'RC', N'Registro Civil')
INSERT [dbo].[TipoDeDocumento] ([Id], [Descripcion]) VALUES (N'TI', N'Tarjeta de Identidad')
GO
ALTER TABLE [dbo].[DatosPersonales]  WITH CHECK ADD  CONSTRAINT [FK_DatosPersonales_PlanContratado] FOREIGN KEY([PlanContratado])
REFERENCES [dbo].[PlanContratado] ([Id])
GO
ALTER TABLE [dbo].[DatosPersonales] CHECK CONSTRAINT [FK_DatosPersonales_PlanContratado]
GO
ALTER TABLE [dbo].[DatosPersonales]  WITH CHECK ADD  CONSTRAINT [FK_DatosPersonales_TipoDeDocumento] FOREIGN KEY([IdTipoDeDocumento])
REFERENCES [dbo].[TipoDeDocumento] ([Id])
GO
ALTER TABLE [dbo].[DatosPersonales] CHECK CONSTRAINT [FK_DatosPersonales_TipoDeDocumento]
GO
