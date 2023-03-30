using GolfManager.Application.Dtos.Customer;
using GolfManager.Application.Dtos.Event;
using GolfManager.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GolfManager.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            return Ok(await _customerService.GetAllCustomers());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            return Ok(await _customerService.GetCustomerById(id));
        }
        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CreateUpdateCustomerDto createCustomer)
        {
            return Ok(await _customerService.AddCustomer(createCustomer));
        }
    }
}
