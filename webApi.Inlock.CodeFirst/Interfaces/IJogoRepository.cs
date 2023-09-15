using webApi.Inlock.CodeFirst.Domains;

namespace webApi.Inlock.CodeFirst.Interfaces
{
    public interface IJogoRepository
    {
        List<Jogo> Listar();

        Jogo BuscarPorId(Guid id);

        void Cadastrar(Jogo novoJogo);

        void Atualizar(Guid id, Jogo jogo);

        void Deletar(Guid id);
    }
}
