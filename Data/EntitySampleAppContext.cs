using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntitySampleApp.Models;

namespace EntitySampleApp.Data
{
    public class EntitySampleAppContext : DbContext
    {
        public EntitySampleAppContext (DbContextOptions<EntitySampleAppContext> options)
            : base(options)
        {
        }

        public DbSet<EntitySampleApp.Models.Person> Person { get; set; }
    }
}
