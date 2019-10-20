using BookStores.Domain;
using System.Data.Entity;

namespace BookStores.Context
{
    public class BookStoreDataContext : DbContext
    {
        public BookStoreDataContext()
            :base("BookStoreConnectionString")
        {

        }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Livro> Livros { get; set; }

    }
}