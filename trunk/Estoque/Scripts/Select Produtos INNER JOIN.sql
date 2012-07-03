SELECT p.idProduto,p.nome,p.codigoBarras,p.diponivel,p.valorAVista,p.valorBase,p.valorPrazo,
p.valorCredito,c.categoria,f.nome,f.usuario,p.cadastradoEm FROM Produtos AS p
INNER JOIN categoria AS c ON c.idCategoria = p.idCategoria
INNER JOIN Funcionario AS f ON f.idFuncionario = p.cadstradoPor