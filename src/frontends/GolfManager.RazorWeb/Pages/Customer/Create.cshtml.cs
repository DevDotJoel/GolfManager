using GolfManager.Application.Dtos.Customer;
using GolfManager.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NToastNotify;

namespace GolfManager.RazorWeb.Pages.Customer
{
    public class CreateModel : PageModel
    {
        private readonly IToastNotification _toastNotification;
        private readonly ICustomerService _customerService;
        [BindProperty]
        public CreateUpdateCustomerDto Customer { get; set; }
        public CreateModel(ICustomerService customerService, IToastNotification toastNotification)
        {
            _customerService = customerService;
            _toastNotification = toastNotification;

        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                await _customerService.AddCustomer(Customer);
                _toastNotification.AddSuccessToastMessage("Created with success");
                return Redirect("/Customer/Index");


            }
            else
            {
                return Page();
            }
        }
    }
}
