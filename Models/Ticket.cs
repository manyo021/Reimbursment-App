using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reimbursment_App.Models
{
    public class Ticket
    {

        public Ticket()
        {
            Date = DateTime.Now;
        }

        public int Id { get; set; }


        [Column(TypeName = "decimal(18,4)")]
        public decimal Amount { get; set; }

        public string Description { get; set; } = string.Empty;

        public reimbursementExpenseType Type { get; set; }

        public string Status { get; set; } = "Pending";

        public User? User { get; set; }

        public DateTime Date { get; private set; }


    }
}