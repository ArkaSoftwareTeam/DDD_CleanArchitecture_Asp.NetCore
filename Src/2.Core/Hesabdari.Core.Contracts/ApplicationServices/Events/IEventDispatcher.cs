using Hesabdari.Core.Domain.Events;

namespace Hesabdari.Core.Contracts.ApplicationServices.Events
{
    public interface IEventDispatcher
    {
        Task PublishDomainEventAsync<TDomainEvent>(TDomainEvent @event) where TDomainEvent : class, IDomainEvent;
    }
}
