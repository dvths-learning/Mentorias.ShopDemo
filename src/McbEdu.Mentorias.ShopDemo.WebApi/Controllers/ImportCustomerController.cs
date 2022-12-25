using ErrorOr;

using McbEdu.Mentorias.ShopDemo.Application.Import.Commands.ImportOneCustomerCommand;
using McbEdu.Mentorias.ShopDemo.Application.Import.Common;
using McbEdu.Mentorias.ShopDemo.Contracts.ImportCustomer;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace McbEdu.Mentorias.ShopDemo.WebApi.Controllers;

[Route("customers")]
public class ImportCustomerController : ApiController
{
    private readonly ISender _mediator;

    public ImportCustomerController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> ImportOneCustomer(CustomerImportDataRequest request)
    {
        var command = new ImportOneCustomerCommand(
            request.FirstName,
            request.LastName,
            request.Email,
            request.BirthDate);

        ErrorOr<ImportCustomerResult> importResult = await _mediator.Send(command);

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