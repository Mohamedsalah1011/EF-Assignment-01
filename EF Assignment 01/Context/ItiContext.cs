using EF_Assignment_01.Model;
using Microsoft.EntityFrameworkCore;

namespace EF_Assignment_01.Context
{
    internal class ItiContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.;Database=ITI_DB;Trusted_Connection=True;TrustServerCertificate=True;")
            .UseLazyLoadingProxies();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            // Composite Keys
            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.stud_ID, sc.Course_ID });

            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.inst_ID, ci.Course_ID });

            // Department : Instructor (One-to-Many)
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Instructor)
                .WithMany()
                .HasForeignKey(d => d.InsId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.DeptId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }


    }
}
