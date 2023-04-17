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
app.MapPost("/SendSms", async () =>
{
    List<string> Phones = new List<string> { "078*******", "079*******", "073*******" };
    AfriSms.AfriSms  sms= new AfriSms.AfriSms();
    var dd = await sms.SendSms(SmsSetting.Email, SmsSetting.Password, SmsSetting.CompanySenderId, SmsSetting.UserId, SmsSetting.Message, Phones);
});
app.Run();


public class SmsSetting
{
    public const string Email = "Your email";
    public const string Password = "Your password";
    public const string CompanySenderId = "Your company sender id";
    public const string UserId = "Your user id";
    public const string Message = "hey !!!";
}