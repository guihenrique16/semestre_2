using WebApi.HealthClinic.Tarde.Domains;

namespace WebApi.HealthClinic.Tarde.Interfaces
{
    public interface IComentarioRepository
    {
        void Cadastrar(Comentario comentario);

        void Deletar(Guid id);    

        List<Comentario> GetAll();

        Comentario BuscarPorConsulta(Guid id);   
    }
}
