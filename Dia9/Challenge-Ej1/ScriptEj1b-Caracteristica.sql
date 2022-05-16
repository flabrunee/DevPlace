USE [Kiosco-Ej1]
GO

/****** Object:  Table [dbo].[Caracteristicas]    Script Date: 12/5/2022 15:34:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Caracteristicas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductoId] [int] NOT NULL,
	[Precio] [decimal](18, 2) NULL,
	[Ancho] [decimal](18, 2) NULL,
	[Largo] [decimal](18, 2) NULL,
	[Peso] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Caracteristicas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Caracteristicas]  WITH CHECK ADD  CONSTRAINT [FK_Caracteristicas_Productos] FOREIGN KEY([ProductoId])
REFERENCES [dbo].[Productos] ([Id])
GO

ALTER TABLE [dbo].[Caracteristicas] CHECK CONSTRAINT [FK_Caracteristicas_Productos]
GO

