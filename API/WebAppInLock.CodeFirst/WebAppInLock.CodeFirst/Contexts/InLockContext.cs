using Microsoft.EntityFrameworkCore;
using WebAppInLock.CodeFirst.Domain;

namespace WebAppInLock.CodeFirst.Contexts
{
    public class InLockContext : DbContext
    {
        //define as entidades do banco de dados

        public DbSet<Estudio> Estudio { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<TiposUsuario> TiposUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= NOTE02-S14; Database= inlock_games_codeFirst_manha; User Id=sa; pwd=Senai@134 ; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
