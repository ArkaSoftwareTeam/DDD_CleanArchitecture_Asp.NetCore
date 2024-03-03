using Hesabdari.Infrastructure.Data.SQLCommands;
using Microsoft.EntityFrameworkCore;
namespace Hesabdari.Sample.Infrastructure.Data.SQLCommands.Common
{
    public class SampleCommandDbContext:BaseCommandDbContext
    {
        public SampleCommandDbContext(DbContextOptions<SampleCommandDbContext> options):base(options){}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
