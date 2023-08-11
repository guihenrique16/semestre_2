--******************************************** DDL ***************************************************--
--CREATE DATABASE [Event+];
--USE [Event+];

--CREATE TABLE TipoDeUsuario
--(
--	IdTipoDeUsuario INT PRIMARY KEY IDENTITY,
--	TituloTipoUsuario VARCHAR (35) NOT NULL UNIQUE
--)

--CREATE TABLE TipoDeEventos
--(
--	IdTipoDeEventos INT PRIMARY KEY IDENTITY,
--	TituloTipoEvento VARCHAR (35) NOT NULL UNIQUE
--)

--CREATE TABLE Instituicao
--(
--	IdInstituicao INT PRIMARY KEY IDENTITY,
--	CNPJ CHAR (14) NOT NULL UNIQUE,
--	Endereco varchar(100) NOT NULL,
--	NomeFantasia VARCHAR (50) NOT NULL
--)

--CREATE TABLE Usuario
--(
--	IdUsuario INT PRIMARY KEY IDENTITY,
--	IdTipoDeUsuario INT FOREIGN KEY REFERENCES TipoDeUsuario(IdTipoDeUsuario),
--	IdInstituicao INT FOREIGN KEY REFERENCES Instituicao(IdInstituicao),
--	Nome VARCHAR (50) NOT NULL,
--	Email VARCHAR (50) NOT NULL UNIQUE,
--	Senha VARCHAR (50) NOT NULL
--)

--CREATE TABLE Evento
--(
--	IdEvento INT PRIMARY KEY IDENTITY,
--	IdTipoDeEventos INT FOREIGN KEY REFERENCES TipoDeEventos(IdTipoDeEventos),
--	IdInstituicao INT FOREIGN KEY REFERENCES Instituicao(IdInstituicao),
--  Nome VARCHAR(50) NOT NULL,
--	Descricao VARCHAR(200) NOT NULL,
--	DataEvento DATE NOT NULL,
--	HoraEvento TIME NOT NULL
--);

	
--CREATE TABLE PresencaEvento
--(
--	IdPresencaEvento INT PRIMARY KEY IDENTITY,
--	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario) NOT NULL,
--	IdEvento INT FOREIGN KEY REFERENCES Evento(IdEvento) NOT NULL,
--	Situacao BIT DEFAULT(0)
--);


--CREATE TABLE ComentarioEvento
--(
--	IdComentario INT PRIMARY KEY IDENTITY,
--	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario) NOT NULL,
--	IdEvento INT FOREIGN KEY REFERENCES Evento(IdEvento) NOT NULL,
--	Descricao VARCHAR(300) NOT NULL,
--	Exibe BIT DEFAULT(0)
--);


--drop table ComentarioEvento
--drop table PresencaEvento
--drop table Evento
--drop table Usuario

--******************************************** DML ***************************************************--

--INSERT INTO TipoDeUsuario(TituloTipoUsuario) 
--VALUES('Administrador'),('Comum');

--INSERT INTO TipoDeEventos(TituloTipoEvento) 
--VALUES('SQLServer');

--INSERT INTO Instituicao(CNPJ,Endereco,NomeFantasia) 
--VALUES(12345678910123,'Rua Niteroi, 180, Sao Caetano do Sul','DevSchools');

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


--select * from TipoDeUsuario;
--select * from TipoDeEventos;
--select * from Instituicao;
--select * from Usuario;
--select * from Evento;
--select * from PresencaEvento;
--select * from ComentarioEvento;


--******************************************** DQL(JOIN) ***************************************************--

-- Criar script para consulta exibindo os seguintes dados

/*Usar JOIN

Nome do usuário
Tipo do usuário
Data do evento
Local do evento (Instituição)
Titulo do evento
Nome do evento
Descrição do evento
Situação do evento
Comentário do evento
*/

SELECT --SELECIONANDO A COLUNA COM OS DADOS A SEREM EXIBIDOS
 Usuario.Nome AS NomeUsuario,
 TipoDeUsuario.TituloTipoUsuario,
 Evento.DataEvento,
 CONCAT(Instituicao.NomeFantasia,' - ',Instituicao.Endereco)  AS Endereco,
 TipoDeEventos.TituloTipoEvento,
 Evento.Nome AS NomeEvento,
 Evento.Descricao,
 CASE WHEN PresencaEvento.Situacao = 1 THEN 'Confirmafo' ELSE 'Nao Confirmado' END AS Situacao,
 ComentarioEvento.Descricao AS Comentario

FROM 
Evento

INNER JOIN 
TipoDeEventos
ON 
Evento.IdTipoDeEventos = TipoDeEventos.IdTipoDeEventos

INNER JOIN
Instituicao
ON 
Evento.IdInstituicao = Instituicao.IdInstituicao

INNER JOIN
PresencaEvento
ON 
Evento.IdEvento = PresencaEvento.IdEvento

INNER JOIN
Usuario
ON 
PresencaEvento.IdUsuario = Usuario.IdUsuario

INNER JOIN
TipoDeUsuario
ON 
Usuario.IdTipoDeUsuario = TipoDeUsuario.IdTipoDeUsuario

LEFT JOIN
ComentarioEvento
ON 
Usuario.IdUsuario = ComentarioEvento.IdUsuario;