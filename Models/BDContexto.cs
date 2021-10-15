using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace projetoTeste.Models
{
    public partial class BDContexto : DbContext
    {
        public BDContexto()
        {
        }

        public BDContexto(DbContextOptions<BDContexto> options)
            : base(options)
        {
        }

        public virtual DbSet<Municipio> Municipio { get; set; }
        public virtual DbSet<Proprietario> Proprietario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=root;database=imobiliaria");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.HasKey(e => e.CodMuni)
                    .HasName("PRIMARY");

                entity.ToTable("municipio");

                entity.Property(e => e.CodMuni).HasColumnName("codMuni");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(2);

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(30);

                entity.Property(e => e.Populacao)
                    .HasColumnName("populacao")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Proprietario>(entity =>
            {
                entity.HasKey(e => e.CpfProp)
                    .HasName("PRIMARY");

                entity.ToTable("proprietario");

                entity.Property(e => e.CpfProp)
                    .HasColumnName("cpfProp")
                    .HasMaxLength(11);

                entity.Property(e => e.EstadoCivil)
                    .HasColumnName("estadoCivil")
                    .HasMaxLength(15);

                entity.Property(e => e.Nome)
                    .HasColumnName("nome")
                    .HasMaxLength(30);

                entity.Property(e => e.Profissao).HasColumnName("profissao");

                entity.Property(e => e.Telefone)
                    .HasColumnName("telefone")
                    .HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
