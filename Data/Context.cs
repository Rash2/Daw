using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Notes_App.Entities;
using Microsoft.EntityFrameworkCore;

namespace Notes_App.Data
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User> Users { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //User M M Role
            builder.Entity<UserRole>()
                .HasOne(x => x.User)
                .WithMany(y => y.UserRoles)
                .HasForeignKey(z => z.UserId);

            builder.Entity<UserRole>()
                .HasOne(x => x.Role)
                .WithMany(y => y.UserRoles)
                .HasForeignKey(z => z.RoleId);

            builder.Entity<UserRole>()
                .HasAlternateKey(x => new { x.UserId, x.RoleId });
        }
    }
}
