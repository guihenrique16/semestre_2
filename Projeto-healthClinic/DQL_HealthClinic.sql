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
Clinica

INNER JOIN 
Consulta
ON 
Clinica.IdClinica = Consulta.IdClinica

INNER JOIN 
Medico
ON
medico.IdConsulta = Consulta.IdConsulta

INNER JOIN
Usuario M
ON 
M.IdUsuario = Medico.IdUsuario

INNER JOIN
Usuario P
ON 
P.IdUsuario = Paciente.IdUsuario

INNER JOIN
Especialidades
ON 
Medico.IdEspecialidades = Especialidades.IdEspecialidades

LEFT JOIN
Comentarios
ON 
Consulta.IdConsulta = Comentarios.IdConsulta;
