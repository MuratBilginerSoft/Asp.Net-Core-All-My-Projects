using DeveloperEng_App.Models;
using Microsoft.EntityFrameworkCore;

namespace DeveloperEng_App.DataContext
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public DbSet<Authentication> Authentications { get; set; }
        public DbSet<Word> Words { get; set; }


    }
}
