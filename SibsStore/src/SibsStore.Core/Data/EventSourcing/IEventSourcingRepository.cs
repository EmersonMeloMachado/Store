using System;
using SibsStore.Core.Messages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SibsStore.Core.Data.EventSourcing
{
    public interface IEventSourcingRepository
    {
        Task SalvarEvento<TEvent>(TEvent evento) where TEvent : Event;
        Task<IEnumerable<StoredEvent>> ObterEventos(Guid aggregateId);
    }
}

