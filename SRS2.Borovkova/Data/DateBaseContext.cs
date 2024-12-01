using Microsoft.EntityFrameworkCore;
using SRS2.Borovkova.Models;


namespace SRS2.Borovkova.Data
{
    public class DateBaseContext: DbContext
    {
        public DateBaseContext(DbContextOptions<DateBaseContext> options)
        : base(options)
        { }

        public DbSet<LoginPersonals> LoginPersonal { get; set; }
        //public DbSet<Tovars> Tovar { get; set; }
        //public DbSet<Order> Orders { get; set; }
       
    }
}


