using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options)
            :base(options){}
        
        public DbSet<Glass> Glasses {get; set; }
    }
}