using Microsoft.EntityFrameworkCore;
using RestAPI.Models;

namespace RestAPI.Context
{
    public class ClaseContext:DbContext
    {
        public ClaseContext(DbContextOptions<ClaseContext> options): base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }
    }
}
