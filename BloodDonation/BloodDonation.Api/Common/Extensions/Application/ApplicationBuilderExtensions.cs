using BloodDonation.Api.Common.Extensions.Application.Builders;

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
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
        return app;
    }
}
