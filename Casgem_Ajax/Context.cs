using Microsoft.EntityFrameworkCore;

namespace Casgem_Ajax
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;initial catalog=CasgemAjaxDb;integrated security=true");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
