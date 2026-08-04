using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VerseVine.Models;

namespace VerseVine.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<VerseVine.Models.Prayer> Prayer { get; set; } = default!;
        public DbSet<VerseVine.Models.Topics> Topics { get; set; } = default!;
    }
}
