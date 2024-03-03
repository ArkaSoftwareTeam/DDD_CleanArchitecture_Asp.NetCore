using Hesabdari.Core.Contracts.Data.Queries;

namespace Hesabdari.Infrastructure.Data.SQLQueries
{
    public class BaseQueryRepository<TDbContext>:IQueryRepository where TDbContext:BaseQueryDbContext
    {
        protected readonly TDbContext _dbContext;
        public BaseQueryRepository(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
