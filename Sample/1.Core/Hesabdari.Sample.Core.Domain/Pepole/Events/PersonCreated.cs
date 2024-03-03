using Hesabdari.Core.Domain.Events;

namespace Hesabdari.Sample.Core.Domain.Pepole.Events
{
    public record PersonCreated:IDomainEvent
    {
        public Guid BusinessId { get;}
        public string FirstName { get;}
        public string LastName { get;}

        public PersonCreated(Guid businessId , string firstName , string lastName)
        {
            BusinessId = businessId;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
