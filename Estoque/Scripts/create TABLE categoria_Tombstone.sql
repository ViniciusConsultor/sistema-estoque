USE [estoque]
GO

/****** Object:  Table [dbo].[categoria_Tombstone]    Script Date: 07/03/2012 15:50:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[categoria_Tombstone](
	[idCategoria] [int] NOT NULL,
	[DeletionDate] [datetime] NULL,
 CONSTRAINT [PKDEL_categoria_Tombstone_idCategoria] PRIMARY KEY CLUSTERED 
(
	[idCategoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

