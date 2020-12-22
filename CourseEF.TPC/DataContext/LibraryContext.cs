using CourseEF.TPC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseEF.TPC.DataContext
{
    public class LibraryContext : DbContext
    {
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Localidade> Localidades { get; set; }
        public DbSet<Requisicao> Requisicoes { get; set; }
        public DbSet<Utente> Utentes { get; set; }
        public DbSet<LivroAutor> LivroAutores { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Library;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LivroAutor>().HasKey(sc => new { sc.LivroId, sc.AutorId });
        }
    }
}
