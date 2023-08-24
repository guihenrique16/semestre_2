-- DESAFIO2
-- Criar procedure para retornar a idade de um determinado usuário específico
--USE HealthClinic_Tarde;

CREATE PROCEDURE CalculaIdade 
@Calculo INT
AS 

SELECT Usuario.Nome,YEAR(GETDATE())-YEAR(DataNascimento) AS IDADE
fROM Usuario
WHERE Usuario.IdUsuario = @Calculo;