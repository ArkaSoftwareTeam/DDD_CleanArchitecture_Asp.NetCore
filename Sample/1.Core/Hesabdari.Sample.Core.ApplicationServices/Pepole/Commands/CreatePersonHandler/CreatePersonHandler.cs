using Hesabdari.Core.ApplicationService.Commands;
using Hesabdari.Core.Contracts.ApplicationServices.Commands;
using Hesabdari.Sample.Core.Contracts.Pepole.Commands;
using Hesabdari.Sample.Core.Domain.Pepole.Entities;
using Hesabdari.Utilities.Services;

namespace Hesabdari.Sample.Core.ApplicationServices.Pepole.Commands.CreatePersonHandler
{
    public class CreatePersonHandler : CommandHandler<CreatePerson , long>
    {
        private readonly IPersonCommandRepository repository;

        public CreatePersonHandler(HesabdariServices HesabdariServices , IPersonCommandRepository repository) : base(HesabdariServices)
        {
            this.repository = repository;
        }

        public override async Task<CommandResult<long>> Handle(CreatePerson command)
        {
            Person person = new(new(command.FirstName) , new(command.LastName));
            await repository.InsertAsync(person);
            await repository.CommitAsync();
            return Ok(person.Id);

        }
    }
}
