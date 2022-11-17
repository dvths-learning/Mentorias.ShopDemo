using McbEdu.Mentorias.ShopDemo.Domain.Models.ValueObjects;

namespace McbEdu.Mentorias.ShopDemo.Domain.Contracts.Services.Handlers;

public abstract class ResponseBase
{
    public string ResponseMessage { get; }
    public DateTime RequestedOn { get; }
    public HttpResponse HttpResponse { get; }

    protected ResponseBase(HttpResponse httpResponse, DateTime requestedOn, string responseMessage)
    {
        HttpResponse = httpResponse;
        RequestedOn = requestedOn;
        ResponseMessage = responseMessage;
    }
}
