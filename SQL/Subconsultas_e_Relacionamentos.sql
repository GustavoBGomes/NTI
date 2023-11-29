SELECT 
a.NomeAluno, 
AVG(n.Nota) AS MediaNotas
FROM Alunos a
INNER JOIN Notas n ON a.AlunoID = n.AlunoID
GROUP BY a.NomeAluno;