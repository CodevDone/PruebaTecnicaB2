using BluperDinner.API.Controllers;
using BluperDinner.API.Filters;
using BluperDinner.API.MiddleWare;
using BluperDinner.Aplication;
using BluperDinner.Infrastructure;
using Microsoft.AspNetCore.Mvc.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    // Dependency Injectionm moved to DependencyInjection.cs
    // builder.Services.AddScoped<IAuthenticationService,AuthenticationService>();
    builder.Services
        .AddAplication()
        .AddInfrastructure(builder.Configuration);
    builder.Services.AddControllers();

    builder.Services.AddSingleton<ProblemDetailsFactory,DinnerProblemDetailsFactory>();

    // optional configuration filter
    // builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlingFilterAttribute>());
}
// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// // removed swagger
// // builder.Services.AddEndpointsApiExplorer();
// // builder.Services.AddSwaggerGen();

var app = builder.Build();
{
    // app.UseMiddleware<ErrorHandlingMiddleware>();
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    // app.UseAuthorization();
    app.MapControllers();
    app.Run();
}
// Configure the HTTP request pipeline.
// // if (app.Environment.IsDevelopment()){
// //     app.UseSwagger();
// //     app.UseSwaggerUI();}


