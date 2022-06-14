using Microsoft.EntityFrameworkCore;
using WebApiWithSwagger.Models;

namespace CRUDWebApiWithSwagger.Models
{
    public class CrudSampleContext : DbContext
    {
        public CrudSampleContext(DbContextOptions<CrudSampleContext> options) : base(options)
        {
        }

        public DbSet<ValueSamples> ValueSamples { get; set; }
    }
}
