using BluperDinner.Aplication;
using BluperDinner.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    // moved to DependencyInjection.cs
    // builder.Services.AddScoped<IAuthenticationService,AuthenticationService>();
    builder.Services
        .AddAplication()
        .AddInfrastructure(builder.Configuration);
    builder.Services.AddControllers();
}
// Add services to the container.


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// // removed swagger
// // builder.Services.AddEndpointsApiExplorer();
// // builder.Services.AddSwaggerGen();

var app = builder.Build();
{
    app.UseHttpsRedirection();
    // // app.UseAuthorization();
    app.MapControllers();
    app.Run();
}
// Configure the HTTP request pipeline.
// // if (app.Environment.IsDevelopment()){
// //     app.UseSwagger();
// //     app.UseSwaggerUI();}


