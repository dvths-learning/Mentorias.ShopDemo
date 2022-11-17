namespace McbEdu.Mentorias.ShopDemo.Domain.Models.ENUMs;

public enum TypeHttpStatusCodeResponse
{
    Ok = 200,
    Created = 201,
    BadRequest = 400,
    Unauthorized = 401,
    Forbidden = 403,
    NotFound = 404,
    TooManyRequests = 429,
    InternalServerError = 500
}
