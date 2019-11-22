using System;
using System.Collections.Generic;
using EventStore.ClientAPI;

namespace HangmanBackend.Domain
{
    public interface AggregateRoot
    {
        Guid getAggregateRootId();
        IList<EventData> UncommittedEvents { get; }
        int getPlayHead();
    }
}