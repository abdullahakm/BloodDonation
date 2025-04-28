namespace BloodDonation.Api.Common.Extensions.Service.Collections;

public static class SwaggerServiceRegistration
{
    public static IServiceCollection AddSwaggerService(this IServiceCollection service) => service.AddSwaggerGen(options =>
                                                                                                    {
                                                                                                        options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                                                                                                        {
                                                                                                            Title = "Blood Donation API",
                                                                                                            Contact = new Microsoft.OpenApi.Models.OpenApiContact
                                                                                                            {
                                                                                                                Name = "Abdullah Awais",
                                                                                                                Email = "abdullahakm43@gmail.com"

                                                                                                            },
                                                                                                            Description = "API for managing blood donations and hospital integrations",
                                                                                                            Version = "v1"
                                                                                                        });
                                                                                                    });
  
}
