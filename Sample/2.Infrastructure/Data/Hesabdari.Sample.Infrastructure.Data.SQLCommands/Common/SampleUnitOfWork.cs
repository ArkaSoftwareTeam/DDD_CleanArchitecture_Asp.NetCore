using Hesabdari.Infrastructure.Data.SQLCommands;
using Hesabdari.Sample.Core.Contracts.Common;

namespace Hesabdari.Sample.Infrastructure.Data.SQLCommands.Common
{
    public class SampleUnitOfWork : BaseEntityFrameworkUnitOfWork<SampleCommandDbContext> , ISampleUnitOfWork
    {
        public SampleUnitOfWork(SampleCommandDbContext dbContext) : base(dbContext)
        {
        }
    }
}
