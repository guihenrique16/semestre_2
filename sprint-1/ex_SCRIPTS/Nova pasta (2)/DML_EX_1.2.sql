USE Exercicio_1_2;

INSERT INTO Empresa(Nome)
VALUES('Locadora1'),('Locadora2');

INSERT INTO Cliente(Nome)
VALUES('Guilherme'),('Mumu');

INSERT INTO Marca(Nome)
VALUES('BMW'),('JEEP');

INSERT INTO Modelo(Nome)
VALUES('i30'),('Renegade');

INSERT INTO Veiculo(IdEmpresa,IdModelo,IdMarca,Placa)
VALUES(1,2,2,'AFC57JG71'),(2,1,1,'GTH41JK67');

INSERT INTO Aluguel(Idveiculo,IdCliente,valor,[Data])
VALUES(1,1,80000,'03/07/2023'),(2,2,150000,'03/07/2023');

SELECT * FROM Empresa
SELECT * FROM Cliente
SELECT * FROM Marca
SELECT * FROM Modelo
SELECT * FROM Veiculo
SELECT * FROM Aluguel
