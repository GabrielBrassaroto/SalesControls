using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesControls.Models;

namespace SalesControls.Data
{
    public class SalesControlsContext : DbContext
    {
        public SalesControlsContext (DbContextOptions<SalesControlsContext> options)
            : base(options)
        {
        }

        public DbSet<SalesControls.Models.Sale> Sale { get; set; }
    }
}
