using SchoolTech.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Numerics;

namespace SchoolTech.Data
{
    public class SchoolTechContext : IdentityDbContext<Gebruiker>
    {
        public SchoolTechContext(DbContextOptions<SchoolTechContext> options) : base(options)
        {
        }

        public DbSet<Afwezigheid> Afwezigheden { get; set; } = default!;
        public DbSet<Begeleiding> Begeleidingen { get; set; } = default!;
        public DbSet<Bijlage> Bijlages { get; set; } = default!;
        public DbSet<Foto> Fotos { get; set; } = default!;
        public DbSet<FotoAlbum> FotoAlbums { get; set; } = default!;
        public DbSet<Gebruiker> Gebruiker { get; set; } = default!;
        public DbSet<GebruikerNavorming> GebruikerNavormingen { get; set; } = default!;
        public DbSet<GebruikerRol> GebuikerRollen { get; set; } = default!;
        public DbSet<Klas> Klassen { get; set; } = default!;
        public DbSet<KlasStudiebezoek> KlasStudiebezoeken { get; set; } = default!;
        public DbSet<Navorming> Navormingen { get; set; } = default!;
        public DbSet<Rol> Rollen { get; set; } = default!;
        public DbSet<Studiebezoek> Studiebezoeken { get; set; } = default!;
        public DbSet<Vak> Vakken { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Afwezigheid>().ToTable("Afwezigheid");
            modelBuilder.Entity<Begeleiding>().ToTable("Begeleiding");
            modelBuilder.Entity<Bijlage>().ToTable("Bijlage");
            modelBuilder.Entity<Foto>().ToTable("Foto");
            modelBuilder.Entity<FotoAlbum>().ToTable("FotoAlbum");
            modelBuilder.Entity<Gebruiker>().ToTable("Gebruiker");
            modelBuilder.Entity<GebruikerNavorming>().ToTable("GebruikerNavorming");
            modelBuilder.Entity<GebruikerRol>().ToTable("GebruikerRol");
            modelBuilder.Entity<Klas>().ToTable("Klas");
            modelBuilder.Entity<KlasStudiebezoek>().ToTable("KlasStudiebezoek");
            modelBuilder.Entity<Navorming>().ToTable("Navorming");
            modelBuilder.Entity<Rol>().ToTable("Rol");
            modelBuilder.Entity<Studiebezoek>().ToTable("Studiebezoek");
            modelBuilder.Entity<Vak>().ToTable("Vak");

            ////////// ONE TO MANY
            // Studiebezoek
            modelBuilder.Entity<Studiebezoek>()
                .HasOne(p => p.Vak)
                .WithMany(x => x.Studiebezoeken)
                .HasForeignKey(y => y.VakId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Studiebezoek>()
                .HasOne(p => p.Aanvrager)
                .WithMany(x => x.AangevraagdeStudiebezoeken)
                .HasForeignKey(y => y.GebruikerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            // Bijlage
            modelBuilder.Entity<Bijlage>()
                .HasOne(p => p.Studiebezoek)
                .WithMany(x => x.Bijlagen)
                .HasForeignKey(y => y.StudiebezoekId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            // FotoAlbum
            modelBuilder.Entity<FotoAlbum>()
                .HasOne(p => p.Studiebezoek)
                .WithMany(x => x.FotoAlbums)
                .HasForeignKey(y => y.StudiebezoekId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            // Foto
            modelBuilder.Entity<Foto>()
                .HasOne(p => p.FotoAlbum)
                .WithMany(x => x.Fotos)
                .HasForeignKey(y => y.FotoAlbumId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            // Navorming
            modelBuilder.Entity<Navorming>()
                .HasOne(p => p.Aanvrager)
                .WithMany(x => x.AangevraagdeNavormingen)
                .HasForeignKey(y => y.GebruikerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            // Afwezigheid
            modelBuilder.Entity<Afwezigheid>()
                .HasOne(p => p.Gebruiker)
                .WithMany(x => x.Afwezigheden)
                .HasForeignKey(y => y.GebruikerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            ////////// MANY TO MANY
            // KlasStudiebezoek
            modelBuilder.Entity<KlasStudiebezoek>()
                .HasOne(p => p.Klas)
                .WithMany(x => x.KlasStudiebezoeken)
                .HasForeignKey(y => y.KlasId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<KlasStudiebezoek>()
                .HasOne(p => p.Studiebezoek)
                .WithMany(x => x.KlasStudiebezoeken)
                .HasForeignKey(y => y.StudiebezoekId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            // Begeleiding
            modelBuilder.Entity<Begeleiding>()
                .HasOne(p => p.Studiebezoek)
                .WithMany(x => x.Begeleiders)
                .HasForeignKey(y => y.StudiebezoekId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Begeleiding>()
                .HasOne(p => p.Gebruiker)
                .WithMany(x => x.BegeleidStudiebezoeken)
                .HasForeignKey(y => y.GebruikerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            // GebruikerNavorming
            modelBuilder.Entity<GebruikerNavorming>()
                .HasOne(p => p.Gebruiker)
                .WithMany(x => x.GebruikerNavormingen)
                .HasForeignKey(y => y.GebruikerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<GebruikerNavorming>()
                .HasOne(p => p.Navorming)
                .WithMany(x => x.GebruikerNavormingen)
                .HasForeignKey(y => y.NavormingId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            // GebruikerRol
            modelBuilder.Entity<GebruikerRol>()
                .HasOne(p => p.Gebruiker)
                .WithMany(x => x.GebruikerRollen)
                .HasForeignKey(y => y.GebruikerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<GebruikerRol>()
                .HasOne(p => p.Rol)
                .WithMany(x => x.GebruikerRollen)
                .HasForeignKey(y => y.RolId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            ////////// PROPERTIES MET GELDWAARDEN
            modelBuilder.Entity<Studiebezoek>()
                .Property(p => p.KostprijsStudiebezoek)
                .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Studiebezoek>()
                .Property(p => p.KostprijsVervoer)
                .HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Navorming>()
                .Property(p => p.Kostprijs)
                .HasColumnType("decimal(18,2)");
        }
    }
}