﻿using System;
using SibsStore.Core.Messages;

namespace SibsStore.Vendas.Application.Events
{
    public class VoucherAplicadoPedidoEvent : Event
    {
        public Guid ClienteId { get; private set; }
        public Guid PedidoId { get; private set; }
        public Guid VoucherId { get; private set; }

        public VoucherAplicadoPedidoEvent(Guid clienteId, Guid pedidoId, Guid voucherId)
        {
            AggregateId = pedidoId;
            ClienteId = clienteId;
            PedidoId = pedidoId;
            VoucherId = voucherId;
        }
    }
}

