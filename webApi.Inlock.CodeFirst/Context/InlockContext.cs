using Microsoft.EntityFrameworkCore;
using webApi.Inlock.CodeFirst.Domains;

namespace webApi.Inlock.CodeFirst.Context
{
    public class InlockContext : DbContext
    {
        public DbSet<Estudio> Estudio { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<TiposUsuario> TiposUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        //Define as Opcoes de construcao do banco (string de conexao )

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = NOTE15-S15; Database = Inlock_Games_CodeFirst; User Id = sa ; pwd = Senai@134; TrustServerCertificate = True");

            base.OnConfiguring(optionsBuilder);
        }

    }
}
