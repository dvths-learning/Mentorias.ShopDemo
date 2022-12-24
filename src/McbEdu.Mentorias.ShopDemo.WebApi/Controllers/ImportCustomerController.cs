using McbEdu.Mentorias.ShopDemo.Application.Services.Import.Customers;
using McbEdu.Mentorias.ShopDemo.Contracts.ImportCustomer;

using Microsoft.AspNetCore.Mvc;

namespace McbEdu.Mentorias.ShopDemo.WebApi.Controllers;

[ApiController]
[Route("customers")]
public class ImportCustomerController : ControllerBase
{
    private readonly IImportCustomerService _importCustomerService;

    public ImportCustomerController(IImportCustomerService importCustomerService)
    {
        _importCustomerService = importCustomerService;
    }

    [HttpPost]
    public IActionResult ImportOneCustomer(CustomerImportDataRequest request)
    {
        var importResult = _importCustomerService.ImportNewCustomer(
            request.FirstName,
            request.LastName,
            request.Email,
            request.BirthDate);

        var response = new CustomerImportDataResponse(
            importResult.Customer.Id,
            importResult.Customer.FirstName,
            importResult.Customer.LastName,
            importResult.Customer.Email,
            importResult.Customer.BirthDate);

        return Ok(response);
    }
}