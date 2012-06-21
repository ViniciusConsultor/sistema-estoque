
CREATE TABLE dbo.Produtos
	(
	idProduto INT IDENTITY NOT NULL,
	nome VARCHAR (50),
	idCategoria TINYINT,
	quantidade VARCHAR (5),
	valor VARCHAR (5)
	CONSTRAINT PK_Produtos PRIMARY KEY (idProduto),
	CONSTRAINT FK_Produtos FOREIGN KEY (idCategoria) REFERENCES dbo.categoria (idCategoria)
	)
GO
