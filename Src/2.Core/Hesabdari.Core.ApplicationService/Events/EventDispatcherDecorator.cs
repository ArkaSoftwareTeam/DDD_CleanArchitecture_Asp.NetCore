﻿using Hesabdari.Core.Contracts.ApplicationServices.Events;
using Hesabdari.Core.Domain.Events;

namespace Hesabdari.Core.ApplicationService.Events
{
    public abstract class EventDispatcherDecorator:IEventDispatcher
    {
        #region Fields
        protected IEventDispatcher? _eventDispatcher;
        public abstract int Order { get; }
        #endregion

        #region Constructors
        public EventDispatcherDecorator() { }
        #endregion

        #region Abstract Send Commands
        public abstract Task PublishDomainEventAsync<TDomainEvent>(TDomainEvent @event) where TDomainEvent : class, IDomainEvent;

        public void SetEventDispatcher(IEventDispatcher eventDispatcher)
        {
            _eventDispatcher = eventDispatcher;
        }
        #endregion
    }

}
