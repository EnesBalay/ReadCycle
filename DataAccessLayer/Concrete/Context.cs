using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySql("server=localhost;port=3306;database=readcycleDb;user=root;password=ali2525;", new MySqlServerVersion(new Version(8, 0, 31)));
            //optionBuilder.UseMySql("server=sql.freedb.tech;port=3306;database=freedb_turtledbdb;user=freedb_admina;password=@vXjq$TQ3raBvcU;", new MySqlServerVersion(new Version(8, 0, 31)));
        }
        public DbSet<User> Users { get; set; }
    }
}
