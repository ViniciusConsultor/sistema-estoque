USE [estoque]
GO

/****** Object:  Table [dbo].[Estado]    Script Date: 07/03/2012 15:51:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Estado](
	[EstadoId] [tinyint] NOT NULL,
	[Sigla] [char](2) NOT NULL,
	[LastEditDate] [datetime] NULL,
	[CreationDate] [datetime] NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[EstadoId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Estado] ADD  CONSTRAINT [DF_Estado_LastEditDate]  DEFAULT (getutcdate()) FOR [LastEditDate]
GO

ALTER TABLE [dbo].[Estado] ADD  CONSTRAINT [DF_Estado_CreationDate]  DEFAULT (getutcdate()) FOR [CreationDate]
GO

