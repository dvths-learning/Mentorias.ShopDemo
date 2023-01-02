using ErrorOr;

using FluentValidation;

using MediatR;

namespace McbEdu.Mentorias.ShopDemo.Application.Common.Behaviors;

// Escrever uma pipeline de comportamento que envolverá o comando de importação 
public class ValidationBehavior <TRequest, TResponse> :
    IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
    where TResponse : IErrorOr
{
    private readonly IValidator<TRequest>? _validator;

    public ValidationBehavior(IValidator<TRequest>? validator = null)
    {
        _validator = validator;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        if(_validator is null)
        {
            return await next();
        }

        var validationResult = await _validator.ValidateAsync(request, cancellationToken);

        if(validationResult.IsValid)
        {
            return await next();
        }

        var errors = validationResult.Errors
            .ConvertAll(validationFailure => Error.Validation(
                validationFailure.PropertyName,
                validationFailure.ErrorMessage));
        /*
            Lançará um erro em runtime caso não houver possibilidade de transformar a lista de erros em um objeto ErrorOr
            Apesar de perigoso, aqui eu sei que chegará uma lista possível de ser convertida por causa da restrição do tipo de resposta
            Se algo excepcional gerar uma exceção, ainda poderei contar com o tratamento global para rastrear.
            Possível usar reflection? 
            Link da documentação da lib em que há o uso de reflection para obter o mesmo resultado:
            https://github.com/amantinband/error-or#dropping-the-exceptions-throwing-logic
        */

        return (dynamic)errors;
    }
}