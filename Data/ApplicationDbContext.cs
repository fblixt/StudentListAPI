using Microsoft.EntityFrameworkCore;
using StudentListAPI.Models;

namespace StudentListAPI.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Student> Students { get; set; }
    }
}
