﻿using Hesabdari.Core.Domain.Events;

namespace Hesabdari.Core.Contracts.Data.Commands
{

    /// <summary>
    /// If you need to save and retrieve events, this interface is used.
    /// </summary>
    public interface IDomainEventStore
    {
        void Save<TEvent>(string aggregateName, string aggregateId, IEnumerable<TEvent> events) where TEvent : IDomainEvent;
        Task SaveAsync<TEvent>(string aggregateName, string aggregateId, IEnumerable<TEvent> events) where TEvent : IDomainEvent;
    }
}
