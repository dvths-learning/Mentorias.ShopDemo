using ErrorOr;

using MapsterMapper;
using MediatR;

using McbEdu.Mentorias.ShopDemo.Application.Import.Commands.ImportOneCustomerCommand;
using McbEdu.Mentorias.ShopDemo.Application.Import.Common;
using McbEdu.Mentorias.ShopDemo.Contracts.ImportCustomer;


using Microsoft.AspNetCore.Mvc;

namespace McbEdu.Mentorias.ShopDemo.WebApi.Controllers;

[Route("customers")]
public class ImportCustomerController : ApiController
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public ImportCustomerController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost]
    public async Task<IActionResult> ImportOneCustomer(CustomerImportDataRequest request)
    {
        var command = _mapper.Map<ImportOneCustomerCommand>(request);

        ErrorOr<ImportCustomerResult> importResult = await _mediator.Send(command);

        return importResult.Match(
            importResult => Ok(_mapper.Map<CustomerImportDataResponse>(importResult)),
            errors => Problem(errors)
        );
    }
}