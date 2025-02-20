using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {

        }

        public DbSet<Notas> Notas { get; set; }
        public DbSet<Almoxarifados> Almoxarifados { get; set; }
        public DbSet<Centro_de_Custo> Centro_de_Custo { get; set; }
    }
}
