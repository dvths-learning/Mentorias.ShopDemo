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
        var importCustomerResult = _importCustomerService.ImportNewCustomer(
            request.FirstName,
            request.LastName,
            request.Email,
            request.BirthDate);

        var response = new CustomerImportDataResponse(
            importCustomerResult.Id,
            importCustomerResult.FirstName,
            importCustomerResult.LastName,
            importCustomerResult.Email,
            importCustomerResult.BirthDate);

        return Ok(response);
    }
}