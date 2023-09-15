using webApi.Inlock.CodeFirst.Context;
using webApi.Inlock.CodeFirst.Domains;
using webApi.Inlock.CodeFirst.Interfaces;
using webApi.Inlock.CodeFirst.Utils;

namespace webApi.Inlock.CodeFirst.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        /// <summary>
        /// Variavel Privada e somente leitura para armazenar os dados do contexto 
        /// </summary>
        private readonly InlockContext ctx;

        /// <summary>
        /// Construtor do repositorio 
        /// Toda vez que o repositorio for instanciado, Ele tera acesso aos dados fornecidos pelo conterxto 
        /// </summary>
        public UsuarioRepository()
        {
            ctx = new InlockContext();
        }
        public Usuario BuscarUsuario(string email, string senha)
        {
            try
            {
                Usuario buscaUser = ctx.Usuario.FirstOrDefault(u => u.Email == email)!;
                if (buscaUser == null)
                {
                    bool AnaliseSenha = Criptografia.CompararHash(senha, buscaUser!.Senha!);

                    if (AnaliseSenha)
                    {
                        return buscaUser;
                    }
                }

                return null!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Usuario usuario)
        {

            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha!);

                ctx.Add(usuario);
                ctx.SaveChanges();

            }
            catch (Exception)
            {
                throw; 
            }
        }
    }
}
