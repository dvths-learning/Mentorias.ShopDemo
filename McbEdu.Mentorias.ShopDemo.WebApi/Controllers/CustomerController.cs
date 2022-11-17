using McbEdu.Mentorias.ShopDemo.Services.Handlers.CreateCustomer.Inputs;
using Microsoft.AspNetCore.Mvc;

namespace McbEdu.Mentorias.ShopDemo.WebApi.Controllers;

[Route("/api/v1/Manager/[controller]")]
public class CustomerController : ControllerBase
{
    [HttpPost]
    [Route("Create")]
    public IActionResult Create(
        [FromBody] CreateCustomerInputModel model
        )
    {
        return StatusCode(500, "Recurso ainda não implementado");
    }
}
