using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo() 
    { 
        Title = "Afri SMS", 
        Description = "Afri SMS is a sms gateway that helps you to send bulk sms!", 
        Version = "v1", 
        Contact = new OpenApiContact() 
        { 
            Email = "afrinnovat@gmail.com", 
            Name = "Afrinnovat Ltd", 
            Url = new("https://www.afrinnovat.com") 
        } 
    });
});
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapGet("/Welcome", () => "Welcome to Afri Sms developed by Afrinnovat Ltd!");
app.MapPost("/SendSms", () =>
{

});
app.Run();
