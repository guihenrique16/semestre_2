-- DML_EX_1_3
USE Exercicio_1_3;

INSERT INTO Clinica(Endereco)
VALUES('Rua Niteroi, N 1005 ');

INSERT INTO Donos(Nome)
VALUES('Guilherme'),('Mumu');

INSERT INTO TipoPet(Nome)
VALUES('cachorro'),('Gato');

INSERT INTO Raca(Nome)
VALUES('Shih-tzu'),('siames');

INSERT INTO Veterinario(IdClinica,Nome)
VALUES(1,'veterinario1'),(1,'veterinario2');

INSERT INTO Atendimento(IdClinica,IdVeterinario,Numero)
VALUES(1,1,'50'),(1,2,'51');

INSERT INTO Pet(IdDonos,IdTipoPet,Idraca,Nome,DtNascimento)
VALUES(1,2,2,'gato1','21/07/2020'),(2,1,1,'dog1','17/10/2018');

SELECT * FROM Clinica
SELECT * FROM Donos
SELECT * FROM TipoPet
SELECT * FROM Raca
SELECT * FROM Veterinario
SELECT * FROM Atendimento
SELECT * FROM Pet


delete from Clinica where IdClinica = 2
delete from Donos where IdDonos = 3 or  Iddonos = 4


