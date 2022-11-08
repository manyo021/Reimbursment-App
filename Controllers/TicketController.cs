using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reimbursment_App.Dtos.Ticket;
using Reimbursment_App.Services.TicketService;

namespace Reimbursment_App.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }



        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetTicketDto>>>> Get()
        {
            return Ok(await _ticketService.GetAllTicket());
        }

        //Lowercase
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetTicketDto>>> GetSingle(int id)
        {


            //FirstorDefault finds the first character that matches requirment
            return Ok(await _ticketService.GetTicketById(id));



        }



        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetTicketDto>>>> AddTicket(AddTicketDto ticket)
        {

            return Ok(await _ticketService.AddTicket(ticket));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetTicketDto>>> UpdateTicket(UpdateTicketDto updatedticket)
        {
            var response = await _ticketService.UpdateTicket(updatedticket);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetTicketDto>>>> DeleteTicket(int id)
        {



            var response = await _ticketService.DeleteTicket(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);



        }

    }
}