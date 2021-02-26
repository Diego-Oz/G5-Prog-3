using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ApiBolsa.Model
{
    public partial class BolsaContext : DbContext
    {
        public BolsaContext()
        {

        }

        public BolsaContext(DbContextOptions<BolsaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Empleo> Empleos { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:apglearn.database.windows.net,1433;Initial Catalog=Proyecto1;Persist Security Info=False;User ID=Equipo;Password=Estaenitla1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.Property(e => e.NombreCategoria).IsUnicode(false);
            });

            modelBuilder.Entity<Empleo>(entity =>
            {
                entity.Property(e => e.Compañia).IsUnicode(false);

                entity.Property(e => e.Descripcion).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Posicion).IsUnicode(false);

                entity.Property(e => e.Tipo).IsUnicode(false);

                entity.Property(e => e.Ubicacion).IsUnicode(false);

                entity.Property(e => e.Url).IsUnicode(false);

                entity.HasOne(d => d.CategoriasNavigation)
                    .WithMany(p => p.Empleos)
                    .HasForeignKey(d => d.Categorias)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Categorias");

                entity.HasOne(d => d.EmailNavigation)
                    .WithMany(p => p.Empleos)
                    .HasPrincipalKey(p => p.Email)
                    .HasForeignKey(d => d.Email)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_empleo");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.Property(e => e.Contraseña).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.TipoUsuario).IsUnicode(false);

                entity.Property(e => e.Usuario).IsUnicode(false);

                entity.HasOne(d => d.TipoUsuarioNavigation)
                    .WithMany(p => p.Logins)
                    .HasPrincipalKey(p => p.Rol)
                    .HasForeignKey(d => d.TipoUsuario)
                    .HasConstraintName("FK__Login__Tipo_usua__03F0984C");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Rol).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
