﻿using System.Threading.Tasks;
using SibsStore.Core.Messages;
using SibsStore.Core.Messages.CommonMessages.DomainEvents;
//using Sibs.Core.Messages.CommonMessages.Notifications;

namespace SibsStore.Core.Communication.Mediator
{
    public interface IMediatorHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
        Task<bool> EnviarComando<T>(T comando) where T : Command;
        //Task PublicarNotificacao<T>(T notificacao) where T : DomainNotification;
        Task PublicarDomainEvent<T>(T notificacao) where T : DomainEvent;
    }
}