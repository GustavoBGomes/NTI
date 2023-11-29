SELECT c.NomeCliente, p.PedidoID, p.DataPedido
FROM Pedidos p
INNER JOIN Clientes c ON p.ClienteID = c.ClienteID
ORDER BY p.DataPedido DESC;