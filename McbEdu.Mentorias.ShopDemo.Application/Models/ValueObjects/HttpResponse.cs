using McbEdu.Mentorias.ShopDemo.Domain.Models.ENUMs;

namespace McbEdu.Mentorias.ShopDemo.Domain.Models.ValueObjects;

public class HttpResponse
{
    public int Status { get; }
    public string Message { get; }

    public HttpResponse(TypeHttpStatusCodeResponse typeHttpStatusCodeResponse)
    {
        Status = (int)typeHttpStatusCodeResponse;
        Message = typeHttpStatusCodeResponse.ToString();
    }
}
