using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorConfApp.Models;

namespace BlazorConfApp.Data
{
    public class BlazorConfAppContext : DbContext
    {
        public BlazorConfAppContext (DbContextOptions<BlazorConfAppContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorConfApp.Models.ConferenceSession> ConferenceSession { get; set; } = default!;
    }
}
