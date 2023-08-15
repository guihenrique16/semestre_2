--**************************************** DML *********************************************************--
USE HealthClinic_Tarde;

INSERT INTO TiposDeUsuarios(TituloTipoUsuario) 
VALUES('Paciente'),('Medico'),('Adm');

INSERT INTO Clinica(CNPJ,Endereco,NomeFantasia,HoraDeInicio,HoraFinal) 
VALUES(12345678910123,'Rua Niteroi, 180, Sao Caetano do Sul','HealthClinic','07:00','18:00');

INSERT INTO Especialidades(TituloEspecialidades) 
VALUES('Cardiologista'),('Ginecologista'),('Neurologista');

--INSERT INTO Usuario(IdTipoDeUsuario,IdInstituicao,Nome,Email,Senha) 
--VALUES
--	(1,1,'Guilherme','guilherme@gmail.com','******'),
--	(2,1,'Mumu','mumu@gmail.com','******'),
--	(2,1,'Gilipi Fois','gilipifois@gmail.com','******');

--INSERT INTO Evento(IdTipoDeEventos,IdInstituicao,Nome,Descricao,DataEvento,HoraEvento) 
--VALUES
--	(1,1,'SQLServer','intesivao de SQLServer, pratico e teorico!!','11/08/2023','15:30:00'),
--	(1,1,'SQLServer','intesivao de SQLServer, pratico e teorico!!','11/08/2023','15:30:00'),
--	(1,1,'SQLServer','intesivao de SQLServer, pratico e teorico!!','11/08/2023','15:30:00');

--INSERT INTO PresencaEvento(IdUsuario,IdEvento) 
--VALUES
--	(2,1),
--	(3,1);

--INSERT INTO ComentarioEvento(IdUsuario,IdEvento,Descricao) 
--VALUES 
--	(2,1,'foi muito legal, o careca manja muito!!'),
--	(3,1,'o careca manja muito!!');


select * from TiposDeUsuarios;
select * from Clinica;
select * from Especialidades;
--select * from Evento;
--select * from PresencaEvento;
--select * from ComentarioEvento;