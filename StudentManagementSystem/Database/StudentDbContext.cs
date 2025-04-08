using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Database.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagementSystem.Database
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base (options)
        {

        }

        //[Table("Students")] || to overide the table name written belows
        public DbSet<Student> Students { get; set; }

    }
}
