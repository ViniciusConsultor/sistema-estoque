USE [estoque]
GO

/****** Object:  Table [dbo].[Cidade]    Script Date: 07/03/2012 15:50:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Cidade](
	[CidadeId] [int] NOT NULL,
	[Nome] [varchar](38) NOT NULL,
	[EstadoId] [tinyint] NULL,
	[Capital] [bit] NOT NULL,
	[LastEditDate] [datetime] NULL,
	[CreationDate] [datetime] NULL,
 CONSTRAINT [PK_Cidade] PRIMARY KEY CLUSTERED 
(
	[CidadeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Cidade]  WITH CHECK ADD  CONSTRAINT [FK_Cidade_Estado] FOREIGN KEY([EstadoId])
REFERENCES [dbo].[Estado] ([EstadoId])
GO

ALTER TABLE [dbo].[Cidade] CHECK CONSTRAINT [FK_Cidade_Estado]
GO

ALTER TABLE [dbo].[Cidade] ADD  CONSTRAINT [DF_Cidade_LastEditDate]  DEFAULT (getutcdate()) FOR [LastEditDate]
GO

ALTER TABLE [dbo].[Cidade] ADD  CONSTRAINT [DF_Cidade_CreationDate]  DEFAULT (getutcdate()) FOR [CreationDate]
GO

