---- DESAFIO1
---- Criar função para retornar os médicos de uma determinada especialidade

---- Criar uma função para retornar médicos por especialidade

--CREATE FUNCTION MedicosPorEspecialidade
--(
--	@especialidade varchar(100)
--)
--RETURNS TABLE
--AS
--RETURN
--(
--    select MedicoUsuario.Nome as Médico, 
--	Especialidades.TituloEspecialidades as Especialidade
--	from Especialidades
--	inner join Medico on Medico.IdEspecialidades = Especialidades.IdEspecialidades
--	inner join Usuario as MedicoUsuario on Medico.IdUsuario = MedicoUsuario.IdUsuario
--    WHERE  Especialidades.TituloEspecialidades = @especialidade 
 
--);

--SELECT * FROM MedicosPorEspecialidade('Neurologista');
