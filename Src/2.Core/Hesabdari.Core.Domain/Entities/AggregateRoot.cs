using Hesabdari.Core.Domain.Events;
using System.ComponentModel;
using System.Reflection;

namespace Hesabdari.Core.Domain.Entities
{
    public abstract class AggregateRoot:Entity
    {
        private readonly List<IDomainEvent>? _events;
        protected AggregateRoot() => _events = new();

        public AggregateRoot(IEnumerable<IDomainEvent> events)
        {
            if(events == null || !events.Any()) return;
            foreach(var @event in events)
            {
                Mutate(@event);
            }
        
        }

        protected void Apply(IDomainEvent @event) 
        { 
            Mutate(@event);
            AddEvent(@event);
        }
        private void Mutate(IDomainEvent @event) 
        {
            var onMethod = this.GetType().GetMethod("On", BindingFlags.Instance | BindingFlags.NonPublic, new Type[] { @event.GetType() });
            onMethod!.Invoke(this , new[] { @event });
        }
        protected void AddEvent(IDomainEvent @event) => _events!.Add(@event);

        public IEnumerable<IDomainEvent> GetEvents() => _events!.AsEnumerable();
        public void ClearEvents() => _events!.Clear();
    }
}
