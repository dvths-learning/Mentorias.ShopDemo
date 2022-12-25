using ErrorOr;

using McbEdu.Mentorias.ShopDemo.Application.Services.Import.Customers.Commands;
using McbEdu.Mentorias.ShopDemo.Application.Services.Import.Customers.Common;
using McbEdu.Mentorias.ShopDemo.Contracts.ImportCustomer;

using Microsoft.AspNetCore.Mvc;

namespace McbEdu.Mentorias.ShopDemo.WebApi.Controllers;

[Route("customers")]
public class ImportCustomerController : ApiController
{
    private readonly IImportCustomerCommandService _importCustomerCommandService;

    public ImportCustomerController(IImportCustomerCommandService importCustomerService)
    {
        _importCustomerCommandService = importCustomerService;
    }

    [HttpPost]
    public IActionResult ImportOneCustomer(CustomerImportDataRequest request)
    {
        ErrorOr<ImportCustomerResult> importResult = _importCustomerCommandService.ImportNewCustomer(
            request.FirstName,
            request.LastName,
            request.Email,
            request.BirthDate);

        return importResult.Match(
            importResult => Ok(MapImportResult(importResult)),
            errors => Problem(errors)
        );
    }

    private static CustomerImportDataResponse MapImportResult(ImportCustomerResult importResult)
    {
        return new CustomerImportDataResponse(
            importResult.Customer.Id,
            importResult.Customer.FirstName,
            importResult.Customer.LastName,
            importResult.Customer.Email,
            importResult.Customer.BirthDate);
    }
}