using EntityFramework.Contexts;

namespace EntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnterpriseGr03DbContext dbContext = new EnterpriseGr03DbContext();

            //How to deal with the database table entity
            // => dbContext.Employees.Add();
        }
    }
}
