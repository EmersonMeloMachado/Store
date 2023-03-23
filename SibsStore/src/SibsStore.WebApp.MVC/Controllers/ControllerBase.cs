using System;
using MediatR;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SibsStore.Core.Communication.Mediator;
using SibsStore.Core.Messages.CommonMessages.Notifications;

namespace SibsStore.WebApp.MVC.Controllers
{
    public abstract class ControllerBase : Controller
    {
       private readonly DomainNotificationHandler _notifications;
       private readonly IMediatorHandler _mediatorHandler;

       protected Guid ClienteId = Guid.Parse("4885e451-b0e4-4490-b959-04fabc806d32");
       private INotificationHandler<DomainNotification> notifications;
       private IMediatorHandler mediatorHandler;

       protected ControllerBase(INotificationHandler<DomainNotification> notifications,
                                IMediatorHandler mediatorHandler)
       {
           _notifications = (DomainNotificationHandler)notifications;
           _mediatorHandler = mediatorHandler;
       }
       
       protected bool OperacaoValida()
       {
           return !_notifications.TemNotificacao();
       }
       
       protected IEnumerable<string> ObterMensagensErro()
       {
           return _notifications.ObterNotificacoes().Select(c => c.Value).ToList();
       }
       
       protected void NotificarErro(string codigo, string mensagem)
       {
           _mediatorHandler.PublicarNotificacao(new DomainNotification(codigo, mensagem));
       }
    }
}

