using Hesabdari.Core.Domain.Entities;
using Hesabdari.Sample.Core.Domain.Pepole.Events;
using Hesabdari.Sample.Core.Domain.Pepole.ValueObjects;

namespace Hesabdari.Sample.Core.Domain.Pepole.Entities
{
    public class Person:AggregateRoot
    {
        #region Properties
        public FirstName FirstName { get; private set; }
        public LastName LastName { get; private set; }
        #endregion

        public Person(FirstName firstName , LastName lastName) 
        {
            FirstName = firstName;
            LastName = lastName;
            AddEvent(new PersonCreated(BusinessId.Value , FirstName.Value , lastName.Value));
        }
    }
}
