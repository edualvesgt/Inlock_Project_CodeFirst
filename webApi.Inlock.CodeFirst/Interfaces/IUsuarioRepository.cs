using webApi.Inlock.CodeFirst.Domains;

namespace webApi.Inlock.CodeFirst.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario BuscarUsuario(string email, string senha);

        void Cadastrar (Usuario usuario);
    }
}
