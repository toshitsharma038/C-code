using Microsoft.EntityFrameworkCore;

namespace CoolApi.Models
{
    public class StudentContext: DbContext
    {
        public StudentContext(DbContextOptions options): base(options)
        {
        }

        //Here Students is table name in DataBase
        public DbSet<Student> Students { get; set; }
    }
}