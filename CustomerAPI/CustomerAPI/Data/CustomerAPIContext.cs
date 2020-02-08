using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CustomerAPI.Models
{
    public class CustomerAPIContext : DbContext
    {
        public CustomerAPIContext (DbContextOptions<CustomerAPIContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerAPI.Models.Customer> Customer { get; set; }
    }
}
