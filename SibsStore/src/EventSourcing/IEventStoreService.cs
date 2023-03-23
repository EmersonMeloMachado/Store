using System;
using EventStore.ClientAPI;

namespace EventSourcing
{
    public interface IEventStoreService
    {
        IEventStoreConnection GetConnection();
    }
}

