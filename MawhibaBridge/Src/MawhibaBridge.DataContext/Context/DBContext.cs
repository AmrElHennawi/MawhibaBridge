using System.Data;
using MawhibaBridge.Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MawhibaBridge.DataContext.Context
{
    public class DBContext : IdentityDbContext<AppUser>
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Identity Roles
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "Teacher", NormalizedName = "TEACHER" },
                new IdentityRole { Id = "3", Name = "User", NormalizedName = "USER" }
            );

            modelBuilder.Entity<Reply>()
                .HasOne(r => r.Comment)
                .WithMany(c => c.Replies)
                .HasForeignKey(r => r.CommentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SectionSeen>()
                .HasOne(ss => ss.Enrollment)
                .WithMany(e => e.SeenSections)
                .HasForeignKey(ss => ss.EnrollmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseType> CourseTypes { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<SectionSeen> SectionSeens { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}
