-- Operações READ - LER

SELECT * FROM Contas;
GO


SELECT Id, Titular,Numero_da_Conta,Saldo FROM Contas
WHERE Saldo > 1000
GO

SELECT * FROM Contas 
WHERE Titular LIKE '%Maria%';
GO