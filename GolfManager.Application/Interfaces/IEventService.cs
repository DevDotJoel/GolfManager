using GolfManager.Application.Dtos.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfManager.Application.Interfaces
{
    public interface IEventService
    {
        Task<EventDto> GetAllEvents();
        Task AddEvent( CreateEventDto eventCreate);
    }
}
