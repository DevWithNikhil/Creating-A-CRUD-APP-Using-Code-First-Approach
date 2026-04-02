using CFApproachEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CFApproachEFCore.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
