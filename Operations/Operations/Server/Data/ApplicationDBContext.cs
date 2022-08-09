using Operations.Shared.Models;
using Microsoft.EntityFrameworkCore;
namespace Operations.Server.Data
{
    public partial class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext()
        {

        }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Operationss> Operationss { get; set; }
    }
}
