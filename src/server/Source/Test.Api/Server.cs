
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Test.Services;


WebHost.CreateDefaultBuilder()
.ConfigureServices(s =>
{
    s.AddControllers();
    s.AddSingleton<IPersonDataStore, PersonDataStore>();
    s.AddCors(builder => {
        builder.AddPolicy("Cors", cp => {
            cp.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
        });
    });
})
.Configure(app =>
{
    app.UseRouting();
    app.UseCors("Cors");
    app.UseEndpoints(e =>
    {
        e.MapControllers();
    });
}).Build().Run();