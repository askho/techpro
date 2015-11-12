namespace Lab4.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=StudentsModel")
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseRegistration> CourseRegistrations { get; set; }
        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
