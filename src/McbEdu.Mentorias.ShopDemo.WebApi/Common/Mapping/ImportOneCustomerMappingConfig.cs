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
        config.NewConfig<CustomerImportDataRequest, ImportOneCustomerCommand>();
        config.NewConfig<ImportCustomerResult, CustomerImportDataResponse>()
            .Map(dest => dest, src => src.Customer);
    }
}