using GloboTicket.TicketManagement.Domain.Entities;

namespace GloboTicket.TicketManagement.Application.Contracts.Persistence
{
    internal interface IOrderRepository : IAsyncRepository<Order>
    {
    }
}