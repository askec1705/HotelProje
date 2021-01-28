using HotelEntities;
using Microsoft.EntityFrameworkCore;

namespace HotelDal
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options)
            : base(options) { }


        public virtual DbSet<Personel> Personels { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}
