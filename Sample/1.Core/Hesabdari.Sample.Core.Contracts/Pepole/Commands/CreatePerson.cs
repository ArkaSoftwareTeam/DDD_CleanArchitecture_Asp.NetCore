using Hesabdari.Core.Contracts.ApplicationServices.Commands;

namespace Hesabdari.Sample.Core.Contracts.Pepole.Commands
{
    public class CreatePerson:ICommands<long>
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}
