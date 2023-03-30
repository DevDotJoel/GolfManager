using GolfManager.Application.Dtos.Field;
using GolfManager.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GolfManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FieldController : ControllerBase
    {
        private readonly IFieldService _fieldService;
        public FieldController(IFieldService fieldService)
        {
            _fieldService = fieldService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllFields()
        {
            return Ok(await _fieldService.GetAllFields());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFieldByIdAsync(int id)
        {
            return Ok(await _fieldService.GetFieldById(id));
        }
        [HttpPost]
        public async Task<IActionResult> CreateField(CreateUpdateFieldDto field)
        {
            return Ok(await _fieldService.AddField(field));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateField(CreateUpdateFieldDto field)
        {
            return Ok(await _fieldService.UpdateField(field));
        }
    }
}
