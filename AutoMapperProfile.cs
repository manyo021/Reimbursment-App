using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Reimbursment_App.Dtos.Ticket;

namespace Reimbursment_App
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Ticket, GetTicketDto>();
            CreateMap<AddTicketDto, Ticket>();
        }
    }
}