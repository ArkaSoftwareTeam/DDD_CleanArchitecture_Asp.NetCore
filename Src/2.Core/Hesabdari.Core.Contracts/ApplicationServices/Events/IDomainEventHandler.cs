using Hesabdari.Core.Domain.Events;

namespace Hesabdari.Core.Contracts.ApplicationServices.Events
{
    public interface IDomainEventHandler<TDomainEvent>
        where TDomainEvent : IDomainEvent
    {
        Task Handle(TDomainEvent Event);
    }
}
