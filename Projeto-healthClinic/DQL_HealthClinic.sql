--**************************************** DQL *********************************************************--
--Criar script que exiba os seguintes dados:
--- Id Consulta
--- Nome da Clinica
--- Nome do Paciente
--- Nome do Medico
--- Especialidade do Medico
--- CRM
--- Prontuário ou Descricao
--- FeedBack(Comentario da consulta

USE HealthClinic_Tarde;

SELECT 
 Consulta.IdConsulta,
 Clinica.NomeFantasia,
 P.Nome,
 M.Nome,
 Especialidades.TituloEspecialidades AS Especialidades,
 Medico.CRM,
 Consulta.Prontuário,
 comentarios.feedbacks

FROM
Consulta

INNER JOIN
Clinica
ON
Consulta.IdClinica = Clinica.IdClinica

INNER JOIN 
Medico
ON 
Consulta.IdMedico = Medico.IdMedico

INNER JOIN
Especialidades
ON 
Medico.IdEspecialidades = Especialidades.IdEspecialidades

LEFT JOIN 
comentarios
ON
Consulta.IdConsulta = comentarios.IdConsulta

INNER JOIN 
Paciente
ON
Paciente.IdPaciente = Consulta.IdPaciente

INNER JOIN 
Usuario P
ON
P.IdUsuario = Paciente.IdUsuario

INNER JOIN 
Usuario M 
ON 
M.IdUsuario = Medico.IdUsuario
