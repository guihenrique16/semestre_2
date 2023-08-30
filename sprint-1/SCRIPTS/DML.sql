-- DML
USE BancoTarde;

INSERT INTO Funcionarios(Nome)
VALUES ('GOIS')

UPDATE Funcionarios
SET Nome = 'Gois' WHERE Nome = 'GOIS'

DELETE FROM Funcionarios WHERE IdFuncionarios = 11

INSERT INTO Empresas(IdFuncionarios,Nome)
VALUES (10,'Google')
