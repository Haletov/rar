using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using repairequipment.models;

namespace repairequipment.Data
{
    public class repairequipmentContext : DbContext
    {
        public repairequipmentContext (DbContextOptions<repairequipmentContext> options)
            : base(options)
        {
        }

        public DbSet<repairequipment.models.Client> Client { get; set; } = default!;
        public DbSet<repairequipment.models.Device> Device { get; set; } = default!;
        public DbSet<repairequipment.models.Employee> Employee { get; set; } = default!;
        public DbSet<repairequipment.models.Request> Request { get; set; } = default!;
    }
}
