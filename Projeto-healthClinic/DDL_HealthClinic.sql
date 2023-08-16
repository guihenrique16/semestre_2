----**************************************** DDL *********************************************************--
--CREATE DATABASE HealthClinic_Tarde;
--	USE HealthClinic_Tarde;

-- CREATE TABLE TiposDeUsuarios
-- (
--	IdTiposDeUsuarios INT PRIMARY KEY IDENTITY,
--	TituloTipoUsuario VARCHAR (35) NOT NULL UNIQUE
-- );

-- CREATE TABLE Clinica
--(
--	IdClinica INT PRIMARY KEY IDENTITY,
--	CNPJ CHAR (14) NOT NULL UNIQUE,
--	Endereco varchar(100) NOT NULL,
--	NomeFantasia VARCHAR (50) NOT NULL,
--	HoraDeInicio TIME NOT NULL,
--	HoraFinal TIME NOT NULL
--);

--CREATE TABLE Especialidades 
--(
--	IdEspecialidades INT PRIMARY KEY IDENTITY,
--	TituloEspecialidades VARCHAR (35) NOT NULL UNIQUE
--);

--CREATE TABLE Usuario
--(
--	IdUsuario INT PRIMARY KEY IDENTITY,
--	IdTiposDeUsuarios INT FOREIGN KEY REFERENCES TiposDeUsuarios(IdTiposDeUsuarios),
--	Nome VARCHAR (50) NOT NULL,
--	DataNascimento DATE NOT NULL,
--	Telefone VARCHAR (20) NOT NULL,
--	Email VARCHAR (50) NOT NULL UNIQUE,
--	Senha VARCHAR (50) NOT NULL,
--);

--CREATE TABLE Paciente
--(
--	IdPaciente INT PRIMARY KEY IDENTITY,
--	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
--	CPF CHAR (11) NOT NULL UNIQUE,
--	CEP CHAR (8) NOT NULL,
--);

--CREATE TABLE Medico
--(
--	IdMedico INT PRIMARY KEY IDENTITY,
--	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
--	IdEspecialidades INT FOREIGN KEY REFERENCES Especialidades(IdEspecialidades),
--	CRM VARCHAR (15) NOT NULL UNIQUE
--);

--CREATE TABLE Consulta
--(
--	IdConsulta INT PRIMARY KEY IDENTITY,
--	IdClinica INT FOREIGN KEY REFERENCES Clinica(IdClinica), 
--	IdMedico INT FOREIGN KEY REFERENCES Medico(IdMedico),
--	IdPaciente  INT FOREIGN KEY REFERENCES Paciente(IdPaciente),
--	prontuário VARCHAR (250) NOT NULL
--);

--CREATE TABLE comentarios
--(
--	Idcomentarios INT PRIMARY KEY IDENTITY,
--	IdConsulta INT FOREIGN KEY REFERENCES Consulta(IdConsulta), 
--	feedbacks VARCHAR (350) NOT NULL
--);

--DROP TABLE Clinica;
--DROP TABLE Consulta;
--DROP TABLE comentarios;
--DROP TABLE TiposDeUsuarios;
--DROP TABLE Usuario;
--DROP TABLE Medico;
--DROP TABLE Paciente;


--drop database HealthClinic_Tarde