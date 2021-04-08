using Microsoft.EntityFrameworkCore;
using ProjectManagement.Entities;

namespace ProjectManagement.Shared
{
    public class PMContext : DbContext
    {
        public PMContext(DbContextOptions<PMContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
