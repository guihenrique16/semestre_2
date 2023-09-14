use inlock_games_codeFirst_Tarde;

Insert into Estudio
VALUES (NEWID(),'SENAI'),(NEWID(),'SESI'),(NEWID(),'SEBRAE')

select * from Estudio

INSERT INTO Jogo
VALUES (NEWID(),'Rainbow Six Siege','Jogo de tiro','2023-01-01',99.00,'BCD58A9B-6637-4C83-9585-05C729023C6E'),
	   (NEWID(),'FIFA','Jogo de futebol','2022-03-23',99.99,'BCD58A9B-6637-4C83-9585-05C729023C6E')

select * from Jogo

INSERT INTO TiposUsuario
VALUES (NEWID(),'administrador'),(NEWID(),'comum')
select * from TiposUsuario

INSERT INTO Usuario
VALUES (NEWID(),'adm@adm.com','SenhaADM','DAA161CE-7AC1-4309-ABCA-C5874FFA6A7D'),
	   (NEWID(),'comum@comum.com','SenhaCM','99E5077F-8FBA-41B1-A5E7-90196A88AD0D')
select * from Usuario

DELETE FROM Estudio WHERE IdEstudio = '94E4182F-6D54-4B4D-91E6-F328ABA5EC8B'
select * from Estudio