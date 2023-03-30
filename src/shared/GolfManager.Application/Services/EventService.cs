using AutoMapper;
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
        private readonly IMapper _mapper;
        public EventService( IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
              

        }
        public async Task<EventDto> AddEvent(CreateUpdateEventDto eventCreate)
        {
            var eventToAdd = new Event(eventCreate.Name,eventCreate.Description,eventCreate.FieldId);
            await _unitOfWork.EventRepository.AddAsync(eventToAdd);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<EventDto>(eventToAdd);
        }

        public async Task<List<EventDto>> GetAllEvents()
        {
            return _mapper.Map<List<EventDto>>(await _unitOfWork.EventRepository.GetAllAsync());
        }

        public async Task<EventDto> GetEventById(int id)
        {
           return _mapper.Map<EventDto>(await _unitOfWork.EventRepository.GetByIdAsync(id));
        }

        public async Task<EventDto> UpdateEvent(CreateUpdateEventDto eventCreate)
        {
                  
            var currentEvent= await _unitOfWork.EventRepository.GetByIdAsync(eventCreate.Id);
            currentEvent.SetName(eventCreate.Name);
            currentEvent.SetDescription(eventCreate.Description);
            _unitOfWork.EventRepository.Update(currentEvent);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<EventDto>(currentEvent);

        
        }
    }
}
