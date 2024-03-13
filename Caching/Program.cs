using Microsoft.Extensions.Caching.Memory;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMemoryCache();

var app = builder.Build();

app.Map("/api/cachedData", app =>
{
    app.Use(async (context, next) =>
    {
        var cache = context.RequestServices.GetRequiredService<IMemoryCache>();

        if (!cache.TryGetValue("cachedData", out string cachedData))
        {
            cachedData = GenerateData();
            cache.Set("cachedData", cachedData, new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(5)
            });
        }

        context.Response.Headers.Add("X-Cached-Data", cachedData);
        await next();
    });
});

app.Run();

string GenerateData()
{
    return "This is cached data.";
}
