USE [estoque]
GO

/****** Object:  Table [dbo].[Estado_Tombstone]    Script Date: 07/03/2012 15:47:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Estado_Tombstone](
	[EstadoId] [tinyint] NOT NULL,
	[DeletionDate] [datetime] NULL,
 CONSTRAINT [PKDEL_Estado_Tombstone_EstadoId] PRIMARY KEY CLUSTERED 
(
	[EstadoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


