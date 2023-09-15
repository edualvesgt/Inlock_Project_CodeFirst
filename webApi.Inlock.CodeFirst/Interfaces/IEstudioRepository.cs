using webApi.Inlock.CodeFirst.Domains;

namespace webApi.Inlock.CodeFirst.Interfaces
{
    public interface IEstudioRepository
    {
        public interface IEstudioRepository
        {
            List<Estudio> Listar();

            Estudio BuscarPorId(Guid id);

            void Cadastrar(Estudio estudio);

            void Atualizar(Guid id, Estudio estudio);

            void Deletar(Guid id);

            List<Estudio> ListarComJogos();
        }
    }
}
