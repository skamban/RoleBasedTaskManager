using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoleBasedTaskManager.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RoleBasedTaskManager.Domain.Entities;

namespace RoleBasedTaskManager.Infrastructure.Persistence
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        DbSet<User> Users  => Set<User>();
        DbSet<Role> Roles => Set<Role>();
        DbSet<UserRole> UserRoles => Set<UserRole>();
        DbSet<TaskItem> TaskItems => Set<TaskItem>();
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId});
            });

            modelBuilder.Entity<UserRole>()
           .HasOne(ur => ur.User)
           .WithMany(u => u.UserRoles)
           .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId);
        }
    }
}
