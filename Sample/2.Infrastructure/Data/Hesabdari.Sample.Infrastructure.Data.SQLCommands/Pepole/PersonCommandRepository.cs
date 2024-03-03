using Hesabdari.Infrastructure.Data.SQLCommands;
using Hesabdari.Sample.Core.Contracts.Pepole.Commands;
using Hesabdari.Sample.Core.Domain.Pepole.Entities;
using Hesabdari.Sample.Infrastructure.Data.SQLCommands.Common;

namespace Hesabdari.Sample.Infrastructure.Data.SQLCommands.Pepole
{
    public class PersonCommandRepository : BaseCommandRepository<Person, SampleCommandDbContext>, IPersonCommandRepository
    {
        public PersonCommandRepository(SampleCommandDbContext dbContext) : base(dbContext)
        {
        }
    }
}
