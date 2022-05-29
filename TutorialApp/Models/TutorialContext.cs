using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorialApp.Models
{
    public class TutorialContext : DbContext
    {
        public TutorialContext(DbContextOptions<TutorialContext> options) : base(options)
        {
        }

        public DbSet<Tutorial> Tutorial { get; set; }
    }
}
