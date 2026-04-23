using Microsoft.EntityFrameworkCore;
using SistemaBancario.Classes.Entidades;

namespace SistemaBancario.Classes.Contextos
{
    internal class BancoContext:DbContext
    {
        //Propriedades
        /// <summary>
        /// Representa a tabela de contas báncarias do banco de dados 
        /// DbSet permite realizar operações CRUD
        /// </summary>
        public DbSet <Banco> contas {  get; set; }

        //Métodos 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=ECFP507D1319370\SQLEXPRESS;Database=Banco;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Banco>(entity=>
            {
                entity.HasKey(e=>e.Id);
                entity.Property(e=>e.NumeroConta).IsRequired();
                entity.Property(e=>e.Titular).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Saldo).HasColumnType("decimal(18,2)");

            }
                
                
            );
        }

    }

}
