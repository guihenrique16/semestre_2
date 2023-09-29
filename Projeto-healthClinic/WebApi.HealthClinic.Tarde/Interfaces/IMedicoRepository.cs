﻿using WebApi.HealthClinic.Tarde.Domains;

namespace WebApi.HealthClinic.Tarde.Interfaces
{
    public interface IMedicoRepository
    {
        void cadastrar(Medico medico);

        void Deletar(Medico medico);

        void Atualizar(Medico medico, Guid id);

        List<Medico> BuscarPorEspecialidades(string titulo);
    }
}
