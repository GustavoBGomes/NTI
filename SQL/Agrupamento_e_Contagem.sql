SELECT 
c.NomeCategoria, COUNT(p.ProdutoID) AS NumeroDeProdutos
FROM Categorias c
LEFT JOIN Produtos p ON p.CategoriaID = c.CategoriaID
GROUP BY 
c.NomeCategoria;
