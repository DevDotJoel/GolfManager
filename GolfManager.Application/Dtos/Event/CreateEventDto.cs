using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfManager.Application.Dtos.Event
{
    public class CreateEventDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int FieldId { get; set; }
    }
}
