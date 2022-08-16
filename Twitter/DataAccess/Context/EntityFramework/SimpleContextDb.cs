using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context.EntityFramework
{
    public class SimpleContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-J3LNJOG\SQLEXPRESS;Database=Twitter;Integrated Security=true;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<EmailParameter> EmailParameters { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Tweet> Tweets { get; set; }
        public DbSet<Url> Urls { get; set; }
    }
}
