using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfManager.Domain.Entities
{
    public class EventCustomer
    {
        [Key]
        public int Id { get; set; }
        public int EventId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Event Event { get; set; }
    }
}
