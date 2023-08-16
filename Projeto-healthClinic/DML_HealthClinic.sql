----**************************************** DML *********************************************************--
--USE HealthClinic_Tarde;

--INSERT INTO TiposDeUsuarios(TituloTipoUsuario) 
--VALUES('Paciente'),('Medico'),('Adm');

--INSERT INTO Clinica(CNPJ,Endereco,NomeFantasia,HoraDeInicio,HoraFinal) 
--VALUES(12345678910123,'Rua Niteroi, 180, Sao Caetano do Sul','HealthClinic','07:00','18:00');

--INSERT INTO Especialidades(TituloEspecialidades) 
--VALUES('Cardiologista'),('Ginecologista'),('Neurologista');

--INSERT INTO Usuario(IdTiposDeUsuarios,Nome,DataNascimento,Telefone,Email,Senha) 
--VALUES
--	(2,'Guilherme','14/10/2005','11 93875-1745','guilherme@gmail.com','******'),
--	(3,'Mumu','12/11/2005','11 94653-8746','mumu@gmail.com','******'),
--	(1,'Gilipi Fois','14/01/2007','11 93462-96785','gilipifois@gmail.com','******');

--INSERT INTO Paciente(IdUsuario,CPF,CEP) 
--VALUES
--	(6,'48751806832','14015040')


--INSERT INTO Medico(IdUsuario,IdEspecialidades,CRM) 
--VALUES
--	(4,3,'CRM/SP-009471')

--INSERT INTO Consulta(IdClinica,IdMedico,IdPaciente,prontuário) 
--VALUES 
--	(1,1,2,'Descriçâo Prontuario')
	
--INSERT INTO comentarios(IdConsulta,feedbacks) 
--VALUES 
--	(1,'Fui atendido rapidamente, por um excelente medico')

--select * from Clinica;
--select * from TiposDeUsuarios;
--select * from Usuario
--select * from Paciente
--select * from Especialidades;
--select * from Medico;
--select * from Consulta;
--select * from comentarios;