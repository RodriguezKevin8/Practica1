using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Practica1.Models;

public partial class UsuarioContext : DbContext
{
    public UsuarioContext()
    {
    }

    public UsuarioContext(DbContextOptions<UsuarioContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-5SK7M5O; Database=usuario; Trusted_Connection=True; TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Idusuario).HasName("PK__usuario__080A9743ADB69E02");

            entity.ToTable("usuario");

            entity.Property(e => e.Idusuario).HasColumnName("idusuario");
            entity.Property(e => e.Conocimiento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("conocimiento");
            entity.Property(e => e.Contrasenia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("contrasenia");
            entity.Property(e => e.Curso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("curso");
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Genero)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("genero");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Pasatiempo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pasatiempo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
