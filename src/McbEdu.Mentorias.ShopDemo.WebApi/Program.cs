using McbEdu.Mentorias.ShopDemo.Application;
using McbEdu.Mentorias.ShopDemo.Infrastructure;
using McbEdu.Mentorias.ShopDemo.WebApi.Filters;

var builder = WebApplication.CreateBuilder(args);

{
    builder.Services
        .AddApplication()
        .AddInfrastructure();

    builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlingFilterAttribute>());
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();

{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.MapControllers();

    app.Run();
}