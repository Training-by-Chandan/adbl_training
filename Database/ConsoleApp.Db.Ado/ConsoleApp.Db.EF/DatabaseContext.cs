using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp.Db.EF
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-PT71T7O\\SQLBHAGAT;Initial Catalog=Adb.Console.EF.CodeFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Classes> Classes { get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string? Email { get; set; }
        public string Active { get; set; }
        public int? ClassId { get; set; }
        
        [ForeignKey("ClassId")]
        public virtual Classes? ClassItem { get; set; }

        public int? ClassId2 { get; set; }
        [ForeignKey("ClassId2")]
        public virtual Classes? ClassItem2 { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
    public class Classes
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}