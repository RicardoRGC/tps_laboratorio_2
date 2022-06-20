USE [TP4]
GO
/****** Object:  Table [dbo].[EQUIPOS]    Script Date: 20/6/2022 08:48:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EQUIPOS](
	[CODIGO_EQUIPO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
	[MONTO_PAGADO] [float] NULL,
	[HISTORIAL_PAGO] [varchar](1000) NULL,
	[FECHA_PAGO] [datetime] NULL,
 CONSTRAINT [PK_EQUIPOS_1] PRIMARY KEY CLUSTERED 
(
	[CODIGO_EQUIPO] ASC,
	[NOMBRE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[EQUIPOS] ON 

INSERT [dbo].[EQUIPOS] ([CODIGO_EQUIPO], [NOMBRE], [MONTO_PAGADO], [HISTORIAL_PAGO], [FECHA_PAGO]) VALUES (1, N'Nicky', 4286, N' ', CAST(N'2022-02-22T00:00:00.000' AS DateTime))
INSERT [dbo].[EQUIPOS] ([CODIGO_EQUIPO], [NOMBRE], [MONTO_PAGADO], [HISTORIAL_PAGO], [FECHA_PAGO]) VALUES (2, N'Alexio', 3040, N' ', CAST(N'2022-01-02T00:00:00.000' AS DateTime))
INSERT [dbo].[EQUIPOS] ([CODIGO_EQUIPO], [NOMBRE], [MONTO_PAGADO], [HISTORIAL_PAGO], [FECHA_PAGO]) VALUES (3, N'Dana', 4104, N' ', CAST(N'2022-03-27T00:00:00.000' AS DateTime))
INSERT [dbo].[EQUIPOS] ([CODIGO_EQUIPO], [NOMBRE], [MONTO_PAGADO], [HISTORIAL_PAGO], [FECHA_PAGO]) VALUES (4, N'Talya', 1437, N' ', CAST(N'2021-06-23T00:00:00.000' AS DateTime))
INSERT [dbo].[EQUIPOS] ([CODIGO_EQUIPO], [NOMBRE], [MONTO_PAGADO], [HISTORIAL_PAGO], [FECHA_PAGO]) VALUES (5, N'Cos', 3755, N' ', CAST(N'2021-11-28T00:00:00.000' AS DateTime))
INSERT [dbo].[EQUIPOS] ([CODIGO_EQUIPO], [NOMBRE], [MONTO_PAGADO], [HISTORIAL_PAGO], [FECHA_PAGO]) VALUES (6, N'Glad', 1880, N' ', CAST(N'2021-07-21T00:00:00.000' AS DateTime))
INSERT [dbo].[EQUIPOS] ([CODIGO_EQUIPO], [NOMBRE], [MONTO_PAGADO], [HISTORIAL_PAGO], [FECHA_PAGO]) VALUES (7, N'Jesselyn', 3839, N' ', CAST(N'2021-08-15T00:00:00.000' AS DateTime))
INSERT [dbo].[EQUIPOS] ([CODIGO_EQUIPO], [NOMBRE], [MONTO_PAGADO], [HISTORIAL_PAGO], [FECHA_PAGO]) VALUES (8, N'Lorain', 4893, N' ', CAST(N'2022-01-08T00:00:00.000' AS DateTime))
INSERT [dbo].[EQUIPOS] ([CODIGO_EQUIPO], [NOMBRE], [MONTO_PAGADO], [HISTORIAL_PAGO], [FECHA_PAGO]) VALUES (9, N'Corella', 1878, N' ', CAST(N'2022-03-04T00:00:00.000' AS DateTime))
INSERT [dbo].[EQUIPOS] ([CODIGO_EQUIPO], [NOMBRE], [MONTO_PAGADO], [HISTORIAL_PAGO], [FECHA_PAGO]) VALUES (10, N'Tiebold', 3537, N' ', CAST(N'2021-09-19T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[EQUIPOS] OFF
GO
