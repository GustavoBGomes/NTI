SELECT 
c.NomeCliente, 
p.PedidoID, 
SUM(pr.Quantidade) AS QuantidadeTotal
FROM Clientes c
INNER JOIN Pedidos p ON c.ClienteID = p.ClienteID
INNER JOIN (
    SELECT 
    PedidoID, 
    COUNT(ProdutoID) AS Quantidade
    FROM Produtos
    GROUP BY PedidoID
) pr ON p.PedidoID = pr.PedidoID
GROUP BY 
c.NomeCliente, 
p.PedidoID;