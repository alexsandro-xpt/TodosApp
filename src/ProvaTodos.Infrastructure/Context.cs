using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProvaTodos.Domain;

namespace ProvaTodos.Infrastructure
{
    public class Context : DbContext, Domain.Interfaces.IContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<OperacaoUsuario> OperacaoUsuario { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Perfil> UsuarioPerfil { get; set; }

        public Context(DbContextOptions options) : base(options)
        {

        }

        public Context(IDefaultContextOptions contextOptions) : base(contextOptions.GetOptions())
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OperacaoUsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PerfilConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioPerfilConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public void Commit()
        {
            System.Console.WriteLine("dasdsadasd");
            base.SaveChanges();
        }
    }

    public class DefaultContextOptions : IDefaultContextOptions
    {
        private readonly IConfiguration _config;

        public DefaultContextOptions(IConfiguration config)
        {
            _config = config;
        }

        public DbContextOptions GetOptions()
        {
            var config = _config.GetConnectionString(_config["Database:DefaultConnection"]);
            return new DbContextOptionsBuilder().UseSqlServer(config).Options;
        }
    }

    public interface IContextOptions
    {
        DbContextOptions GetOptions();
    }

    public interface IDefaultContextOptions : IContextOptions
    { }

}