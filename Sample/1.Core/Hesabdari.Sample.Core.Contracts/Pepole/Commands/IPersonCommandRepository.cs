using Hesabdari.Core.Contracts.Data.Commands;
using Hesabdari.Sample.Core.Domain.Pepole.Entities;

namespace Hesabdari.Sample.Core.Contracts.Pepole.Commands
{
    public interface IPersonCommandRepository:ICommandRepository<Person>
    {
    }
}
