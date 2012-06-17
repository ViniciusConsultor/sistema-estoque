CREATE TABLE [Cidade](
[CidadeId] [int] NOT NULL,
[Nome] [varchar](38) NOT NULL,
[IdEstado] [tinyint] NULL,
[Capital] [bit] NOT NULL,
CONSTRAINT [PK_Cidade] PRIMARY KEY ([CidadeId])
)

ALTER TABLE [Cidade] ADD
CONSTRAINT [FK_Cidade_Estado] FOREIGN KEY ([IdEstado]) REFERENCES [Estado] ([IdEstado])

CREATE UNIQUE INDEX [IX_Cidade] ON [Cidade] ([Nome],[IdEstado],[Capital])
