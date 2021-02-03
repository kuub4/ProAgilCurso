using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using ProAgil.WebAPI.Model;

namespace ProAgil.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}


        public DbSet<Evento> Eventos { get; set; }
            
        
    }
}