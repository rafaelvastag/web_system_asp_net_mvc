using Microsoft.EntityFrameworkCore;
using SalesSystemMVC.Models;

namespace SalesSystemMVC.Data
{
    public class UsuarioDbContext : DbContext
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options)
           : base(options)
        {
    }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<TipoTelefone> TipoTelefone { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PessoaTelefone>()
                .HasKey(bc => new { bc.PessoaId, bc.TelefoneId });
            modelBuilder.Entity<PessoaTelefone>()
                .HasOne(bc => bc.Pessoa)
                .WithMany(b => b.PessoaTelefone)
                .HasForeignKey(bc => bc.PessoaId);
            modelBuilder.Entity<PessoaTelefone>()
                .HasOne(bc => bc.Telefone)
                .WithMany(c => c.PessoaTelefone)
                .HasForeignKey(bc => bc.TelefoneId);
        }
    }
}
