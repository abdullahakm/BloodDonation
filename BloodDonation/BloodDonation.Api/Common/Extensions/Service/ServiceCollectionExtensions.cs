using BloodDonation.Api.Common.Extensions.Service.Collections;
using Microsoft.Extensions.DependencyInjection;

namespace BloodDonation.Api.Common.Extensions.Service;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPresentationServices(this IServiceCollection services)
    {
        services.AddSwaggerService()
            .AddOpenApi()
            .AddControllers();
        return services;
    }
}
