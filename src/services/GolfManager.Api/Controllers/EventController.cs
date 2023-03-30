using GolfManager.Application.Dtos.Event;
using GolfManager.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GolfManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;
        public EventController(IEventService eventService)
        {
            _eventService = eventService;

        }
        [HttpGet]
        public async Task<IActionResult> GetAllEvents()
        {
            return Ok(await _eventService.GetAllEvents());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEventById(int id)
        {
            return Ok(await _eventService.GetEventById(id));
        }
        [HttpPost]
        public async Task<IActionResult> CreateEvent(CreateUpdateEventDto createEvent)
        {           
            return Ok(await _eventService.AddEvent(createEvent));
        }

    }
}
