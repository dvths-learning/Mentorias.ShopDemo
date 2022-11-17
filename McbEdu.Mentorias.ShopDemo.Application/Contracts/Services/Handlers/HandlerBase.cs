namespace McbEdu.Mentorias.ShopDemo.Domain.Contracts.Services.Handlers;

public abstract class HandlerBase<Response, Request> where Response : class where Request : class
{
    public abstract Task<Response> Handle(Request request);
}
