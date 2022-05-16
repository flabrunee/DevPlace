USE [Concesionaria-Ej3]
GO

/****** Object:  Table [dbo].[Vehiculo]    Script Date: 13/5/2022 08:53:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Vehiculo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [varchar](50) NULL,
	[Modelo] [varchar](50) NULL,
	[Importe] [varchar](50) NULL,
	[FechaBaja] [datetime] NULL,
 CONSTRAINT [PK_Vehiculo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

