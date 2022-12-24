using McbEdu.Mentorias.ShopDemo.Application;
using McbEdu.Mentorias.ShopDemo.Infrastructure;
using McbEdu.Mentorias.ShopDemo.WebApi.Common.Errors;

using Microsoft.AspNetCore.Mvc.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

{
    builder.Services
        .AddApplication()
        .AddInfrastructure();

    builder.Services.AddControllers();
    builder.Services.AddSingleton<ProblemDetailsFactory, ShopDemoProblemDetailsFactory>();
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();

{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();

    app.MapControllers();

    app.Run();
}