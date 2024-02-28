using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        protected DataContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<Activity> Activities{get;set;}
    }
}