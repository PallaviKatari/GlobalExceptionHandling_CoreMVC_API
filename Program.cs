using GlobalExceptionHandling_CoreMVC_API.Middleware;
using GlobalExceptionHandling_CoreMVC_API.Middleware1;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Custom Global Exception Handling Middleware that gives even more control 
//to the developer and makes the entire process much better.
//Custom Global Exception Handling Middleware – Firstly, what is it? 
//It’s a piece of code that can be configured as a middleware in 
//the ASP.NET Core pipeline which contains our custom error handling logics. 
//There are a variety of exceptions that can be caught by this pipeline.

//app.UseMiddleware<GlobalExceptionHandlingMiddleware>();
app.UseMiddleware<ErrorHandlerMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
