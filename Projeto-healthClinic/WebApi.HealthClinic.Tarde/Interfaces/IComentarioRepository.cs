using WebApi.HealthClinic.Tarde.Domains;

namespace WebApi.HealthClinic.Tarde.Interfaces
{
    public interface IComentarioRepository
    {
        void Cadastrar(Comentario comentario);

        void Deletar(Comentario comentario);    

        List<Comentario> GetAll();

        Comentario BuscarPorConsulta();   
    }
}
