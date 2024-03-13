var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/webhook",async (context) =>
{
    if (!context.Request.Headers.ContainsKey("Authorization"))
    {
        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
        return;
    }
    var apiKey = context.Request.Headers["Authorization"];
    if (apiKey != "APIKEY")
    {
        context.Response.StatusCode = StatusCodes.Status401Unauthorized;
        return;
    }
    var requestbody = await context.Request.ReadFromJsonAsync<WebHookPayload>();
    Console.WriteLine($"Header: {requestbody?.header} Body: {requestbody?.Body}");
    context.Response.StatusCode = 200;
    //implement Webhook
    await context.Response.WriteAsync("WebHook Async");

    //Wehbhooks are event driven. they are same like RESTAPI only they send data automatically when certain events happend
    //For example if user order something than that sends some data to webhook url where it is notified now it sends notification to user 
});

app.Run();


public record WebHookPayload (string header, string Body);