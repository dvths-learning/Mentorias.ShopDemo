using Mapster;

using McbEdu.Mentorias.ShopDemo.Application.Import.Commands.ImportOneCustomerCommand;
using McbEdu.Mentorias.ShopDemo.Application.Import.Common;
using McbEdu.Mentorias.ShopDemo.Contracts.ImportCustomer;

namespace McbEdu.Mentorias.ShopDemo.WebApi.Common.Mapping;

public class ImportOneCustomerMappingConfig : IRegister
{
    // Configuração do mapeamento entre o resultado do serviço e a resposta adequada ao client.
    public void Register(TypeAdapterConfig config)
    {
        // No momento apenas mapeio os dados do resultado da importação para as propriedades da entidade. 
        config.NewConfig<CustomerImportDataRequest, ImportOneCustomerCommand>()
            .MapWith(request => new ImportOneCustomerCommand(
                request.FirstName,
                request.LastName,
                request.Email,
                request.BirthDate));
        config.NewConfig<ImportCustomerResult, CustomerImportDataResponse>()
            .MapWith(result => new CustomerImportDataResponse(
                result.Customer.Id,
                result.Customer.FirstName,
                result.Customer.LastName,
                result.Customer.Email,
                result.Customer.BirthDate
            ));
    }
}