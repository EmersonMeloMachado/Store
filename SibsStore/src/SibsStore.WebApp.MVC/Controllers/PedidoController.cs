
using MediatR;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SibsStore.Core.Communication.Mediator;
using SibsStore.Vendas.Application.Queries;
using SibsStore.Core.Messages.CommonMessages.Notifications;

namespace SibsStore.WebApp.MVC.Controllers
{
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoQueries _pedidoQueries;
        
        public PedidoController(IPedidoQueries pedidoQueries,
            INotificationHandler<DomainNotification> notifications,
            IMediatorHandler mediatorHandler) : base(notifications, mediatorHandler)
        {
            _pedidoQueries = pedidoQueries;
        }
        
        [Route("meus-pedidos")]
        public async Task<IActionResult> Index()
        {
            return View(await _pedidoQueries.ObterPedidosCliente(ClienteId));
        }
    }
}

