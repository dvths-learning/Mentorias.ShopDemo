using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace McbEdu.Mentorias.ShopDemo.WebApi.Filters;

public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var errorResult = new { error = "An error occurred while processing your request"};

        context.Result = new ObjectResult(errorResult)
        {
            StatusCode = 500
        };

        context.ExceptionHandled = true;
    }
}