-- DDL

-- CRIA BD
CREATE DATABASE BancoTarde;

-- USA O BD
USE BancoTarde;

----------------------------------------------------------------------------------

-- CRIA A TABELA
CREATE TABLE Funcionarios
(
	IdFuncionarios INT PRIMARY KEY IDENTITY, 
	Nome VARCHAR (10)
);

CREATE TABLE Empresas
(
	IdEmpresa INT PRIMARY KEY IDENTITY,
	IdFuncionarios INT FOREIGN KEY REFERENCES Funcionarios(IdFuncionarios),
	Nome VARCHAR(20)
);

-----------------------------------------------------------------------------------------------

-- ALTER TABLE
ALTER TABLE Funcionarios
ADD CPF VARCHAR(11)

ALTER TABLE Funcionarios
DROP COLUMN CPF 

DROP TABLE Empresas; 

DROP DATABASE BancoTarde;