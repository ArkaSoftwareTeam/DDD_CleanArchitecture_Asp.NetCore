using Hesabdari.Infrastructure.Data.SQLQueries;
using Hesabdari.Sample.Core.Contracts.Pepole.Queries;
using Hesabdari.Sample.Infrastructure.Data.SQLQueries.Common;

namespace Hesabdari.Sample.Infrastructure.Data.SQLQueries.Pepole
{
    public class PersonQueryRepository : BaseQueryRepository<SampleQueryDbContext> , IPersonQueryRepository
    {
        public PersonQueryRepository(SampleQueryDbContext dbContext) : base(dbContext)
        {
        }
    }
}
