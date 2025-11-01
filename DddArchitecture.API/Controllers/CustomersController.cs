using DddArchitecture.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DddArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerService _service;

        public CustomersController(CustomerService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _service.GetCustomersAsync();
            return Ok(customers);
        }

        [HttpPost]
        public async Task<IActionResult> Create(string name, string email)
        {
            await _service.AddCustomerAsync(name, email);
            return Ok();
        }
    }
}
