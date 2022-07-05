using Microsoft.EntityFrameworkCore;
using EX1.APIS.NET.Models.DataModels;

namespace EX1.APIS.NET.DataAccess
{
    public class TestDBContext : DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options) : base(options)
        {

        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
    }
}
