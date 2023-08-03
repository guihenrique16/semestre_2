USE Exercicio_1_1;

INSERT INTO Pessoa(Nome,CNH)
VALUES('Guilherme','8569742310'),('Mumu','5421679863');

--INSERT INTO Pessoa VALUES('Guilherme', '8569742310'),('Mumu', '5421679863')

INSERT INTO Email(IdPessoa,endereco)
VALUES(1,'gui@gmail.com'),(2,'Mumu@gmail.com'),(1,'gui2@gmail.com');

INSERT INTO Telefone(IdPessoa,Numero)
VALUES(1,'11 93543-8756'),(2,'11 93654-1875'),(1,'11 92463-1951');


SELECT * FROM Pessoa
SELECT * FROM Email
SELECT * FROM Telefone