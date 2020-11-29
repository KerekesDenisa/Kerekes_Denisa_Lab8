using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kerekes_Denisa_Lab8.Models;

namespace Kerekes_Denisa_Lab8.Data
{
    public class Kerekes_Denisa_Lab8Context : DbContext
    {
        public Kerekes_Denisa_Lab8Context (DbContextOptions<Kerekes_Denisa_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Kerekes_Denisa_Lab8.Models.Book> Book { get; set; }

        public DbSet<Kerekes_Denisa_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Kerekes_Denisa_Lab8.Models.Category> Category { get; set; }
    }
}
