using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MCN.Models
{
    public partial class proyecto_r_mcynContext : DbContext
    {
        private string connectionString;

        public proyecto_r_mcynContext(string _ConnectionString)
        {
            this.connectionString = _ConnectionString;
        }

        public proyecto_r_mcynContext()
        {
        }

        public proyecto_r_mcynContext(DbContextOptions<proyecto_r_mcynContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Articulo> Articulo { get; set; }
        public virtual DbSet<Autores> Autores { get; set; }
        public virtual DbSet<CatExtenciones> CatExtenciones { get; set; }
        public virtual DbSet<CatGradoEstudio> CatGradoEstudio { get; set; }
        public virtual DbSet<CatInstituciones> CatInstituciones { get; set; }
        public virtual DbSet<CatLineaTrabajo> CatLineaTrabajo { get; set; }
        public virtual DbSet<Coautores> Coautores { get; set; }
        public virtual DbSet<DetalleArticulos> DetalleArticulos { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<RCaAr> RCaAr { get; set; }
        public virtual DbSet<TipoPersonal> TipoPersonal { get; set; }
        public virtual DbSet<Volumen> Volumen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=localhost;Database=proyecto_r_mcyn;User=root;Password=1234;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articulo>(entity =>
            {
                entity.HasKey(e => e.IdArticulo);

                entity.ToTable("articulo");

                entity.HasIndex(e => e.RAutor)
                    .HasName("R_autor_art_idx");

                entity.HasIndex(e => e.Status)
                    .HasName("R_status_TA_S_idx");

                entity.Property(e => e.IdArticulo)
                    .HasColumnName("idArticulo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComentariosAutor)
                    .IsRequired()
                    .HasColumnName("Comentarios_Autor")
                    .HasColumnType("varchar(350)");

                entity.Property(e => e.FechaEdicionA)
                    .HasColumnName("Fecha_EdicionA")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.FechaPublicacionA)
                    .HasColumnName("Fecha_PublicacionA")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.RAutor)
                    .HasColumnName("R_autor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RutaDocumentoA)
                    .IsRequired()
                    .HasColumnName("Ruta_DocumentoA")
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.RutaZipImagenesA)
                    .IsRequired()
                    .HasColumnName("Ruta_Zip_ImagenesA")
                    .HasColumnType("varchar(300)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TituloArticulo)
                    .IsRequired()
                    .HasColumnName("Titulo_Articulo")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.RAutorNavigation)
                    .WithMany(p => p.Articulo)
                    .HasForeignKey(d => d.RAutor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_autor_art");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Articulo)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_status_TA_S");
            });

            modelBuilder.Entity<Autores>(entity =>
            {
                entity.HasKey(e => e.IdAutores);

                entity.ToTable("autores");

                entity.HasIndex(e => e.Status)
                    .HasName("R_status_Autor_idx");

                entity.HasIndex(e => e.TipoA)
                    .HasName("R_tipo_Autor_idx");

                entity.Property(e => e.IdAutores)
                    .HasColumnName("idAutores")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApellidosA)
                    .IsRequired()
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.ContraseniaA)
                    .IsRequired()
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.CorreoElectronicoA)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.NombreA)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.NombreUsuarioA)
                    .IsRequired()
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoA).HasColumnType("int(11)");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Autores)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_status_Autor");

                entity.HasOne(d => d.TipoANavigation)
                    .WithMany(p => p.Autores)
                    .HasForeignKey(d => d.TipoA)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_tipo_Autor");
            });

            modelBuilder.Entity<CatExtenciones>(entity =>
            {
                entity.HasKey(e => e.IdExtenciones);

                entity.ToTable("cat_extenciones");

                entity.HasIndex(e => e.RInstituciones)
                    .HasName("R_Instituciones_idx");

                entity.HasIndex(e => e.Status)
                    .HasName("R_status_EX_S_idx");

                entity.Property(e => e.IdExtenciones)
                    .HasColumnName("idExtenciones")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NombreExtencion)
                    .HasColumnName("Nombre_Extencion")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.RInstituciones)
                    .HasColumnName("R_Instituciones")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.RInstitucionesNavigation)
                    .WithMany(p => p.CatExtenciones)
                    .HasForeignKey(d => d.RInstituciones)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_Instituciones");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.CatExtenciones)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_status_EX_S");
            });

            modelBuilder.Entity<CatGradoEstudio>(entity =>
            {
                entity.HasKey(e => e.IdGradoEst);

                entity.ToTable("cat_grado_estudio");

                entity.HasIndex(e => e.Status)
                    .HasName("R_status_G_S_idx");

                entity.Property(e => e.IdGradoEst)
                    .HasColumnName("idGrado_Est")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NivelEstudio)
                    .HasColumnName("Nivel_Estudio")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.CatGradoEstudio)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_status_G_S");
            });

            modelBuilder.Entity<CatInstituciones>(entity =>
            {
                entity.HasKey(e => e.IdInstituto);

                entity.ToTable("cat_instituciones");

                entity.HasIndex(e => e.Status)
                    .HasName("R_status_INS_S_idx");

                entity.Property(e => e.IdInstituto)
                    .HasColumnName("idInstituto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NombreInstituto)
                    .HasColumnName("Nombre_Instituto")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.CatInstituciones)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_status_INS_S");
            });

            modelBuilder.Entity<CatLineaTrabajo>(entity =>
            {
                entity.HasKey(e => e.IdLineaTrabajp);

                entity.ToTable("cat_linea_trabajo");

                entity.HasIndex(e => e.Status)
                    .HasName("R_status_L_S_idx");

                entity.Property(e => e.IdLineaTrabajp)
                    .HasColumnName("idLinea_Trabajp")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LineasTrabajo)
                    .HasColumnName("Lineas_trabajo")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.CatLineaTrabajo)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_status_L_S");
            });

            modelBuilder.Entity<Coautores>(entity =>
            {
                entity.HasKey(e => e.IdCoautores);

                entity.ToTable("coautores");

                entity.HasIndex(e => e.RArticulo)
                    .HasName("R_Coaut_Arti_idx");

                entity.HasIndex(e => e.RAutor)
                    .HasName("R_autor_Couator_idx");

                entity.HasIndex(e => e.Rtipo)
                    .HasName("R_tipo_tipo_idx");

                entity.HasIndex(e => e.Status)
                    .HasName("R_statusC_idx");

                entity.Property(e => e.IdCoautores)
                    .HasColumnName("idCoautores")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApellidosCa).HasColumnType("varchar(70)");

                entity.Property(e => e.CorreoElectronico).HasColumnType("varchar(50)");

                entity.Property(e => e.NombreCa).HasColumnType("varchar(50)");

                entity.Property(e => e.RArticulo)
                    .HasColumnName("R_Articulo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RAutor)
                    .HasColumnName("R_Autor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rtipo)
                    .HasColumnName("RTipo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.HasOne(d => d.RArticuloNavigation)
                    .WithMany(p => p.Coautores)
                    .HasForeignKey(d => d.RArticulo)
                    .HasConstraintName("R_Coaut_Arti");

                entity.HasOne(d => d.RAutorNavigation)
                    .WithMany(p => p.Coautores)
                    .HasForeignKey(d => d.RAutor)
                    .HasConstraintName("R_autor_Couator");

                entity.HasOne(d => d.RtipoNavigation)
                    .WithMany(p => p.Coautores)
                    .HasForeignKey(d => d.Rtipo)
                    .HasConstraintName("R_tipo_tipo");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Coautores)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("R_statusC");
            });

            modelBuilder.Entity<DetalleArticulos>(entity =>
            {
                entity.HasKey(e => e.IdDetalleArt);

                entity.ToTable("detalle_articulos");

                entity.HasIndex(e => e.IdArticulo)
                    .HasName("R_articulo_idx");

                entity.HasIndex(e => e.IdPersonal)
                    .HasName("R_usuario_idx");

                entity.HasIndex(e => e.Status)
                    .HasName("R_status_TA_S_idx");

                entity.Property(e => e.IdDetalleArt)
                    .HasColumnName("Id_Detalle_Art")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ComentariosRetroaliment)
                    .HasColumnName("Comentarios_Retroaliment")
                    .HasColumnType("varchar(250)");

                entity.Property(e => e.FechaRevision)
                    .HasColumnName("Fecha_Revision")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.IdArticulo)
                    .HasColumnName("Id_Articulo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPersonal)
                    .HasColumnName("Id_Personal")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdArticuloNavigation)
                    .WithMany(p => p.DetalleArticulos)
                    .HasForeignKey(d => d.IdArticulo)
                    .HasConstraintName("R_articulo");

                entity.HasOne(d => d.IdPersonalNavigation)
                    .WithMany(p => p.DetalleArticulos)
                    .HasForeignKey(d => d.IdPersonal)
                    .HasConstraintName("R_usuario");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.DetalleArticulos)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_status_DA_S");
            });

            modelBuilder.Entity<Estados>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.ToTable("estados");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("idEstado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DescEstados)
                    .HasColumnName("Desc_Estados")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Lestados)
                    .IsRequired()
                    .HasColumnName("LEstados")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.HasKey(e => e.IdPersonal);

                entity.ToTable("personal");

                entity.HasIndex(e => e.RExtencionesP)
                    .HasName("R_extenciones_idx");

                entity.HasIndex(e => e.RGradoEstudio)
                    .HasName("R_grado_idx");

                entity.HasIndex(e => e.RLineaTrabajo)
                    .HasName("R_lineatrabajo_idx");

                entity.HasIndex(e => e.Status)
                    .HasName("R_status_P_S_idx");

                entity.HasIndex(e => e.TipoP)
                    .HasName("R_tipo_idx");

                entity.Property(e => e.IdPersonal)
                    .HasColumnName("idPersonal")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApellidoP)
                    .IsRequired()
                    .HasColumnType("varchar(60)");

                entity.Property(e => e.Contrasenia)
                    .IsRequired()
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.CorreoElectronicoP)
                    .IsRequired()
                    .HasColumnName("Correo_ElectronicoP")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.NombreP)
                    .IsRequired()
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.NombreUsuarioP)
                    .IsRequired()
                    .HasColumnName("Nombre_UsuarioP")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.RExtencionesP)
                    .HasColumnName("R_ExtencionesP")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RGradoEstudio)
                    .HasColumnName("R_Grado_Estudio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RLineaTrabajo)
                    .HasColumnName("R_Linea_Trabajo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoP).HasColumnType("int(11)");

                entity.HasOne(d => d.RExtencionesPNavigation)
                    .WithMany(p => p.Personal)
                    .HasForeignKey(d => d.RExtencionesP)
                    .HasConstraintName("R_extenciones");

                entity.HasOne(d => d.RGradoEstudioNavigation)
                    .WithMany(p => p.Personal)
                    .HasForeignKey(d => d.RGradoEstudio)
                    .HasConstraintName("R_grado");

                entity.HasOne(d => d.RLineaTrabajoNavigation)
                    .WithMany(p => p.Personal)
                    .HasForeignKey(d => d.RLineaTrabajo)
                    .HasConstraintName("R_lineatrabajo");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Personal)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_status_P_S");

                entity.HasOne(d => d.TipoPNavigation)
                    .WithMany(p => p.Personal)
                    .HasForeignKey(d => d.TipoP)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_tipo");
            });

            modelBuilder.Entity<RCaAr>(entity =>
            {
                entity.HasKey(e => e.IdTb);

                entity.ToTable("r_ca_ar");

                entity.HasIndex(e => e.RArticulo)
                    .HasName("R_articulo_idx");

                entity.HasIndex(e => e.RCoautor)
                    .HasName("R_coautor_idx");

                entity.Property(e => e.IdTb)
                    .HasColumnName("Id_tb")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RArticulo)
                    .HasColumnName("R_articulo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RCoautor)
                    .HasColumnName("R_Coautor")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.RArticuloNavigation)
                    .WithMany(p => p.RCaAr)
                    .HasForeignKey(d => d.RArticulo)
                    .HasConstraintName("R_articuloAR");

                entity.HasOne(d => d.RCoautorNavigation)
                    .WithMany(p => p.RCaAr)
                    .HasForeignKey(d => d.RCoautor)
                    .HasConstraintName("R_coautorCA");
            });

            modelBuilder.Entity<TipoPersonal>(entity =>
            {
                entity.HasKey(e => e.IdTipoP);

                entity.ToTable("tipo_personal");

                entity.HasIndex(e => e.Status)
                    .HasName("R_status_TP_S_idx");

                entity.Property(e => e.IdTipoP)
                    .HasColumnName("idTipo_P")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoUsuarios)
                    .IsRequired()
                    .HasColumnName("Tipo_Usuarios")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.TipoPersonal)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_status_TP_S");
            });

            modelBuilder.Entity<Volumen>(entity =>
            {
                entity.HasKey(e => e.IdVolumen);

                entity.ToTable("volumen");

                entity.Property(e => e.IdVolumen)
                    .HasColumnName("idVolumen")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DescripcionV)
                    .IsRequired()
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.EdicionVol)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.FechaPublicacionV)
                    .HasColumnName("Fecha_PublicacionV")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.PortadaV)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.TituloV)
                    .IsRequired()
                    .HasColumnName("Titulo_V")
                    .HasColumnType("varchar(50)");
            });
        }
    }
}
