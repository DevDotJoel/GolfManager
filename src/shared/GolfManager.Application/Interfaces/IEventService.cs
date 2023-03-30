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
        Task<List<EventDto>> GetAllEvents();
        Task<EventDto> GetEventById(int id);
        Task AddEvent( CreateUpdateEventDto eventCreate);
    }
}
