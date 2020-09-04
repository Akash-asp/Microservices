using Microsoft.EntityFrameworkCore;
using System;
using UserService.Model;

namespace UserService.Context
{
    public class UserApiContext :  DbContext
    {
        public UserApiContext(DbContextOptions<UserApiContext> options) : base(options)
        {
            //
        }
        public DbSet<User> User { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
