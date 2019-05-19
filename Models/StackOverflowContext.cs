using Microsoft.EntityFrameworkCore;

namespace StackOverflow.Models
{
    public class StackOverflowContext :DbContext
    {
        public StackOverflowContext(DbContextOptions<StackOverflowContext> options) : base(options) {}

        public DbSet<Problema> Problemas { get; set; }
        public DbSet<Solucao> Solucoes { get; set; }
    }
}