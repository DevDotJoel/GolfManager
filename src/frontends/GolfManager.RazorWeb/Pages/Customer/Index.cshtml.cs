using GolfManager.Application.Dtos.Customer;
using GolfManager.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GolfManager.RazorWeb.Pages.Customer
{
    public class IndexModel : PageModel
    {
        private readonly ICustomerService _customerService;
        public IndexModel(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public List<CustomerDto> Customers { get; set; }
        public async Task<IActionResult> OnGet()
        {
            Customers=await _customerService.GetAllCustomers();
            return Page();
        }
    }
}
