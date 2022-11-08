using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reimbursment_App.Dtos.Ticket
{
    public class GetTicketDto
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }

        public string Description { get; set; } = string.Empty;

        public reimbursementExpenseType Type { get; set; }

        public string Status { get; set; } = "Pending";
    }
}