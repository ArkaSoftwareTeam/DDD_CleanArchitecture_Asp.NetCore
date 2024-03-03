using Hesabdari.Infrastructure.Data.SQLQueries;
using Microsoft.EntityFrameworkCore;
namespace Hesabdari.Sample.Infrastructure.Data.SQLQueries.Common
{
    public class SampleQueryDbContext : BaseQueryDbContext
    {
        public SampleQueryDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
