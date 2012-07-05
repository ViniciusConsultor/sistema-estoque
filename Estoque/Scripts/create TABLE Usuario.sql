USE [estoque]
GO

/****** Object:  Table [dbo].[Usuario]    Script Date: 07/03/2012 15:51:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](30) NOT NULL,
	[senha] [varchar](10) NOT NULL,
	[perfil] [VARCHAR](20) NOT NULL,
	[idFuncionario] [int] NOT NULL,
	[ativo] [bit] NOT NULL
) ON [PRIMARY]
SET ANSI_PADDING OFF
ALTER TABLE [dbo].[Usuario] ADD [LastEditDate] [datetime] NULL
ALTER TABLE [dbo].[Usuario] ADD [CreationDate] [datetime] NULL
/****** Object:  Index [PK_Funcionario]    Script Date: 07/03/2012 15:51:30 ******/
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Funcionario] FOREIGN KEY([idFuncionario])
REFERENCES [dbo].[Funcionario] ([idFuncionario])
GO

ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Funcionario]
GO

ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_LastEditDate]  DEFAULT (getutcdate()) FOR [LastEditDate]
GO

ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_Usuario_CreationDate]  DEFAULT (getutcdate()) FOR [CreationDate]
GO
