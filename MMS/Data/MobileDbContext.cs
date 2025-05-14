using Microsoft.EntityFrameworkCore;
using MMS.Models;

namespace MMS.Data
{
    public class MobileDbContext:DbContext
    {
        public MobileDbContext(DbContextOptions<MobileDbContext> options) : base(options) 
        {
        
        
        }

        public DbSet<Mobile> Mobiles { get; set; }
    }
}
