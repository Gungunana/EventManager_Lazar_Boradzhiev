using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    internal class EventManagerDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public EventManagerDbContext() : base()
        {
            this.Events = this.Set<Event>();
        }
    }
}
