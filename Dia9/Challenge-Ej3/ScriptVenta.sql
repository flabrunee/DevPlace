USE [Concesionaria-Ej3]
GO

/****** Object:  Table [dbo].[Venta]    Script Date: 13/5/2022 08:54:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Venta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VehiculoId] [int] NOT NULL,
	[ClienteId] [int] NOT NULL,
	[Importe] [decimal](18, 2) NULL,
	[Descuento] [decimal](18, 2) NULL,
	[Fecha] [datetime] NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Cliente] ([Id])
GO

ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente]
GO

ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Vehiculo] FOREIGN KEY([VehiculoId])
REFERENCES [dbo].[Vehiculo] ([Id])
GO

ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Vehiculo]
GO

