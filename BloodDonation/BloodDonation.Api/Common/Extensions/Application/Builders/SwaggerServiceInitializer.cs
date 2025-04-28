namespace BloodDonation.Api.Common.Extensions.Application.Builders
{
    public static class SwaggerServiceInitializer
    {
        public static IApplicationBuilder UseSwaggerService(this IApplicationBuilder app) =>
           app.UseSwagger()
               .UseSwaggerUI(options =>
               {
                      options.SwaggerEndpoint("/swagger/v1/swagger.json", "Blood Donation API v1");
                      options.RoutePrefix = string.Empty;
               });
    }
}
