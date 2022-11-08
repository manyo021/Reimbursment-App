using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reimbursment_App.Dtos.Ticket;

namespace Reimbursment_App.Services.TicketService
{
    public interface ITicketService
    {
        Task<ServiceResponse<List<GetTicketDto>>> GetAllTicket();
        Task<ServiceResponse<GetTicketDto>> GetTicketById(int id);

        Task<ServiceResponse<List<GetTicketDto>>> AddTicket(AddTicketDto ticket);

        Task<ServiceResponse<GetTicketDto>> UpdateTicket(UpdateTicketDto updatedticket);

        Task<ServiceResponse<List<GetTicketDto>>> DeleteTicket(int id);
    }
}