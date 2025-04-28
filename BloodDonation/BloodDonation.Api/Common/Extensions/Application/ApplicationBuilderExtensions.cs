using BloodDonation.Api.Common.Extensions.Application.Builders;
using BloodDonation.Api.Common.Middlewares;

namespace BloodDonation.Api.Common.Extensions.Application;

public static class ApplicationBuilderExtensions
{
    public static IApplicationBuilder UsePresentationServices(this WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }
        app.UseSwaggerService();
        app.UseMiddleware<GlobalExceptionHandlingMiddleware>();
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
        return app;
    }
}
