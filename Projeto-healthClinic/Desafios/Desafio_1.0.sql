---- DESAFIO1
---- Criar fun��o para retornar os m�dicos de uma determinada especialidade

---- Criar uma fun��o para retornar m�dicos por especialidade

--CREATE FUNCTION MedicosPorEspecialidade
--(
--	@especialidade varchar(100)
--)
--RETURNS TABLE
--AS
--RETURN
--(
--    select MedicoUsuario.Nome as M�dico, 
--	Especialidades.TituloEspecialidades as Especialidade
--	from Especialidades
--	inner join Medico on Medico.IdEspecialidades = Especialidades.IdEspecialidades
--	inner join Usuario as MedicoUsuario on Medico.IdUsuario = MedicoUsuario.IdUsuario
--    WHERE  Especialidades.TituloEspecialidades = @especialidade 
 
--);

--SELECT * FROM MedicosPorEspecialidade('Neurologista');
