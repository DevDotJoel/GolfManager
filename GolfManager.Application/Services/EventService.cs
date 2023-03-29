using GolfManager.Application.Dtos.Event;
using GolfManager.Application.Interfaces;
using GolfManager.Domain.Common;
using GolfManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfManager.Application.Services
{
    public class EventService : IEventService
    {
        private readonly IUnitOfWork _unitOfWork;
        public EventService( IUnitOfWork unitOfWork)
        {
            unitOfWork = _unitOfWork;

        }
        public async Task AddEvent(CreateEventDto eventCreate)
        {
            var eventToAdd = new Event(eventCreate.Name,eventCreate.Description,eventCreate.FieldId);
            await _unitOfWork.EventRepository.AddAsync(eventToAdd);
            await _unitOfWork.SaveChangesAsync();
        }

        public Task<EventDto> GetAllEvents()
        {
            throw new NotImplementedException();
        }
    }
}
