using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CIT365_SacramentPlanner.Models;

namespace CIT365_SacramentPlanner.Data
{
    public class MeetingContext :DbContext
    {
        public MeetingContext (DbContextOptions<MeetingContext> options) : base(options)
        {
        }

        public DbSet<Meeting> Meeting { get; set; }
    }
}
