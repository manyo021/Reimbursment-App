using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Reimbursment_App.Data;
using Reimbursment_App.Dtos.Ticket;

namespace Reimbursment_App.Services.TicketService
{
    public class TicketService : ITicketService
    {


        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public TicketService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<ServiceResponse<List<GetTicketDto>>> AddTicket(AddTicketDto newticket)
        {
            var ServiceResponse = new ServiceResponse<List<GetTicketDto>>();
            Ticket ticket = _mapper.Map<Ticket>(newticket);
            _context.tickets.Add(ticket);
            await _context.SaveChangesAsync();
            ServiceResponse.Data = await _context.tickets
            .Select(t => _mapper.Map<GetTicketDto>(t))
            .ToListAsync();
            return ServiceResponse;
        }

        public async Task<ServiceResponse<List<GetTicketDto>>> DeleteTicket(int id)
        {
            ServiceResponse<List<GetTicketDto>> response = new ServiceResponse<List<GetTicketDto>>();
            try
            {
                Ticket ticket = await _context.tickets.FirstAsync(t => t.Id == id);
                _context.tickets.Remove(ticket);
                await _context.SaveChangesAsync();
                response.Data = _context.tickets.Select(c => _mapper.Map<GetTicketDto>(c)).ToList();

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetTicketDto>>> GetAllTicket()
        {
            var response = new ServiceResponse<List<GetTicketDto>>();
            var dbTickets = await _context.tickets.ToListAsync();
            response.Data = dbTickets.Select(t => _mapper.Map<GetTicketDto>(t)).ToList();
            return response;



        }

        public async Task<ServiceResponse<GetTicketDto>> GetTicketById(int id)
        {
            var ServiceResponse = new ServiceResponse<GetTicketDto>();
            var dbticket = await _context.tickets.FirstOrDefaultAsync(t => t.Id == id);
            ServiceResponse.Data = _mapper.Map<GetTicketDto>(dbticket);
            return ServiceResponse;
        }

        public async Task<ServiceResponse<GetTicketDto>> UpdateTicket(UpdateTicketDto updatedticket)
        {
            ServiceResponse<GetTicketDto> response = new ServiceResponse<GetTicketDto>();
            try
            {
                var ticket = await _context.tickets
                .FirstOrDefaultAsync(t => t.Id == updatedticket.Id);
                // ticket.Amount = updatedticket.Amount;
                // ticket.Description = updatedticket.Description;
                // ticket.Type = updatedticket.Type;
                ticket.Status = updatedticket.Status;

                await _context.SaveChangesAsync();
                response.Data = _mapper.Map<GetTicketDto>(ticket);

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}