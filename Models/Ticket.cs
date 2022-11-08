using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reimbursment_App.Models
{
    public class Ticket
    {
        public int Id { get; set; }


        [Column(TypeName = "decimal(18,4)")]
        public decimal Amount { get; set; }

        public string Description { get; set; } = string.Empty;

        public reimbursementExpenseType Type { get; set; }

        public string Status { get; set; } = "Pending";

        public User? User { get; set; }
    }
}