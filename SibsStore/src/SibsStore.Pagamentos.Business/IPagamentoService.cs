using System;
using SibsStore.Core.DomainObjects.DTO;

namespace SibsStore.Pagamentos.Business
{
    public interface IPagamentoService
    {
        Task<Transacao> RealizarPagamentoPedido(PagamentoPedido pagamentoPedido);
    }
}

