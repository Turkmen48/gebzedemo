using Microsoft.EntityFrameworkCore;

namespace gebzedemo.Models
{
    public class Context
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4JD2R8F\\TEW_SQLEXPRESS;Database=gezgebze; User ID=sa;Password=enesusta; Integrated Security=True");
        }
        public DbSet<AdminGetData> adminGetData { get; set; }
    }
}
