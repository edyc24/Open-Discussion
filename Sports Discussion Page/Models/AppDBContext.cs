using Microsoft.EntityFrameworkCore;

namespace Sports_Discussion_Page.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=ProjectDB;Integrated Security=True;MultipleActiveResultSets=True");
        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contribution> Contributions { get; set; }
        public DbSet<Discussion> Discussions { get; set; }

    }
}
