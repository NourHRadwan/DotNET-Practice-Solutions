using EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Contexts
{
    internal class EnterpriseGr03DbContext : DbContext
    {
        protected EnterpriseGr03DbContext() : base()
        {
        }

        //The most important informations
        // 1. Server Name
        // 2. Database name
        // 3. Type of Authuntication
        #region Old Method of Connecting EF
        //Old method of connecting entity framework
        // windows euthintcation
        //optionsBuilder.UseSqlServer("Data Source = .; inital Catalog = EnterpriseGr03; Integrated Security = true;");
        // with userId and Password
        //optionsBuilder.UseSqlServer("Data Source = .; inital Catalog = EnterpriseGr03; UserId = Nour; Password = 123;");

        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //New Method of EF
        => optionsBuilder.UseSqlServer("Server = .; Database = EnterpriseGr03; Trusted-Connection = true");
        
        public DbSet<Employee> Employees { get; set; }
        



    }
}
