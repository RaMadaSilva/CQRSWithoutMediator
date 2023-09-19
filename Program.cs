using CQRWithoutMediator.Commands;
using CQRWithoutMediator.Handlers;
using CQRWithoutMediator.Queries;
using CQRWithoutMediator.Repositories;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

builder.Services.AddScoped<ICommandHander<CreateCustomerCommand, CreateCustomerCommandResult>, CreateCustomerHandler>();
builder.Services.AddScoped<ICommandHander<CustomerQueryByEmail, CustomerQueryResult>, CustomerQueryHandler>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    //app.UseSwaggerUI();
}

app.MapGet("/", async ([FromQuery] CustomerQueryByEmail query, 
            [FromServices] CustomerQueryHandler handler)
    =>
{
    var result = handler.Handler(query);
    return Results.Ok(result);
});

app.MapPost("/", async ([FromBody] CreateCustomerCommand command, [FromServices] CreateCustomerHandler handler)
    =>
{
    var result = handler.Handler(command);

    return Results.Ok(result);
});

app.Run();
