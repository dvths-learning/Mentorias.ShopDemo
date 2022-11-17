using McbEdu.Mentorias.ShopDemo.Domain.Models.ENUMs;

namespace McbEdu.Mentorias.ShopDemo.Domain.Contracts.Services.Handlers;

public abstract class RequestBase
{
    public DateTime RequestedOn { get; }
    public TypeVerbRequest TypeVerbRequest { get; }

    protected RequestBase(DateTime requestedOn, TypeVerbRequest typeVerbRequest)
    {
        RequestedOn = requestedOn;
        TypeVerbRequest = typeVerbRequest;
    }
}
