using GolfManager.Application.Dtos.Customer;
using GolfManager.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GolfManager.RazorWeb.Pages.Customer
{
    public class EditModel : PageModel
    {
        private readonly ICustomerService _customerService;
        public EditModel(ICustomerService customerService)
        {
            _customerService = customerService;

        }
        [BindProperty]
        public CreateUpdateCustomerDto Customer { get; set; }
        public async Task<IActionResult>  OnGet(int? id)
        {
            if(id is not null)
            {
                var currentCustomer = await _customerService.GetCustomerById(id.Value);
                if(currentCustomer != null)
                {
                    Customer = new CreateUpdateCustomerDto();
                    Customer.Id= currentCustomer.Id;
                    Customer.Name= currentCustomer.Name;
                    Customer.PhoneNumber= currentCustomer.PhoneNumber;
                    return Page();
                }
                else
                {
                    return Redirect("Customers");
                }

            }
            return Redirect("Customers");
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (Customer is not null)
            {
                 await _customerService.UpdateCustomer(Customer);                
                 return Redirect("/Customer/Index");
                

            }
            else
            {
                return Page();
            }
        }
    }
}
